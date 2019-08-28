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

    public partial class IpAddress
    {
        /// <summary>
        /// Initializes a new instance of the IpAddress class.
        /// </summary>
        public IpAddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IpAddress class.
        /// </summary>
        /// <param name="address">The address.</param>
        public IpAddress(string address = default(string))
        {
            Address = address;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

    }
}
