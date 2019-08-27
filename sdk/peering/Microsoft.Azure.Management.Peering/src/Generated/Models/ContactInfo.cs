// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The contact information of the peer.
    /// </summary>
    public partial class ContactInfo
    {
        /// <summary>
        /// Initializes a new instance of the ContactInfo class.
        /// </summary>
        public ContactInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContactInfo class.
        /// </summary>
        /// <param name="emails">The list of email addresses.</param>
        /// <param name="phone">The list of contact numbers.</param>
        public ContactInfo(IList<string> emails = default(IList<string>), IList<string> phone = default(IList<string>))
        {
            Emails = emails;
            Phone = phone;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of email addresses.
        /// </summary>
        [JsonProperty(PropertyName = "emails")]
        public IList<string> Emails { get; set; }

        /// <summary>
        /// Gets or sets the list of contact numbers.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public IList<string> Phone { get; set; }

    }
}
