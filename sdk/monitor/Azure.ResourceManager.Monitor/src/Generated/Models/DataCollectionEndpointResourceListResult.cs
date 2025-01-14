// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A pageable list of resources. </summary>
    internal partial class DataCollectionEndpointResourceListResult
    {
        /// <summary> Initializes a new instance of DataCollectionEndpointResourceListResult. </summary>
        /// <param name="value"> A list of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DataCollectionEndpointResourceListResult(IEnumerable<DataCollectionEndpointData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DataCollectionEndpointResourceListResult. </summary>
        /// <param name="value"> A list of resources. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal DataCollectionEndpointResourceListResult(IReadOnlyList<DataCollectionEndpointData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of resources. </summary>
        public IReadOnlyList<DataCollectionEndpointData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
