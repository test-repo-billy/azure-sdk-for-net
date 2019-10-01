// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties used to create a new server.
    /// </summary>
    public partial class ServerPropertiesForCreate
    {
        /// <summary>
        /// Initializes a new instance of the ServerPropertiesForCreate class.
        /// </summary>
        public ServerPropertiesForCreate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerPropertiesForCreate class.
        /// </summary>
        /// <param name="version">Server version. Possible values include:
        /// '9.5', '9.6', '10', '10.0', '10.2', '11'</param>
        /// <param name="sslEnforcement">Enable ssl enforcement or not when
        /// connect to server. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="storageProfile">Storage profile of a server.</param>
        public ServerPropertiesForCreate(string version = default(string), SslEnforcementEnum? sslEnforcement = default(SslEnforcementEnum?), StorageProfile storageProfile = default(StorageProfile))
        {
            Version = version;
            SslEnforcement = sslEnforcement;
            StorageProfile = storageProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets server version. Possible values include: '9.5', '9.6',
        /// '10', '10.0', '10.2', '11'
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets enable ssl enforcement or not when connect to server.
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "sslEnforcement")]
        public SslEnforcementEnum? SslEnforcement { get; set; }

        /// <summary>
        /// Gets or sets storage profile of a server.
        /// </summary>
        [JsonProperty(PropertyName = "storageProfile")]
        public StorageProfile StorageProfile { get; set; }

    }
}
