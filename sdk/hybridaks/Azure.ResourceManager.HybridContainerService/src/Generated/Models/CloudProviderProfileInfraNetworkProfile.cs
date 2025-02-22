// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> InfraNetworkProfile - List of infra network profiles for the provisioned cluster. </summary>
    internal partial class CloudProviderProfileInfraNetworkProfile
    {
        /// <summary> Initializes a new instance of CloudProviderProfileInfraNetworkProfile. </summary>
        public CloudProviderProfileInfraNetworkProfile()
        {
            VnetSubnetIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CloudProviderProfileInfraNetworkProfile. </summary>
        /// <param name="vnetSubnetIds"> Array of references to azure resource corresponding to the new HybridAKSNetwork object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks/{virtualNetworkName}. </param>
        internal CloudProviderProfileInfraNetworkProfile(IList<string> vnetSubnetIds)
        {
            VnetSubnetIds = vnetSubnetIds;
        }

        /// <summary> Array of references to azure resource corresponding to the new HybridAKSNetwork object e.g. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridContainerService/virtualNetworks/{virtualNetworkName}. </summary>
        public IList<string> VnetSubnetIds { get; }
    }
}
