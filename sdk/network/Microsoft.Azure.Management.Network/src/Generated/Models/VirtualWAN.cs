// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VirtualWAN Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualWAN : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualWAN class.
        /// </summary>
        public VirtualWAN()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualWAN class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="disableVpnEncryption">Vpn encryption to be disabled or
        /// not.</param>
        /// <param name="virtualHubs">List of VirtualHubs in the
        /// VirtualWAN.</param>
        /// <param name="vpnSites">List of VpnSites in the VirtualWAN.</param>
        /// <param name="securityProviderName">The Security Provider
        /// name.</param>
        /// <param name="allowBranchToBranchTraffic">True if branch to branch
        /// traffic is allowed.</param>
        /// <param name="allowVnetToVnetTraffic">True if Vnet to Vnet traffic
        /// is allowed.</param>
        /// <param name="office365LocalBreakoutCategory">The office local
        /// breakout category. Possible values include: 'Optimize',
        /// 'OptimizeAndAllow', 'All', 'None'</param>
        /// <param name="p2SVpnServerConfigurations">List of all
        /// P2SVpnServerConfigurations associated with the virtual wan.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// virtual WAN resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public VirtualWAN(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), bool? disableVpnEncryption = default(bool?), IList<SubResource> virtualHubs = default(IList<SubResource>), IList<SubResource> vpnSites = default(IList<SubResource>), string securityProviderName = default(string), bool? allowBranchToBranchTraffic = default(bool?), bool? allowVnetToVnetTraffic = default(bool?), string office365LocalBreakoutCategory = default(string), IList<P2SVpnServerConfiguration> p2SVpnServerConfigurations = default(IList<P2SVpnServerConfiguration>), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            DisableVpnEncryption = disableVpnEncryption;
            VirtualHubs = virtualHubs;
            VpnSites = vpnSites;
            SecurityProviderName = securityProviderName;
            AllowBranchToBranchTraffic = allowBranchToBranchTraffic;
            AllowVnetToVnetTraffic = allowVnetToVnetTraffic;
            Office365LocalBreakoutCategory = office365LocalBreakoutCategory;
            P2SVpnServerConfigurations = p2SVpnServerConfigurations;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets vpn encryption to be disabled or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableVpnEncryption")]
        public bool? DisableVpnEncryption { get; set; }

        /// <summary>
        /// Gets list of VirtualHubs in the VirtualWAN.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualHubs")]
        public IList<SubResource> VirtualHubs { get; private set; }

        /// <summary>
        /// Gets list of VpnSites in the VirtualWAN.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnSites")]
        public IList<SubResource> VpnSites { get; private set; }

        /// <summary>
        /// Gets or sets the Security Provider name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.securityProviderName")]
        public string SecurityProviderName { get; set; }

        /// <summary>
        /// Gets or sets true if branch to branch traffic is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowBranchToBranchTraffic")]
        public bool? AllowBranchToBranchTraffic { get; set; }

        /// <summary>
        /// Gets or sets true if Vnet to Vnet traffic is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowVnetToVnetTraffic")]
        public bool? AllowVnetToVnetTraffic { get; set; }

        /// <summary>
        /// Gets or sets the office local breakout category. Possible values
        /// include: 'Optimize', 'OptimizeAndAllow', 'All', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "properties.office365LocalBreakoutCategory")]
        public string Office365LocalBreakoutCategory { get; set; }

        /// <summary>
        /// Gets or sets list of all P2SVpnServerConfigurations associated with
        /// the virtual wan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.p2SVpnServerConfigurations")]
        public IList<P2SVpnServerConfiguration> P2SVpnServerConfigurations { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the virtual WAN resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
