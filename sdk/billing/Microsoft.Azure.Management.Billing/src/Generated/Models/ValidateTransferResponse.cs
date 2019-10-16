// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Transfer validation response.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ValidateTransferResponse
    {
        /// <summary>
        /// Initializes a new instance of the ValidateTransferResponse class.
        /// </summary>
        public ValidateTransferResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidateTransferResponse class.
        /// </summary>
        /// <param name="status">The status of validation</param>
        /// <param name="productId">The product id for which this result
        /// applies.</param>
        /// <param name="results">Array of validation results.</param>
        public ValidateTransferResponse(string status = default(string), string productId = default(string), IList<ValidationResultProperties> results = default(IList<ValidationResultProperties>))
        {
            Status = status;
            ProductId = productId;
            Results = results;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the status of validation
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the product id for which this result applies.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productId")]
        public string ProductId { get; private set; }

        /// <summary>
        /// Gets or sets array of validation results.
        /// </summary>
        [JsonProperty(PropertyName = "properties.results")]
        public IList<ValidationResultProperties> Results { get; set; }

    }
}
