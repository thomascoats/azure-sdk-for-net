// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Details related to the IPv4 address configuration. </summary>
    public partial class DataBoxEdgeIPv4Config
    {
        /// <summary> Initializes a new instance of DataBoxEdgeIPv4Config. </summary>
        internal DataBoxEdgeIPv4Config()
        {
        }

        /// <summary> Initializes a new instance of DataBoxEdgeIPv4Config. </summary>
        /// <param name="ipAddress"> The IPv4 address of the network adapter. </param>
        /// <param name="subnet"> The IPv4 subnet of the network adapter. </param>
        /// <param name="gateway"> The IPv4 gateway of the network adapter. </param>
        internal DataBoxEdgeIPv4Config(IPAddress ipAddress, string subnet, string gateway)
        {
            IPAddress = ipAddress;
            Subnet = subnet;
            Gateway = gateway;
        }

        /// <summary> The IPv4 address of the network adapter. </summary>
        public IPAddress IPAddress { get; }
        /// <summary> The IPv4 subnet of the network adapter. </summary>
        public string Subnet { get; }
        /// <summary> The IPv4 gateway of the network adapter. </summary>
        public string Gateway { get; }
    }
}
