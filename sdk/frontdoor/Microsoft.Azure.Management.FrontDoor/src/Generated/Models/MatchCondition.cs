// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Define a match condition.
    /// </summary>
    public partial class MatchCondition
    {
        /// <summary>
        /// Initializes a new instance of the MatchCondition class.
        /// </summary>
        public MatchCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MatchCondition class.
        /// </summary>
        /// <param name="matchVariable">Request variable to compare with.
        /// Possible values include: 'RemoteAddr', 'RequestMethod',
        /// 'QueryString', 'PostArgs', 'RequestUri', 'RequestHeader',
        /// 'RequestBody', 'Cookies', 'SocketAddr'</param>
        /// <param name="operatorProperty">Comparison type to use for matching
        /// with the variable value. Possible values include: 'Any', 'IPMatch',
        /// 'GeoMatch', 'Equal', 'Contains', 'LessThan', 'GreaterThan',
        /// 'LessThanOrEqual', 'GreaterThanOrEqual', 'BeginsWith', 'EndsWith',
        /// 'RegEx'</param>
        /// <param name="matchValue">List of possible match values.</param>
        /// <param name="selector">Match against a specific key from the
        /// QueryString, PostArgs, RequestHeader or Cookies variables. Default
        /// is null.</param>
        /// <param name="negateCondition">Describes if the result of this
        /// condition should be negated.</param>
        /// <param name="transforms">List of transforms.</param>
        public MatchCondition(string matchVariable, string operatorProperty, IList<string> matchValue, string selector = default(string), bool? negateCondition = default(bool?), IList<string> transforms = default(IList<string>))
        {
            MatchVariable = matchVariable;
            Selector = selector;
            OperatorProperty = operatorProperty;
            NegateCondition = negateCondition;
            MatchValue = matchValue;
            Transforms = transforms;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets request variable to compare with. Possible values
        /// include: 'RemoteAddr', 'RequestMethod', 'QueryString', 'PostArgs',
        /// 'RequestUri', 'RequestHeader', 'RequestBody', 'Cookies',
        /// 'SocketAddr'
        /// </summary>
        [JsonProperty(PropertyName = "matchVariable")]
        public string MatchVariable { get; set; }

        /// <summary>
        /// Gets or sets match against a specific key from the QueryString,
        /// PostArgs, RequestHeader or Cookies variables. Default is null.
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public string Selector { get; set; }

        /// <summary>
        /// Gets or sets comparison type to use for matching with the variable
        /// value. Possible values include: 'Any', 'IPMatch', 'GeoMatch',
        /// 'Equal', 'Contains', 'LessThan', 'GreaterThan', 'LessThanOrEqual',
        /// 'GreaterThanOrEqual', 'BeginsWith', 'EndsWith', 'RegEx'
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// Gets or sets describes if the result of this condition should be
        /// negated.
        /// </summary>
        [JsonProperty(PropertyName = "negateCondition")]
        public bool? NegateCondition { get; set; }

        /// <summary>
        /// Gets or sets list of possible match values.
        /// </summary>
        [JsonProperty(PropertyName = "matchValue")]
        public IList<string> MatchValue { get; set; }

        /// <summary>
        /// Gets or sets list of transforms.
        /// </summary>
        [JsonProperty(PropertyName = "transforms")]
        public IList<string> Transforms { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MatchVariable == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MatchVariable");
            }
            if (OperatorProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OperatorProperty");
            }
            if (MatchValue == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MatchValue");
            }
        }
    }
}
