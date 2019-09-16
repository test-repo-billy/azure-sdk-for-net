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
    /// Details of the transfer.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RecipientTransferDetails
    {
        /// <summary>
        /// Initializes a new instance of the RecipientTransferDetails class.
        /// </summary>
        public RecipientTransferDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecipientTransferDetails class.
        /// </summary>
        /// <param name="creationTime">Transfer creation time.</param>
        /// <param name="expirationTime">Transfer expiration time.</param>
        /// <param name="allowedProductType">Type of subscriptions that can be
        /// transferred.</param>
        /// <param name="transferStatus">Overall transfer status. Possible
        /// values include: 'Pending', 'InProgress', 'Completed',
        /// 'CompletedWithErrors', 'Failed', 'Canceled', 'Declined'</param>
        /// <param name="recipientEmailId">Email Id of recipient of
        /// transfer.</param>
        /// <param name="initiatorEmailId">Email Id of initiator of
        /// transfer.</param>
        /// <param name="resellerId">Reseller Id for transfer.</param>
        /// <param name="resellerName">Reseller name for transfer.</param>
        /// <param name="initiatorCustomerType">Customer type of the
        /// initiator.</param>
        /// <param name="canceledBy">Email Id who user canceled the
        /// transfer.</param>
        /// <param name="lastModifiedTime">Transfer last modification
        /// time.</param>
        /// <param name="detailedTransferStatus">Detailed transfer
        /// status.</param>
        public RecipientTransferDetails(System.DateTime? creationTime = default(System.DateTime?), System.DateTime? expirationTime = default(System.DateTime?), IList<string> allowedProductType = default(IList<string>), string transferStatus = default(string), string recipientEmailId = default(string), string initiatorEmailId = default(string), string resellerId = default(string), string resellerName = default(string), string initiatorCustomerType = default(string), string canceledBy = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?), IList<DetailedTransferStatus> detailedTransferStatus = default(IList<DetailedTransferStatus>))
        {
            CreationTime = creationTime;
            ExpirationTime = expirationTime;
            AllowedProductType = allowedProductType;
            TransferStatus = transferStatus;
            RecipientEmailId = recipientEmailId;
            InitiatorEmailId = initiatorEmailId;
            ResellerId = resellerId;
            ResellerName = resellerName;
            InitiatorCustomerType = initiatorCustomerType;
            CanceledBy = canceledBy;
            LastModifiedTime = lastModifiedTime;
            DetailedTransferStatus = detailedTransferStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets transfer creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets transfer expiration time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationTime")]
        public System.DateTime? ExpirationTime { get; private set; }

        /// <summary>
        /// Gets type of subscriptions that can be transferred.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedProductType")]
        public IList<string> AllowedProductType { get; private set; }

        /// <summary>
        /// Gets overall transfer status. Possible values include: 'Pending',
        /// 'InProgress', 'Completed', 'CompletedWithErrors', 'Failed',
        /// 'Canceled', 'Declined'
        /// </summary>
        [JsonProperty(PropertyName = "properties.transferStatus")]
        public string TransferStatus { get; private set; }

        /// <summary>
        /// Gets email Id of recipient of transfer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recipientEmailId")]
        public string RecipientEmailId { get; private set; }

        /// <summary>
        /// Gets email Id of initiator of transfer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.initiatorEmailId")]
        public string InitiatorEmailId { get; private set; }

        /// <summary>
        /// Gets reseller Id for transfer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resellerId")]
        public string ResellerId { get; private set; }

        /// <summary>
        /// Gets reseller name for transfer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resellerName")]
        public string ResellerName { get; private set; }

        /// <summary>
        /// Gets customer type of the initiator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.initiatorCustomerType")]
        public string InitiatorCustomerType { get; private set; }

        /// <summary>
        /// Gets email Id who user canceled the transfer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.canceledBy")]
        public string CanceledBy { get; private set; }

        /// <summary>
        /// Gets transfer last modification time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets detailed transfer status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.detailedTransferStatus")]
        public IList<DetailedTransferStatus> DetailedTransferStatus { get; private set; }

    }
}
