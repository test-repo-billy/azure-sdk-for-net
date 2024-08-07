// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary>
    /// Specifies any dependencies of a Task. Any Task that is explicitly specified or
    /// within a dependency range must complete before the dependant Task will be
    /// scheduled.
    /// </summary>
    public partial class BatchTaskDependencies
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

        /// <summary> Initializes a new instance of <see cref="BatchTaskDependencies"/>. </summary>
        public BatchTaskDependencies()
        {
            TaskIds = new ChangeTrackingList<string>();
            TaskIdRanges = new ChangeTrackingList<BatchTaskIdRange>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchTaskDependencies"/>. </summary>
        /// <param name="taskIds"> The list of Task IDs that this Task depends on. All Tasks in this list must complete successfully before the dependent Task can be scheduled. The taskIds collection is limited to 64000 characters total (i.e. the combined length of all Task IDs). If the taskIds collection exceeds the maximum length, the Add Task request fails with error code TaskDependencyListTooLong. In this case consider using Task ID ranges instead. </param>
        /// <param name="taskIdRanges"> The list of Task ID ranges that this Task depends on. All Tasks in all ranges must complete successfully before the dependent Task can be scheduled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchTaskDependencies(IList<string> taskIds, IList<BatchTaskIdRange> taskIdRanges, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TaskIds = taskIds;
            TaskIdRanges = taskIdRanges;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of Task IDs that this Task depends on. All Tasks in this list must complete successfully before the dependent Task can be scheduled. The taskIds collection is limited to 64000 characters total (i.e. the combined length of all Task IDs). If the taskIds collection exceeds the maximum length, the Add Task request fails with error code TaskDependencyListTooLong. In this case consider using Task ID ranges instead. </summary>
        public IList<string> TaskIds { get; }
        /// <summary> The list of Task ID ranges that this Task depends on. All Tasks in all ranges must complete successfully before the dependent Task can be scheduled. </summary>
        public IList<BatchTaskIdRange> TaskIdRanges { get; }
    }
}
