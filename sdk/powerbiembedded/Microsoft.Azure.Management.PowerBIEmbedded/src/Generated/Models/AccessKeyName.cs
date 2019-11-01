// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AccessKeyName.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccessKeyName
    {
        [EnumMember(Value = "key1")]
        Key1,
        [EnumMember(Value = "key2")]
        Key2
    }
    internal static class AccessKeyNameEnumExtension
    {
        internal static string ToSerializedValue(this AccessKeyName? value)
        {
            return value == null ? null : ((AccessKeyName)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AccessKeyName value)
        {
            switch( value )
            {
                case AccessKeyName.Key1:
                    return "key1";
                case AccessKeyName.Key2:
                    return "key2";
            }
            return null;
        }

        internal static AccessKeyName? ParseAccessKeyName(this string value)
        {
            switch( value )
            {
                case "key1":
                    return AccessKeyName.Key1;
                case "key2":
                    return AccessKeyName.Key2;
            }
            return null;
        }
    }
}
