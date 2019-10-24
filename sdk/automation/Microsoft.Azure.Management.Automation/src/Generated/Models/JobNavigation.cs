// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Software update configuration machine run job navigation properties.
    /// </summary>
    public partial class JobNavigation
    {
        /// <summary>
        /// Initializes a new instance of the JobNavigation class.
        /// </summary>
        public JobNavigation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobNavigation class.
        /// </summary>
        /// <param name="id">ID of the job associated with the software update
        /// configuration run.</param>
        public JobNavigation(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets ID of the job associated with the software update
        /// configuration run.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}
