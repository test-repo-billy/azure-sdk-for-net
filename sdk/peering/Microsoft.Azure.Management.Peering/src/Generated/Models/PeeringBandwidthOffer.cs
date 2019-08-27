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
    using System.Linq;

    /// <summary>
    /// The properties that define a peering bandwidth offer.
    /// </summary>
    public partial class PeeringBandwidthOffer
    {
        /// <summary>
        /// Initializes a new instance of the PeeringBandwidthOffer class.
        /// </summary>
        public PeeringBandwidthOffer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeeringBandwidthOffer class.
        /// </summary>
        /// <param name="offerName">The name of the bandwidth offer.</param>
        /// <param name="valueInMbps">The value of the bandwidth offer in
        /// Mbps.</param>
        public PeeringBandwidthOffer(string offerName = default(string), int? valueInMbps = default(int?))
        {
            OfferName = offerName;
            ValueInMbps = valueInMbps;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the bandwidth offer.
        /// </summary>
        [JsonProperty(PropertyName = "offerName")]
        public string OfferName { get; set; }

        /// <summary>
        /// Gets or sets the value of the bandwidth offer in Mbps.
        /// </summary>
        [JsonProperty(PropertyName = "valueInMbps")]
        public int? ValueInMbps { get; set; }

    }
}
