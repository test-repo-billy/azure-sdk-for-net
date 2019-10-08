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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AzureWorkload SQL -specific restore. Specifically for full/diff restore
    /// </summary>
    public partial class AzureWorkloadSQLRestoreRequest : AzureWorkloadRestoreRequest
    {
        /// <summary>
        /// Initializes a new instance of the AzureWorkloadSQLRestoreRequest
        /// class.
        /// </summary>
        public AzureWorkloadSQLRestoreRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureWorkloadSQLRestoreRequest
        /// class.
        /// </summary>
        /// <param name="recoveryType">OLR/ALR, RestoreDisks is invalid option.
        /// Possible values include: 'Invalid', 'OriginalLocation',
        /// 'AlternateLocation', 'RestoreDisks'</param>
        /// <param name="sourceResourceId">Fully qualified ARM ID of the VM on
        /// which workload that was running is being recovered.</param>
        /// <param name="propertyBag">Workload specific property bag.</param>
        /// <param name="targetInfo">Details of target database</param>
        /// <param name="shouldUseAlternateTargetLocation">Default option set
        /// to true. If this is set to false, alternate data directory must be
        /// provided</param>
        /// <param name="isNonRecoverable">SQL specific property where user can
        /// chose to set no-recovery when restore operation is tried</param>
        /// <param name="alternateDirectoryPaths">Data directory
        /// details</param>
        public AzureWorkloadSQLRestoreRequest(string recoveryType = default(string), string sourceResourceId = default(string), IDictionary<string, string> propertyBag = default(IDictionary<string, string>), TargetRestoreInfo targetInfo = default(TargetRestoreInfo), bool? shouldUseAlternateTargetLocation = default(bool?), bool? isNonRecoverable = default(bool?), IList<SQLDataDirectoryMapping> alternateDirectoryPaths = default(IList<SQLDataDirectoryMapping>))
            : base(recoveryType, sourceResourceId, propertyBag, targetInfo)
        {
            ShouldUseAlternateTargetLocation = shouldUseAlternateTargetLocation;
            IsNonRecoverable = isNonRecoverable;
            AlternateDirectoryPaths = alternateDirectoryPaths;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets default option set to true. If this is set to false,
        /// alternate data directory must be provided
        /// </summary>
        [JsonProperty(PropertyName = "shouldUseAlternateTargetLocation")]
        public bool? ShouldUseAlternateTargetLocation { get; set; }

        /// <summary>
        /// Gets or sets SQL specific property where user can chose to set
        /// no-recovery when restore operation is tried
        /// </summary>
        [JsonProperty(PropertyName = "isNonRecoverable")]
        public bool? IsNonRecoverable { get; set; }

        /// <summary>
        /// Gets or sets data directory details
        /// </summary>
        [JsonProperty(PropertyName = "alternateDirectoryPaths")]
        public IList<SQLDataDirectoryMapping> AlternateDirectoryPaths { get; set; }

    }
}
