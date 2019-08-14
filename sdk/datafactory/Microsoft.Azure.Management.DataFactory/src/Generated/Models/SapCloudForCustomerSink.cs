// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity SAP Cloud for Customer sink.
    /// </summary>
    public partial class SapCloudForCustomerSink : CopySink
    {
        /// <summary>
        /// Initializes a new instance of the SapCloudForCustomerSink class.
        /// </summary>
        public SapCloudForCustomerSink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SapCloudForCustomerSink class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="writeBatchSize">Write batch size. Type: integer (or
        /// Expression with resultType integer), minimum: 0.</param>
        /// <param name="writeBatchTimeout">Write batch timeout. Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="sinkRetryCount">Sink retry count. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="sinkRetryWait">Sink retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the sink data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="tableOption">The option to handle sink table, such as
        /// autoCreate. For now only 'autoCreate' value is supported. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="writeBehavior">The write behavior for the operation.
        /// Default is 'Insert'. Possible values include: 'Insert',
        /// 'Update'</param>
        public SapCloudForCustomerSink(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object writeBatchSize = default(object), object writeBatchTimeout = default(object), object sinkRetryCount = default(object), object sinkRetryWait = default(object), object maxConcurrentConnections = default(object), object tableOption = default(object), string writeBehavior = default(string))
            : base(additionalProperties, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, tableOption)
        {
            WriteBehavior = writeBehavior;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the write behavior for the operation. Default is
        /// 'Insert'. Possible values include: 'Insert', 'Update'
        /// </summary>
        [JsonProperty(PropertyName = "writeBehavior")]
        public string WriteBehavior { get; set; }

    }
}
