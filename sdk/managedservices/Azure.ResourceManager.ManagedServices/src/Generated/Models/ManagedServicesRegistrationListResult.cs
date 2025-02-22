// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedServices;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> The list of registration definitions. </summary>
    internal partial class ManagedServicesRegistrationListResult
    {
        /// <summary> Initializes a new instance of ManagedServicesRegistrationListResult. </summary>
        internal ManagedServicesRegistrationListResult()
        {
            Value = new ChangeTrackingList<ManagedServicesRegistrationData>();
        }

        /// <summary> Initializes a new instance of ManagedServicesRegistrationListResult. </summary>
        /// <param name="value"> The list of registration definitions. </param>
        /// <param name="nextLink"> The link to the next page of registration definitions. </param>
        internal ManagedServicesRegistrationListResult(IReadOnlyList<ManagedServicesRegistrationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of registration definitions. </summary>
        public IReadOnlyList<ManagedServicesRegistrationData> Value { get; }
        /// <summary> The link to the next page of registration definitions. </summary>
        public string NextLink { get; }
    }
}
