// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Properties of a private endpoint connection. </summary>
    public partial class SynapsePrivateEndpointConnectionProperties
    {
        /// <summary> Initializes a new instance of SynapsePrivateEndpointConnectionProperties. </summary>
        internal SynapsePrivateEndpointConnectionProperties()
        {
        }

        /// <summary> Initializes a new instance of SynapsePrivateEndpointConnectionProperties. </summary>
        /// <param name="privateEndpoint"> The private endpoint which the connection belongs to. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> Provisioning state of the private endpoint connection. </param>
        internal SynapsePrivateEndpointConnectionProperties(SubResource privateEndpoint, SynapsePrivateLinkServiceConnectionState connectionState, string provisioningState)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> The private endpoint which the connection belongs to. </summary>
        internal SubResource PrivateEndpoint { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint?.Id;
        }

        /// <summary> Connection state of the private endpoint connection. </summary>
        public SynapsePrivateLinkServiceConnectionState ConnectionState { get; }
        /// <summary> Provisioning state of the private endpoint connection. </summary>
        public string ProvisioningState { get; }
    }
}
