// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A add disk(s) input. </summary>
    public partial class A2AAddDisksContent : SiteRecoveryAddDisksProviderSpecificContent
    {
        /// <summary> Initializes a new instance of A2AAddDisksContent. </summary>
        public A2AAddDisksContent()
        {
            VmDisks = new ChangeTrackingList<A2AVmDiskDetails>();
            VmManagedDisks = new ChangeTrackingList<A2AVmManagedDiskDetails>();
            InstanceType = "A2A";
        }

        /// <summary> The list of vm disk details. </summary>
        public IList<A2AVmDiskDetails> VmDisks { get; }
        /// <summary> The list of vm managed disk details. </summary>
        public IList<A2AVmManagedDiskDetails> VmManagedDisks { get; }
    }
}
