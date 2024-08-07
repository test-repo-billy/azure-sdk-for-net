// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The details about the project represented by the security connector. </summary>
    public partial class GcpProjectDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GcpProjectDetails"/>. </summary>
        public GcpProjectDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GcpProjectDetails"/>. </summary>
        /// <param name="projectNumber"> The unique GCP Project number. </param>
        /// <param name="projectId"> The GCP Project id. </param>
        /// <param name="workloadIdentityPoolId"> The GCP workload identity federation pool id. </param>
        /// <param name="projectName"> GCP project name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GcpProjectDetails(string projectNumber, string projectId, string workloadIdentityPoolId, string projectName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProjectNumber = projectNumber;
            ProjectId = projectId;
            WorkloadIdentityPoolId = workloadIdentityPoolId;
            ProjectName = projectName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The unique GCP Project number. </summary>
        public string ProjectNumber { get; set; }
        /// <summary> The GCP Project id. </summary>
        public string ProjectId { get; set; }
        /// <summary> The GCP workload identity federation pool id. </summary>
        public string WorkloadIdentityPoolId { get; }
        /// <summary> GCP project name. </summary>
        public string ProjectName { get; }
    }
}
