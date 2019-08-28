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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The swagger schema.
    /// </summary>
    public partial class SwaggerSchema
    {
        /// <summary>
        /// Initializes a new instance of the SwaggerSchema class.
        /// </summary>
        public SwaggerSchema()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SwaggerSchema class.
        /// </summary>
        /// <param name="refProperty">The reference.</param>
        /// <param name="type">The type. Possible values include: 'String',
        /// 'Number', 'Integer', 'Boolean', 'Array', 'File', 'Object',
        /// 'Null'</param>
        /// <param name="title">The title.</param>
        /// <param name="items">The items schema.</param>
        /// <param name="properties">The object properties</param>
        /// <param name="additionalProperties">The additional
        /// properties.</param>
        /// <param name="required">The object required properties.</param>
        /// <param name="maxProperties">The maximum number of allowed
        /// properties.</param>
        /// <param name="minProperties">The minimum number of allowed
        /// properties.</param>
        /// <param name="allOf">The schemas which must pass validation when
        /// this schema is used.</param>
        /// <param name="discriminator">The discriminator.</param>
        /// <param name="readOnlyProperty">Gets or sets whether this property
        /// must be present in the a request.</param>
        /// <param name="xml">The xml representation format for a
        /// property.</param>
        /// <param name="externalDocs">The external documentation.</param>
        /// <param name="example">The example value.</param>
        /// <param name="notificationUrlExtension">Gets or sets the
        /// notification url extension. If this is set, the property's value
        /// should be a callback url for a webhook.</param>
        /// <param name="dynamicSchemaOld">The dynamic schema
        /// configuration.</param>
        /// <param name="dynamicSchemaNew">The dynamic schema
        /// configuration.</param>
        /// <param name="dynamicListNew">The dynamic list.</param>
        /// <param name="dynamicTree">The dynamic values tree
        /// configuration.</param>
        public SwaggerSchema(string refProperty = default(string), string type = default(string), string title = default(string), SwaggerSchema items = default(SwaggerSchema), IDictionary<string, SwaggerSchema> properties = default(IDictionary<string, SwaggerSchema>), object additionalProperties = default(object), IList<string> required = default(IList<string>), int? maxProperties = default(int?), int? minProperties = default(int?), IList<SwaggerSchema> allOf = default(IList<SwaggerSchema>), string discriminator = default(string), bool? readOnlyProperty = default(bool?), SwaggerXml xml = default(SwaggerXml), SwaggerExternalDocumentation externalDocs = default(SwaggerExternalDocumentation), object example = default(object), bool? notificationUrlExtension = default(bool?), SwaggerCustomDynamicSchema dynamicSchemaOld = default(SwaggerCustomDynamicSchema), SwaggerCustomDynamicProperties dynamicSchemaNew = default(SwaggerCustomDynamicProperties), SwaggerCustomDynamicList dynamicListNew = default(SwaggerCustomDynamicList), SwaggerCustomDynamicTree dynamicTree = default(SwaggerCustomDynamicTree))
        {
            RefProperty = refProperty;
            Type = type;
            Title = title;
            Items = items;
            Properties = properties;
            AdditionalProperties = additionalProperties;
            Required = required;
            MaxProperties = maxProperties;
            MinProperties = minProperties;
            AllOf = allOf;
            Discriminator = discriminator;
            ReadOnlyProperty = readOnlyProperty;
            Xml = xml;
            ExternalDocs = externalDocs;
            Example = example;
            NotificationUrlExtension = notificationUrlExtension;
            DynamicSchemaOld = dynamicSchemaOld;
            DynamicSchemaNew = dynamicSchemaNew;
            DynamicListNew = dynamicListNew;
            DynamicTree = dynamicTree;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        [JsonProperty(PropertyName = "ref")]
        public string RefProperty { get; set; }

        /// <summary>
        /// Gets or sets the type. Possible values include: 'String', 'Number',
        /// 'Integer', 'Boolean', 'Array', 'File', 'Object', 'Null'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the items schema.
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public SwaggerSchema Items { get; set; }

        /// <summary>
        /// Gets or sets the object properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, SwaggerSchema> Properties { get; set; }

        /// <summary>
        /// Gets or sets the additional properties.
        /// </summary>
        [JsonProperty(PropertyName = "additionalProperties")]
        public object AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets the object required properties.
        /// </summary>
        [JsonProperty(PropertyName = "required")]
        public IList<string> Required { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of allowed properties.
        /// </summary>
        [JsonProperty(PropertyName = "maxProperties")]
        public int? MaxProperties { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of allowed properties.
        /// </summary>
        [JsonProperty(PropertyName = "minProperties")]
        public int? MinProperties { get; set; }

        /// <summary>
        /// Gets or sets the schemas which must pass validation when this
        /// schema is used.
        /// </summary>
        [JsonProperty(PropertyName = "allOf")]
        public IList<SwaggerSchema> AllOf { get; set; }

        /// <summary>
        /// Gets or sets the discriminator.
        /// </summary>
        [JsonProperty(PropertyName = "discriminator")]
        public string Discriminator { get; set; }

        /// <summary>
        /// Gets or sets whether this property must be present in the a
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets the xml representation format for a property.
        /// </summary>
        [JsonProperty(PropertyName = "xml")]
        public SwaggerXml Xml { get; set; }

        /// <summary>
        /// Gets or sets the external documentation.
        /// </summary>
        [JsonProperty(PropertyName = "externalDocs")]
        public SwaggerExternalDocumentation ExternalDocs { get; set; }

        /// <summary>
        /// Gets or sets the example value.
        /// </summary>
        [JsonProperty(PropertyName = "example")]
        public object Example { get; set; }

        /// <summary>
        /// Gets or sets the notification url extension. If this is set, the
        /// property's value should be a callback url for a webhook.
        /// </summary>
        [JsonProperty(PropertyName = "notificationUrlExtension")]
        public bool? NotificationUrlExtension { get; set; }

        /// <summary>
        /// Gets or sets the dynamic schema configuration.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicSchemaOld")]
        public SwaggerCustomDynamicSchema DynamicSchemaOld { get; set; }

        /// <summary>
        /// Gets or sets the dynamic schema configuration.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicSchemaNew")]
        public SwaggerCustomDynamicProperties DynamicSchemaNew { get; set; }

        /// <summary>
        /// Gets or sets the dynamic list.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicListNew")]
        public SwaggerCustomDynamicList DynamicListNew { get; set; }

        /// <summary>
        /// Gets or sets the dynamic values tree configuration.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicTree")]
        public SwaggerCustomDynamicTree DynamicTree { get; set; }

    }
}
