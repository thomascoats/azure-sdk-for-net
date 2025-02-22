// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Represents a list of cluster versions. </summary>
    internal partial class HDInsightClusterVersionListResult
    {
        /// <summary> Initializes a new instance of HDInsightClusterVersionListResult. </summary>
        internal HDInsightClusterVersionListResult()
        {
            Value = new ChangeTrackingList<HDInsightClusterVersion>();
        }

        /// <summary> Initializes a new instance of HDInsightClusterVersionListResult. </summary>
        /// <param name="value"> The list of cluster versions. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal HDInsightClusterVersionListResult(IReadOnlyList<HDInsightClusterVersion> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of cluster versions. </summary>
        public IReadOnlyList<HDInsightClusterVersion> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
