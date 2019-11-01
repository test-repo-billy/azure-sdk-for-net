// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AzureSku
    {
        /// <summary>
        /// Initializes a new instance of the AzureSku class.
        /// </summary>
        public AzureSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Static constructor for AzureSku class.
        /// </summary>
        static AzureSku()
        {
            Name = "S1";
            Tier = "Standard";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// SKU name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public static string Name { get; private set; }

        /// <summary>
        /// SKU tier
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public static string Tier { get; private set; }

    }
}
