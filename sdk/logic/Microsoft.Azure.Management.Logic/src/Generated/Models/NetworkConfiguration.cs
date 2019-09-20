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
    /// The network configuration.
    /// </summary>
    public partial class NetworkConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the NetworkConfiguration class.
        /// </summary>
        public NetworkConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkConfiguration class.
        /// </summary>
        /// <param name="virtualNetworkAddressSpace">Gets the virtual network
        /// address space.</param>
        /// <param name="accessEndpoint">The access endpoint.</param>
        /// <param name="subnets">The subnets.</param>
        public NetworkConfiguration(string virtualNetworkAddressSpace = default(string), IntegrationServiceEnvironmentAccessEndpoint accessEndpoint = default(IntegrationServiceEnvironmentAccessEndpoint), IList<ResourceReference> subnets = default(IList<ResourceReference>))
        {
            VirtualNetworkAddressSpace = virtualNetworkAddressSpace;
            AccessEndpoint = accessEndpoint;
            Subnets = subnets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the virtual network address space.
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkAddressSpace")]
        public string VirtualNetworkAddressSpace { get; set; }

        /// <summary>
        /// Gets or sets the access endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "accessEndpoint")]
        public IntegrationServiceEnvironmentAccessEndpoint AccessEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the subnets.
        /// </summary>
        [JsonProperty(PropertyName = "subnets")]
        public IList<ResourceReference> Subnets { get; set; }

    }
}
