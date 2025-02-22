// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Represents capability of a storage tier. </summary>
    public partial class PostgreSqlFlexibleServerStorageTierCapability : PostgreSqlBaseCapability
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerStorageTierCapability. </summary>
        internal PostgreSqlFlexibleServerStorageTierCapability()
        {
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerStorageTierCapability. </summary>
        /// <param name="capabilityStatus"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="name"> Name to represent Storage tier capability. </param>
        /// <param name="iops"> Supported IOPS for this storage tier. </param>
        internal PostgreSqlFlexibleServerStorageTierCapability(PostgreSqlFlexbileServerCapabilityStatus? capabilityStatus, string reason, string name, long? iops) : base(capabilityStatus, reason)
        {
            Name = name;
            Iops = iops;
        }

        /// <summary> Name to represent Storage tier capability. </summary>
        public string Name { get; }
    }
}
