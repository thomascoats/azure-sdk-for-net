﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Azure.AI.OpenAI
{
    public class StreamingChoice
    {
        private readonly IList<Choice> _baseChoices;
        private readonly object _baseChoicesLock = new object();
        private readonly AsyncAutoResetEvent _updateAvailableEvent;

        /// <summary>
        /// Gets the response index associated with this StreamingChoice as represented relative to other Choices
        /// in the same Completions response.
        /// </summary>
        /// <remarks>
        /// Indices may be used to correlate individual Choices within a Completions result to their configured
        /// prompts as provided in the request. As an example, if two Choices are requested for each of four prompts,
        /// the Choices with indices 0 and 1 will correspond to the first prompt, 2 and 3 to the second, and so on.
        /// </remarks>
        public int? Index => GetLocked(() => _baseChoices.Last().Index);

        /// <summary>
        /// Gets a value representing why response generation ended when producing this StreamingChoice.
        /// </summary>
        /// <remarks>
        /// Normal termination typically provides "stop" and encountering token limits in a request typically
        /// provides "length." If no value is present, this StreamingChoice is still in progress.
        /// </remarks>
        public CompletionsFinishReason? FinishReason => GetLocked(() => _baseChoices.Last().FinishReason);

        /// <summary>
        /// Information about the content filtering category (hate, sexual, violence, self_harm), if it
        /// has been detected, as well as the severity level (very_low, low, medium, high-scale that
        /// determines the intensity and risk level of harmful content) and if it has been filtered or not.
        /// </summary>
        public ContentFilterResults ContentFilterResults
            => GetLocked(() =>
            {
                return _baseChoices
                    .LastOrDefault(baseChoice => baseChoice.ContentFilterResults != null && baseChoice.ContentFilterResults.Hate != null)
                    ?.ContentFilterResults;
            });

        private bool _isFinishedStreaming { get; set; } = false;

        private Exception _pumpException { get; set; }

        /// <summary>
        /// Gets the log probabilities associated with tokens in this Choice.
        /// </summary>
        public CompletionsLogProbabilityModel LogProbabilityModel
            => GetLocked(() => _baseChoices.Last().LogProbabilityModel);

        internal StreamingChoice(Choice originalBaseChoice)
        {
            _baseChoices = new List<Choice>() { originalBaseChoice };
            _updateAvailableEvent = new AsyncAutoResetEvent();
        }

        internal void UpdateFromEventStreamChoice(Choice streamingChoice)
        {
            lock (_baseChoicesLock)
            {
                _baseChoices.Add(streamingChoice);
            }
            if (streamingChoice.FinishReason != null)
            {
                EnsureFinishStreaming();
            }
            _updateAvailableEvent.Set();
        }

        /// <summary>
        /// Gets an asynchronous enumeration that will retrieve the Completion text associated with this Choice as it
        /// becomes available. Each string will provide one or more tokens, including whitespace, and a full
        /// concatenation of all enumerated strings is functionally equivalent to the single Text property on a
        /// non-streaming Completions Choice.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async IAsyncEnumerable<string> GetTextStreaming(
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            bool isFinalIndex = false;
            for (int i = 0; !isFinalIndex && !cancellationToken.IsCancellationRequested; i++)
            {
                bool doneWaiting = false;
                while (!doneWaiting)
                {
                    lock (_baseChoicesLock)
                    {
                        Choice mostRecentChoice = _baseChoices.Last();

                        doneWaiting = _isFinishedStreaming || i < _baseChoices.Count;
                        isFinalIndex = _isFinishedStreaming && i >= _baseChoices.Count - 1;
                    }

                    if (!doneWaiting)
                    {
                        await _updateAvailableEvent.WaitAsync(cancellationToken).ConfigureAwait(false);
                    }
                }

                if (_pumpException != null)
                {
                    throw _pumpException;
                }

                string newText = string.Empty;
                lock (_baseChoicesLock)
                {
                    if (i < _baseChoices.Count)
                    {
                        newText = _baseChoices[i].Text;
                    }
                }

                if (!string.IsNullOrEmpty(newText))
                {
                    yield return newText;
                }
            }
        }

        internal void EnsureFinishStreaming(Exception pumpException = null)
        {
            if (!_isFinishedStreaming)
            {
                _isFinishedStreaming = true;
                _pumpException = pumpException;
                _updateAvailableEvent.Set();
            }
        }

        private T GetLocked<T>(Func<T> func)
        {
            lock (_baseChoicesLock)
            {
                return func.Invoke();
            }
        }
    }
}
