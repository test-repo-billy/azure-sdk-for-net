// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A device job.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Job
    {
        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        public Job()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The name of the object.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="status">The current status of the job. Possible values
        /// include: 'Invalid', 'Running', 'Succeeded', 'Failed', 'Canceled',
        /// 'Paused', 'Scheduled'</param>
        /// <param name="startTime">The UTC date and time at which the job
        /// started.</param>
        /// <param name="endTime">The UTC date and time at which the job
        /// completed.</param>
        /// <param name="percentComplete">The percentage of the job that is
        /// complete.</param>
        /// <param name="error">The error details.</param>
        /// <param name="jobType">The type of the job. Possible values include:
        /// 'Invalid', 'ScanForUpdates', 'DownloadUpdates', 'InstallUpdates',
        /// 'RefreshShare'</param>
        /// <param name="currentStage">Current stage of the update operation.
        /// Possible values include: 'Unknown', 'Initial', 'ScanStarted',
        /// 'ScanComplete', 'ScanFailed', 'DownloadStarted',
        /// 'DownloadComplete', 'DownloadFailed', 'InstallStarted',
        /// 'InstallComplete', 'InstallFailed', 'RebootInitiated', 'Success',
        /// 'Failure', 'RescanStarted', 'RescanComplete',
        /// 'RescanFailed'</param>
        /// <param name="downloadProgress">The download progress.</param>
        /// <param name="installProgress">The install progress.</param>
        /// <param name="totalRefreshErrors">Total number of errors encountered
        /// during the refresh process.</param>
        /// <param name="errorManifestFile">Local share/remote container
        /// relative path to the error manifest file of the refresh.</param>
        /// <param name="shareId">ARM ID of the share that was
        /// refreshed.</param>
        /// <param name="folder">If only subfolders need to be refreshed, then
        /// the subfolder path inside the share. (The path is empty if there
        /// are no subfolders.)</param>
        public Job(string id = default(string), string name = default(string), string type = default(string), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), int? percentComplete = default(int?), JobErrorDetails error = default(JobErrorDetails), string jobType = default(string), string currentStage = default(string), UpdateDownloadProgress downloadProgress = default(UpdateDownloadProgress), UpdateInstallProgress installProgress = default(UpdateInstallProgress), int? totalRefreshErrors = default(int?), string errorManifestFile = default(string), string shareId = default(string), string folder = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            PercentComplete = percentComplete;
            Error = error;
            JobType = jobType;
            CurrentStage = currentStage;
            DownloadProgress = downloadProgress;
            InstallProgress = installProgress;
            TotalRefreshErrors = totalRefreshErrors;
            ErrorManifestFile = errorManifestFile;
            ShareId = shareId;
            Folder = folder;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the path ID that uniquely identifies the object.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the hierarchical type of the object.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the current status of the job. Possible values include:
        /// 'Invalid', 'Running', 'Succeeded', 'Failed', 'Canceled', 'Paused',
        /// 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the UTC date and time at which the job started.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the UTC date and time at which the job completed.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets the percentage of the job that is complete.
        /// </summary>
        [JsonProperty(PropertyName = "percentComplete")]
        public int? PercentComplete { get; private set; }

        /// <summary>
        /// Gets the error details.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public JobErrorDetails Error { get; private set; }

        /// <summary>
        /// Gets the type of the job. Possible values include: 'Invalid',
        /// 'ScanForUpdates', 'DownloadUpdates', 'InstallUpdates',
        /// 'RefreshShare'
        /// </summary>
        [JsonProperty(PropertyName = "properties.jobType")]
        public string JobType { get; private set; }

        /// <summary>
        /// Gets current stage of the update operation. Possible values
        /// include: 'Unknown', 'Initial', 'ScanStarted', 'ScanComplete',
        /// 'ScanFailed', 'DownloadStarted', 'DownloadComplete',
        /// 'DownloadFailed', 'InstallStarted', 'InstallComplete',
        /// 'InstallFailed', 'RebootInitiated', 'Success', 'Failure',
        /// 'RescanStarted', 'RescanComplete', 'RescanFailed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentStage")]
        public string CurrentStage { get; private set; }

        /// <summary>
        /// Gets the download progress.
        /// </summary>
        [JsonProperty(PropertyName = "properties.downloadProgress")]
        public UpdateDownloadProgress DownloadProgress { get; private set; }

        /// <summary>
        /// Gets the install progress.
        /// </summary>
        [JsonProperty(PropertyName = "properties.installProgress")]
        public UpdateInstallProgress InstallProgress { get; private set; }

        /// <summary>
        /// Gets total number of errors encountered during the refresh process.
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalRefreshErrors")]
        public int? TotalRefreshErrors { get; private set; }

        /// <summary>
        /// Gets local share/remote container relative path to the error
        /// manifest file of the refresh.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorManifestFile")]
        public string ErrorManifestFile { get; private set; }

        /// <summary>
        /// Gets ARM ID of the share that was refreshed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.shareId")]
        public string ShareId { get; private set; }

        /// <summary>
        /// Gets or sets if only subfolders need to be refreshed, then the
        /// subfolder path inside the share. (The path is empty if there are no
        /// subfolders.)
        /// </summary>
        [JsonProperty(PropertyName = "properties.folder")]
        public string Folder { get; set; }

    }
}
