// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// MAB workload-specific backup item.
    /// </summary>
    public partial class MabFileFolderProtectedItem : ProtectedItem
    {
        /// <summary>
        /// Initializes a new instance of the MabFileFolderProtectedItem class.
        /// </summary>
        public MabFileFolderProtectedItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MabFileFolderProtectedItem class.
        /// </summary>
        /// <param name="backupManagementType">Type of backup management for
        /// the backed up item. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql',
        /// 'AzureStorage', 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="workloadType">Type of workload this item represents.
        /// Possible values include: 'Invalid', 'VM', 'FileFolder',
        /// 'AzureSqlDb', 'SQLDB', 'Exchange', 'Sharepoint', 'VMwareVM',
        /// 'SystemState', 'Client', 'GenericDataSource', 'SQLDataBase',
        /// 'AzureFileShare', 'SAPHanaDatabase', 'SAPAseDatabase'</param>
        /// <param name="containerName">Unique name of container</param>
        /// <param name="sourceResourceId">ARM ID of the resource to be backed
        /// up.</param>
        /// <param name="policyId">ID of the backup policy with which this item
        /// is backed up.</param>
        /// <param name="lastRecoveryPoint">Timestamp when the last (latest)
        /// backup copy was created for this backup item.</param>
        /// <param name="backupSetName">Name of the backup set the backup item
        /// belongs to</param>
        /// <param name="createMode">Create mode to indicate recovery of
        /// existing soft deleted data source or creation of new data source.
        /// Possible values include: 'Invalid', 'Default', 'Recover'</param>
        /// <param name="deferredDeleteTimeInUTC">Time for deferred deletion in
        /// UTC</param>
        /// <param name="isScheduledForDeferredDelete">Flag to identify whether
        /// the DS is scheduled for deferred delete</param>
        /// <param name="deferredDeleteTimeRemaining">Time remaining before the
        /// DS marked for deferred delete is permanently deleted</param>
        /// <param name="isDeferredDeleteScheduleUpcoming">Flag to identify
        /// whether the deferred deleted DS is to be purged soon</param>
        /// <param name="isRehydrate">Flag to identify that deferred deleted DS
        /// is to be moved into Pause state</param>
        /// <param name="friendlyName">Friendly name of this backup
        /// item.</param>
        /// <param name="computerName">Name of the computer associated with
        /// this backup item.</param>
        /// <param name="lastBackupStatus">Status of last backup
        /// operation.</param>
        /// <param name="lastBackupTime">Timestamp of the last backup operation
        /// on this backup item.</param>
        /// <param name="protectionState">Protected, ProtectionStopped,
        /// IRPending or ProtectionError</param>
        /// <param name="deferredDeleteSyncTimeInUTC">Sync time for deferred
        /// deletion in UTC</param>
        /// <param name="extendedInfo">Additional information with this backup
        /// item.</param>
        public MabFileFolderProtectedItem(string backupManagementType = default(string), string workloadType = default(string), string containerName = default(string), string sourceResourceId = default(string), string policyId = default(string), System.DateTime? lastRecoveryPoint = default(System.DateTime?), string backupSetName = default(string), string createMode = default(string), System.DateTime? deferredDeleteTimeInUTC = default(System.DateTime?), bool? isScheduledForDeferredDelete = default(bool?), string deferredDeleteTimeRemaining = default(string), bool? isDeferredDeleteScheduleUpcoming = default(bool?), bool? isRehydrate = default(bool?), string friendlyName = default(string), string computerName = default(string), string lastBackupStatus = default(string), System.DateTime? lastBackupTime = default(System.DateTime?), string protectionState = default(string), long? deferredDeleteSyncTimeInUTC = default(long?), MabFileFolderProtectedItemExtendedInfo extendedInfo = default(MabFileFolderProtectedItemExtendedInfo))
            : base(backupManagementType, workloadType, containerName, sourceResourceId, policyId, lastRecoveryPoint, backupSetName, createMode, deferredDeleteTimeInUTC, isScheduledForDeferredDelete, deferredDeleteTimeRemaining, isDeferredDeleteScheduleUpcoming, isRehydrate)
        {
            FriendlyName = friendlyName;
            ComputerName = computerName;
            LastBackupStatus = lastBackupStatus;
            LastBackupTime = lastBackupTime;
            ProtectionState = protectionState;
            DeferredDeleteSyncTimeInUTC = deferredDeleteSyncTimeInUTC;
            ExtendedInfo = extendedInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets friendly name of this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets name of the computer associated with this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "computerName")]
        public string ComputerName { get; set; }

        /// <summary>
        /// Gets or sets status of last backup operation.
        /// </summary>
        [JsonProperty(PropertyName = "lastBackupStatus")]
        public string LastBackupStatus { get; set; }

        /// <summary>
        /// Gets or sets timestamp of the last backup operation on this backup
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "lastBackupTime")]
        public System.DateTime? LastBackupTime { get; set; }

        /// <summary>
        /// Gets or sets protected, ProtectionStopped, IRPending or
        /// ProtectionError
        /// </summary>
        [JsonProperty(PropertyName = "protectionState")]
        public string ProtectionState { get; set; }

        /// <summary>
        /// Gets or sets sync time for deferred deletion in UTC
        /// </summary>
        [JsonProperty(PropertyName = "deferredDeleteSyncTimeInUTC")]
        public long? DeferredDeleteSyncTimeInUTC { get; set; }

        /// <summary>
        /// Gets or sets additional information with this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "extendedInfo")]
        public MabFileFolderProtectedItemExtendedInfo ExtendedInfo { get; set; }

    }
}
