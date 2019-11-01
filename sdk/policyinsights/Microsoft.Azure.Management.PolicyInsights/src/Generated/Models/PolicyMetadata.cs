// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PolicyInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Policy metadata resource definition.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PolicyMetadata
    {
        /// <summary>
        /// Initializes a new instance of the PolicyMetadata class.
        /// </summary>
        public PolicyMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyMetadata class.
        /// </summary>
        /// <param name="metadataId">The policy metadata identifier.</param>
        /// <param name="category">The category of the policy metadata.</param>
        /// <param name="title">The title of the policy metadata.</param>
        /// <param name="owner">The owner of the policy metadata.</param>
        /// <param name="description">The description of the policy
        /// metadata.</param>
        /// <param name="requirements">The requirements of the policy
        /// metadata.</param>
        /// <param name="additionalContentUrl">Url for getting additional
        /// content about the resource metadata.</param>
        /// <param name="metadata">Additional metadata.</param>
        /// <param name="id">The ID of the policy metadata.</param>
        /// <param name="type">The type of the policy metadata.</param>
        /// <param name="name">The name of the policy metadata.</param>
        public PolicyMetadata(string metadataId = default(string), string category = default(string), string title = default(string), string owner = default(string), string description = default(string), string requirements = default(string), string additionalContentUrl = default(string), object metadata = default(object), string id = default(string), string type = default(string), string name = default(string))
        {
            MetadataId = metadataId;
            Category = category;
            Title = title;
            Owner = owner;
            Description = description;
            Requirements = requirements;
            AdditionalContentUrl = additionalContentUrl;
            Metadata = metadata;
            Id = id;
            Type = type;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the policy metadata identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadataId")]
        public string MetadataId { get; private set; }

        /// <summary>
        /// Gets the category of the policy metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.category")]
        public string Category { get; private set; }

        /// <summary>
        /// Gets the title of the policy metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.title")]
        public string Title { get; private set; }

        /// <summary>
        /// Gets the owner of the policy metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.owner")]
        public string Owner { get; private set; }

        /// <summary>
        /// Gets the description of the policy metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the requirements of the policy metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requirements")]
        public string Requirements { get; private set; }

        /// <summary>
        /// Gets url for getting additional content about the resource
        /// metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalContentUrl")]
        public string AdditionalContentUrl { get; private set; }

        /// <summary>
        /// Gets additional metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public object Metadata { get; private set; }

        /// <summary>
        /// Gets the ID of the policy metadata.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the type of the policy metadata.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the name of the policy metadata.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

    }
}
