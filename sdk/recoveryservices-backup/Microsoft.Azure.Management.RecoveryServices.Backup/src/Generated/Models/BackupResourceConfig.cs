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
    /// The resource storage details.
    /// </summary>
    public partial class BackupResourceConfig
    {
        /// <summary>
        /// Initializes a new instance of the BackupResourceConfig class.
        /// </summary>
        public BackupResourceConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupResourceConfig class.
        /// </summary>
        /// <param name="storageModelType">Storage type. Possible values
        /// include: 'Invalid', 'GeoRedundant', 'LocallyRedundant'</param>
        /// <param name="storageType">Storage type. Possible values include:
        /// 'Invalid', 'GeoRedundant', 'LocallyRedundant'</param>
        /// <param name="storageTypeState">Locked or Unlocked. Once a machine
        /// is registered against a resource, the storageTypeState is always
        /// Locked. Possible values include: 'Invalid', 'Locked',
        /// 'Unlocked'</param>
        /// <param name="crossRegionRestoreFlag">Opt in details of Cross Region
        /// Restore feature.</param>
        public BackupResourceConfig(string storageModelType = default(string), string storageType = default(string), string storageTypeState = default(string), bool? crossRegionRestoreFlag = default(bool?))
        {
            StorageModelType = storageModelType;
            StorageType = storageType;
            StorageTypeState = storageTypeState;
            CrossRegionRestoreFlag = crossRegionRestoreFlag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage type. Possible values include: 'Invalid',
        /// 'GeoRedundant', 'LocallyRedundant'
        /// </summary>
        [JsonProperty(PropertyName = "storageModelType")]
        public string StorageModelType { get; set; }

        /// <summary>
        /// Gets or sets storage type. Possible values include: 'Invalid',
        /// 'GeoRedundant', 'LocallyRedundant'
        /// </summary>
        [JsonProperty(PropertyName = "storageType")]
        public string StorageType { get; set; }

        /// <summary>
        /// Gets or sets locked or Unlocked. Once a machine is registered
        /// against a resource, the storageTypeState is always Locked. Possible
        /// values include: 'Invalid', 'Locked', 'Unlocked'
        /// </summary>
        [JsonProperty(PropertyName = "storageTypeState")]
        public string StorageTypeState { get; set; }

        /// <summary>
        /// Gets or sets opt in details of Cross Region Restore feature.
        /// </summary>
        [JsonProperty(PropertyName = "crossRegionRestoreFlag")]
        public bool? CrossRegionRestoreFlag { get; set; }

    }
}
