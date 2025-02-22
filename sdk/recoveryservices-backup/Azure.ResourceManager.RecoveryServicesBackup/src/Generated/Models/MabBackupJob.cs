// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> MAB workload-specific job. </summary>
    public partial class MabBackupJob : BackupGenericJob
    {
        /// <summary> Initializes a new instance of MabBackupJob. </summary>
        public MabBackupJob()
        {
            ActionsInfo = new ChangeTrackingList<JobSupportedAction>();
            ErrorDetails = new ChangeTrackingList<MabErrorInfo>();
            JobType = "MabJob";
        }

        /// <summary> Initializes a new instance of MabBackupJob. </summary>
        /// <param name="entityFriendlyName"> Friendly name of the entity on which the current job is executing. </param>
        /// <param name="backupManagementType"> Backup management type to execute the current job. </param>
        /// <param name="operation"> The operation name. </param>
        /// <param name="status"> Job status. </param>
        /// <param name="startOn"> The start time. </param>
        /// <param name="endOn"> The end time. </param>
        /// <param name="activityId"> ActivityId of job. </param>
        /// <param name="jobType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="duration"> Time taken by job to run. </param>
        /// <param name="actionsInfo"> The state/actions applicable on jobs like cancel/retry. </param>
        /// <param name="mabServerName"> Name of server protecting the DS. </param>
        /// <param name="mabServerType"> Server type of MAB container. </param>
        /// <param name="workloadType"> Workload type of backup item. </param>
        /// <param name="errorDetails"> The errors. </param>
        /// <param name="extendedInfo"> Additional information on the job. </param>
        internal MabBackupJob(string entityFriendlyName, BackupManagementType? backupManagementType, string operation, string status, DateTimeOffset? startOn, DateTimeOffset? endOn, string activityId, string jobType, TimeSpan? duration, IList<JobSupportedAction> actionsInfo, string mabServerName, MabServerType? mabServerType, BackupWorkloadType? workloadType, IList<MabErrorInfo> errorDetails, MabBackupJobExtendedInfo extendedInfo) : base(entityFriendlyName, backupManagementType, operation, status, startOn, endOn, activityId, jobType)
        {
            Duration = duration;
            ActionsInfo = actionsInfo;
            MabServerName = mabServerName;
            MabServerType = mabServerType;
            WorkloadType = workloadType;
            ErrorDetails = errorDetails;
            ExtendedInfo = extendedInfo;
            JobType = jobType ?? "MabJob";
        }

        /// <summary> Time taken by job to run. </summary>
        public TimeSpan? Duration { get; set; }
        /// <summary> The state/actions applicable on jobs like cancel/retry. </summary>
        public IList<JobSupportedAction> ActionsInfo { get; }
        /// <summary> Name of server protecting the DS. </summary>
        public string MabServerName { get; set; }
        /// <summary> Server type of MAB container. </summary>
        public MabServerType? MabServerType { get; set; }
        /// <summary> Workload type of backup item. </summary>
        public BackupWorkloadType? WorkloadType { get; set; }
        /// <summary> The errors. </summary>
        public IList<MabErrorInfo> ErrorDetails { get; }
        /// <summary> Additional information on the job. </summary>
        public MabBackupJobExtendedInfo ExtendedInfo { get; set; }
    }
}
