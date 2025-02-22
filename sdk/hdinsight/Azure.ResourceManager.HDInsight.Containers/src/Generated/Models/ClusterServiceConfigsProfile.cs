// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster service configs. </summary>
    public partial class ClusterServiceConfigsProfile
    {
        /// <summary> Initializes a new instance of ClusterServiceConfigsProfile. </summary>
        /// <param name="serviceName"> Name of the service the configurations should apply to. </param>
        /// <param name="configs"> List of service configs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/> or <paramref name="configs"/> is null. </exception>
        public ClusterServiceConfigsProfile(string serviceName, IEnumerable<ClusterServiceConfig> configs)
        {
            Argument.AssertNotNull(serviceName, nameof(serviceName));
            Argument.AssertNotNull(configs, nameof(configs));

            ServiceName = serviceName;
            Configs = configs.ToList();
        }

        /// <summary> Initializes a new instance of ClusterServiceConfigsProfile. </summary>
        /// <param name="serviceName"> Name of the service the configurations should apply to. </param>
        /// <param name="configs"> List of service configs. </param>
        internal ClusterServiceConfigsProfile(string serviceName, IList<ClusterServiceConfig> configs)
        {
            ServiceName = serviceName;
            Configs = configs;
        }

        /// <summary> Name of the service the configurations should apply to. </summary>
        public string ServiceName { get; set; }
        /// <summary> List of service configs. </summary>
        public IList<ClusterServiceConfig> Configs { get; }
    }
}
