// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A private link resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateLinkResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkResource class.
        /// </summary>
        public PrivateLinkResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkResource class.
        /// </summary>
        /// <param name="location">The supported Azure location where the key
        /// vault should be created.</param>
        /// <param name="id">The Azure Resource Manager resource ID for the key
        /// vault.</param>
        /// <param name="name">The name of the key vault.</param>
        /// <param name="type">The resource type of the key vault.</param>
        /// <param name="tags">The tags that will be assigned to the key vault.
        /// </param>
        /// <param name="groupId">The private link resource group id.</param>
        /// <param name="requiredMembers">The private link resource required
        /// member names.</param>
        /// <param name="requiredZoneNames">The private link resource DNS zone
        /// names.</param>
        public PrivateLinkResource(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string groupId = default(string), IList<string> requiredMembers = default(IList<string>), IList<string> requiredZoneNames = default(IList<string>))
            : base(location, id, name, type, tags)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the private link resource group id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupId")]
        public string GroupId { get; private set; }

        /// <summary>
        /// Gets the private link resource required member names.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiredMembers")]
        public IList<string> RequiredMembers { get; private set; }

        /// <summary>
        /// Gets or sets the private link resource DNS zone names.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiredZoneNames")]
        public IList<string> RequiredZoneNames { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
