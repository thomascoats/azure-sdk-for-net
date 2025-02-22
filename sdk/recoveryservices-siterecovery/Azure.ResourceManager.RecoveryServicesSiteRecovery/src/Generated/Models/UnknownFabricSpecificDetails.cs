// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownFabricSpecificDetails. </summary>
    internal partial class UnknownFabricSpecificDetails : FabricSpecificDetails
    {
        /// <summary> Initializes a new instance of UnknownFabricSpecificDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal UnknownFabricSpecificDetails(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}
