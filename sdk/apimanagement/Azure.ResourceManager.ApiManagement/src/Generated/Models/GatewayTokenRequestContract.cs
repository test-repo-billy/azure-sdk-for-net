// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Gateway token request contract properties. </summary>
    public partial class GatewayTokenRequestContract
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GatewayTokenRequestContract"/>. </summary>
        /// <param name="keyType"> The Key to be used to generate gateway token. </param>
        /// <param name="expiry">
        /// The Expiry time of the Token. Maximum token expiry time is set to 30 days. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        public GatewayTokenRequestContract(TokenGenerationUsedKeyType keyType, DateTimeOffset expiry)
        {
            KeyType = keyType;
            Expiry = expiry;
        }

        /// <summary> Initializes a new instance of <see cref="GatewayTokenRequestContract"/>. </summary>
        /// <param name="keyType"> The Key to be used to generate gateway token. </param>
        /// <param name="expiry">
        /// The Expiry time of the Token. Maximum token expiry time is set to 30 days. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GatewayTokenRequestContract(TokenGenerationUsedKeyType keyType, DateTimeOffset expiry, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyType = keyType;
            Expiry = expiry;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GatewayTokenRequestContract"/> for deserialization. </summary>
        internal GatewayTokenRequestContract()
        {
        }

        /// <summary> The Key to be used to generate gateway token. </summary>
        [WirePath("keyType")]
        public TokenGenerationUsedKeyType KeyType { get; }
        /// <summary>
        /// The Expiry time of the Token. Maximum token expiry time is set to 30 days. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        [WirePath("expiry")]
        public DateTimeOffset Expiry { get; }
    }
}
