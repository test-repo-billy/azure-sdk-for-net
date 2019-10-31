// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Security assessment metadata
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SecurityAssessmentMetadata : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SecurityAssessmentMetadata class.
        /// </summary>
        public SecurityAssessmentMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityAssessmentMetadata class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="displayName">User friendly display name of the
        /// assessment</param>
        /// <param name="policyDefinitionId">Azure resource ID of the policy
        /// definition that turns this assessment calculation on</param>
        /// <param name="description">Human readable description of the
        /// assessment</param>
        /// <param name="remediationDescription">Human readable description of
        /// what you should do to mitigate this security issue</param>
        /// <param name="severity">The severity level of the assessment.
        /// Possible values include: 'Low', 'Medium', 'High'</param>
        /// <param name="preview">True if this assessment is in preview release
        /// status</param>
        /// <param name="assessmentType">BuiltIn if the assessment based on
        /// built-in Azure Policy definition, Custom if the assessment based on
        /// custom Azure Policy definition. Possible values include: 'BuiltIn',
        /// 'CustomPolicy', 'CustomerManaged'</param>
        public SecurityAssessmentMetadata(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), string policyDefinitionId = default(string), string description = default(string), string remediationDescription = default(string), IList<string> category = default(IList<string>), string severity = default(string), bool? preview = default(bool?), string assessmentType = default(string))
            : base(id, name, type)
        {
            DisplayName = displayName;
            PolicyDefinitionId = policyDefinitionId;
            Description = description;
            RemediationDescription = remediationDescription;
            Category = category;
            Severity = severity;
            Preview = preview;
            AssessmentType = assessmentType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets user friendly display name of the assessment
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets azure resource ID of the policy definition that turns this
        /// assessment calculation on
        /// </summary>
        [JsonProperty(PropertyName = "properties.policyDefinitionId")]
        public string PolicyDefinitionId { get; private set; }

        /// <summary>
        /// Gets human readable description of the assessment
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets human readable description of what you should do to mitigate
        /// this security issue
        /// </summary>
        [JsonProperty(PropertyName = "properties.remediationDescription")]
        public string RemediationDescription { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.category")]
        public IList<string> Category { get; private set; }

        /// <summary>
        /// Gets the severity level of the assessment. Possible values include:
        /// 'Low', 'Medium', 'High'
        /// </summary>
        [JsonProperty(PropertyName = "properties.severity")]
        public string Severity { get; private set; }

        /// <summary>
        /// Gets true if this assessment is in preview release status
        /// </summary>
        [JsonProperty(PropertyName = "properties.preview")]
        public bool? Preview { get; private set; }

        /// <summary>
        /// Gets builtIn if the assessment based on built-in Azure Policy
        /// definition, Custom if the assessment based on custom Azure Policy
        /// definition. Possible values include: 'BuiltIn', 'CustomPolicy',
        /// 'CustomerManaged'
        /// </summary>
        [JsonProperty(PropertyName = "properties.assessmentType")]
        public string AssessmentType { get; private set; }

    }
}
