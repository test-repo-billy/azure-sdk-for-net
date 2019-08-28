// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ApiReference
    {
        /// <summary>
        /// Initializes a new instance of the ApiReference class.
        /// </summary>
        public ApiReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiReference class.
        /// </summary>
        /// <param name="displayName">The display name of the api.</param>
        /// <param name="description">The description of the api.</param>
        /// <param name="iconUri">The icon uri of the api.</param>
        /// <param name="swagger">The swagger of the api.</param>
        /// <param name="brandColor">The brand color of the api.</param>
        /// <param name="category">The tier. Possible values include:
        /// 'NotSpecified', 'Enterprise', 'Standard', 'Premium'</param>
        /// <param name="integrationServiceEnvironment">The integration service
        /// environment reference.</param>
        public ApiReference(string displayName = default(string), string description = default(string), string iconUri = default(string), object swagger = default(object), string brandColor = default(string), string category = default(string), ResourceReference integrationServiceEnvironment = default(ResourceReference))
        {
            DisplayName = displayName;
            Description = description;
            IconUri = iconUri;
            Swagger = swagger;
            BrandColor = brandColor;
            Category = category;
            IntegrationServiceEnvironment = integrationServiceEnvironment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name of the api.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description of the api.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the icon uri of the api.
        /// </summary>
        [JsonProperty(PropertyName = "iconUri")]
        public string IconUri { get; set; }

        /// <summary>
        /// Gets or sets the swagger of the api.
        /// </summary>
        [JsonProperty(PropertyName = "swagger")]
        public object Swagger { get; set; }

        /// <summary>
        /// Gets or sets the brand color of the api.
        /// </summary>
        [JsonProperty(PropertyName = "brandColor")]
        public string BrandColor { get; set; }

        /// <summary>
        /// Gets or sets the tier. Possible values include: 'NotSpecified',
        /// 'Enterprise', 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the integration service environment reference.
        /// </summary>
        [JsonProperty(PropertyName = "integrationServiceEnvironment")]
        public ResourceReference IntegrationServiceEnvironment { get; set; }

    }
}
