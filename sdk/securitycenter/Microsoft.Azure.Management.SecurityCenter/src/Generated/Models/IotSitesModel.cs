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
    /// IoT site model
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IotSitesModel : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IotSitesModel class.
        /// </summary>
        public IotSitesModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotSitesModel class.
        /// </summary>
        /// <param name="displayName">Display name of the IoT site</param>
        /// <param name="tags">Tags of the IoT site</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        public IotSitesModel(string displayName, IDictionary<string, string> tags, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            DisplayName = displayName;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets display name of the IoT site
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets tags of the IoT site
        /// </summary>
        [JsonProperty(PropertyName = "properties.tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Tags == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tags");
            }
        }
    }
}
