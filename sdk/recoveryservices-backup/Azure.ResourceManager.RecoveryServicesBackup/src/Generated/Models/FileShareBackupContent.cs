// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> AzureFileShare workload-specific backup request. </summary>
    public partial class FileShareBackupContent : BackupContent
    {
        /// <summary> Initializes a new instance of FileShareBackupContent. </summary>
        public FileShareBackupContent()
        {
            ObjectType = "AzureFileShareBackupRequest";
        }

        /// <summary> Initializes a new instance of FileShareBackupContent. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="recoveryPointExpireOn"> Backup copy will expire after the time specified (UTC). </param>
        internal FileShareBackupContent(string objectType, DateTimeOffset? recoveryPointExpireOn) : base(objectType)
        {
            RecoveryPointExpireOn = recoveryPointExpireOn;
            ObjectType = objectType ?? "AzureFileShareBackupRequest";
        }

        /// <summary> Backup copy will expire after the time specified (UTC). </summary>
        public DateTimeOffset? RecoveryPointExpireOn { get; set; }
    }
}
