// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> Connector mapping property availability. </summary>
    public partial class ConnectorMappingAvailability
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

        /// <summary> Initializes a new instance of <see cref="ConnectorMappingAvailability"/>. </summary>
        /// <param name="interval"> The interval of the given frequency to use. </param>
        public ConnectorMappingAvailability(int interval)
        {
            Interval = interval;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectorMappingAvailability"/>. </summary>
        /// <param name="frequency"> The frequency to update. </param>
        /// <param name="interval"> The interval of the given frequency to use. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectorMappingAvailability(FrequencyType? frequency, int interval, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Frequency = frequency;
            Interval = interval;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectorMappingAvailability"/> for deserialization. </summary>
        internal ConnectorMappingAvailability()
        {
        }

        /// <summary> The frequency to update. </summary>
        public FrequencyType? Frequency { get; set; }
        /// <summary> The interval of the given frequency to use. </summary>
        public int Interval { get; set; }
    }
}
