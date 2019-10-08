// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CostManagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The details of the error.
    /// </summary>
    public partial class ErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the ErrorDetails class.
        /// </summary>
        public ErrorDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetails class.
        /// </summary>
        /// <param name="code">A machine readable error code.</param>
        /// <param name="message">A human readable error message.</param>
        /// <param name="target">Indicates which property in the request is
        /// responsible for the error.</param>
        /// <param name="details">error details.</param>
        public ErrorDetails(string code = default(string), string message = default(string), string target = default(string), IList<ErrorBase> details = default(IList<ErrorBase>))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a machine readable error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets a human readable error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets or sets indicates which property in the request is responsible
        /// for the error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets error details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ErrorBase> Details { get; set; }

    }
}
