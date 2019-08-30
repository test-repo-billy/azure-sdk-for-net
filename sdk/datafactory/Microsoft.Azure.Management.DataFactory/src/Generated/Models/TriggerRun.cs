// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Trigger runs.
    /// </summary>
    public partial class TriggerRun
    {
        /// <summary>
        /// Initializes a new instance of the TriggerRun class.
        /// </summary>
        public TriggerRun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TriggerRun class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="triggerRunId">Trigger run id.</param>
        /// <param name="triggerName">Trigger name.</param>
        /// <param name="triggerType">Trigger type.</param>
        /// <param name="triggerRunTimestamp">Trigger run start time.</param>
        /// <param name="status">Trigger run status. Possible values include:
        /// 'Succeeded', 'Failed', 'Inprogress'</param>
        /// <param name="message">Trigger error message.</param>
        /// <param name="properties">List of property name and value related to
        /// trigger run. Name, value pair depends on type of trigger.</param>
        /// <param name="triggeredPipelines">List of pipeline name and run Id
        /// triggered by the trigger run.</param>
        /// <param name="runDimension">Run dimension for which trigger was
        /// fired.</param>
        /// <param name="dependencyStatus">Status of the upstream
        /// pipelines.</param>
        public TriggerRun(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string triggerRunId = default(string), string triggerName = default(string), string triggerType = default(string), System.DateTime? triggerRunTimestamp = default(System.DateTime?), string status = default(string), string message = default(string), IDictionary<string, string> properties = default(IDictionary<string, string>), IDictionary<string, string> triggeredPipelines = default(IDictionary<string, string>), IDictionary<string, string> runDimension = default(IDictionary<string, string>), IDictionary<string, object> dependencyStatus = default(IDictionary<string, object>))
        {
            AdditionalProperties = additionalProperties;
            TriggerRunId = triggerRunId;
            TriggerName = triggerName;
            TriggerType = triggerType;
            TriggerRunTimestamp = triggerRunTimestamp;
            Status = status;
            Message = message;
            Properties = properties;
            TriggeredPipelines = triggeredPipelines;
            RunDimension = runDimension;
            DependencyStatus = dependencyStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets trigger run id.
        /// </summary>
        [JsonProperty(PropertyName = "triggerRunId")]
        public string TriggerRunId { get; private set; }

        /// <summary>
        /// Gets trigger name.
        /// </summary>
        [JsonProperty(PropertyName = "triggerName")]
        public string TriggerName { get; private set; }

        /// <summary>
        /// Gets trigger type.
        /// </summary>
        [JsonProperty(PropertyName = "triggerType")]
        public string TriggerType { get; private set; }

        /// <summary>
        /// Gets trigger run start time.
        /// </summary>
        [JsonProperty(PropertyName = "triggerRunTimestamp")]
        public System.DateTime? TriggerRunTimestamp { get; private set; }

        /// <summary>
        /// Gets trigger run status. Possible values include: 'Succeeded',
        /// 'Failed', 'Inprogress'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets trigger error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets list of property name and value related to trigger run. Name,
        /// value pair depends on type of trigger.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; private set; }

        /// <summary>
        /// Gets list of pipeline name and run Id triggered by the trigger run.
        /// </summary>
        [JsonProperty(PropertyName = "triggeredPipelines")]
        public IDictionary<string, string> TriggeredPipelines { get; private set; }

        /// <summary>
        /// Gets run dimension for which trigger was fired.
        /// </summary>
        [JsonProperty(PropertyName = "runDimension")]
        public IDictionary<string, string> RunDimension { get; private set; }

        /// <summary>
        /// Gets status of the upstream pipelines.
        /// </summary>
        [JsonProperty(PropertyName = "dependencyStatus")]
        public IDictionary<string, object> DependencyStatus { get; private set; }

    }
}
