// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a list of VM/server groups and set of rules that are
    /// Recommended by Azure Security Center to be allowed
    /// </summary>
    public partial class AppWhitelistingGroups
    {
        /// <summary>
        /// Initializes a new instance of the AppWhitelistingGroups class.
        /// </summary>
        public AppWhitelistingGroups()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppWhitelistingGroups class.
        /// </summary>
        public AppWhitelistingGroups(IList<AppWhitelistingGroup> value = default(IList<AppWhitelistingGroup>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<AppWhitelistingGroup> Value { get; set; }

    }
}
