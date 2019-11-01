// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearning.Workspaces.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An object that represents a machine learning workspace.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Workspace : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Workspace class.
        /// </summary>
        public Workspace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Workspace class.
        /// </summary>
        /// <param name="location">The location of the resource. This cannot be
        /// changed after the resource is created.</param>
        /// <param name="userStorageAccountId">The fully qualified arm id of
        /// the storage account associated with this workspace.</param>
        /// <param name="ownerEmail">The email id of the owner for this
        /// workspace.</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="workspaceType">The type of this workspace. Possible
        /// values include: 'Production', 'Free', 'Anonymous', 'PaidStandard',
        /// 'PaidPremium'</param>
        /// <param name="workspaceState">The current state of workspace
        /// resource. Possible values include: 'Deleted', 'Enabled',
        /// 'Disabled', 'Migrated', 'Updated', 'Registered',
        /// 'Unregistered'</param>
        /// <param name="workspaceId">The immutable id associated with this
        /// workspace.</param>
        /// <param name="creationTime">The creation time for this workspace
        /// resource.</param>
        /// <param name="studioEndpoint">The regional endpoint for the machine
        /// learning studio service which hosts this workspace.</param>
        /// <param name="keyVaultIdentifierId">The key vault identifier used
        /// for encrypted workspaces.</param>
        public Workspace(string location, string userStorageAccountId, string ownerEmail, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), WorkspaceType? workspaceType = default(WorkspaceType?), WorkspaceState? workspaceState = default(WorkspaceState?), string workspaceId = default(string), string creationTime = default(string), string studioEndpoint = default(string), string keyVaultIdentifierId = default(string))
            : base(location, id, name, type, tags)
        {
            UserStorageAccountId = userStorageAccountId;
            OwnerEmail = ownerEmail;
            WorkspaceType = workspaceType;
            WorkspaceState = workspaceState;
            WorkspaceId = workspaceId;
            CreationTime = creationTime;
            StudioEndpoint = studioEndpoint;
            KeyVaultIdentifierId = keyVaultIdentifierId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fully qualified arm id of the storage account
        /// associated with this workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userStorageAccountId")]
        public string UserStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the email id of the owner for this workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ownerEmail")]
        public string OwnerEmail { get; set; }

        /// <summary>
        /// Gets the type of this workspace. Possible values include:
        /// 'Production', 'Free', 'Anonymous', 'PaidStandard', 'PaidPremium'
        /// </summary>
        [JsonProperty(PropertyName = "properties.workspaceType")]
        public WorkspaceType? WorkspaceType { get; private set; }

        /// <summary>
        /// Gets the current state of workspace resource. Possible values
        /// include: 'Deleted', 'Enabled', 'Disabled', 'Migrated', 'Updated',
        /// 'Registered', 'Unregistered'
        /// </summary>
        [JsonProperty(PropertyName = "properties.workspaceState")]
        public WorkspaceState? WorkspaceState { get; private set; }

        /// <summary>
        /// Gets the immutable id associated with this workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.workspaceId")]
        public string WorkspaceId { get; private set; }

        /// <summary>
        /// Gets the creation time for this workspace resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public string CreationTime { get; private set; }

        /// <summary>
        /// Gets the regional endpoint for the machine learning studio service
        /// which hosts this workspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.studioEndpoint")]
        public string StudioEndpoint { get; private set; }

        /// <summary>
        /// Gets or sets the key vault identifier used for encrypted
        /// workspaces.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultIdentifierId")]
        public string KeyVaultIdentifierId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (UserStorageAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserStorageAccountId");
            }
            if (OwnerEmail == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OwnerEmail");
            }
        }
    }
}
