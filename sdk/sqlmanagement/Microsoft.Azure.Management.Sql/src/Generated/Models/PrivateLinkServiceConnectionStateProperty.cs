// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PrivateLinkServiceConnectionStateProperty
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PrivateLinkServiceConnectionStateProperty class.
        /// </summary>
        public PrivateLinkServiceConnectionStateProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PrivateLinkServiceConnectionStateProperty class.
        /// </summary>
        /// <param name="status">The private link service connection
        /// status.</param>
        /// <param name="description">The private link service connection
        /// description.</param>
        /// <param name="actionsRequired">The actions required for private link
        /// service connection.</param>
        public PrivateLinkServiceConnectionStateProperty(string status, string description, string actionsRequired = default(string))
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the private link service connection status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the private link service connection description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the actions required for private link service connection.
        /// </summary>
        [JsonProperty(PropertyName = "actionsRequired")]
        public string ActionsRequired { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (Description == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Description");
            }
        }
    }
}
