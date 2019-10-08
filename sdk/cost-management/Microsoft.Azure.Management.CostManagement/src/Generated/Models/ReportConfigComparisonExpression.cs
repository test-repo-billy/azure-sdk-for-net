// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CostManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The comparison expression to be used in the report.
    /// </summary>
    public partial class ReportConfigComparisonExpression
    {
        /// <summary>
        /// Initializes a new instance of the ReportConfigComparisonExpression
        /// class.
        /// </summary>
        public ReportConfigComparisonExpression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReportConfigComparisonExpression
        /// class.
        /// </summary>
        /// <param name="name">The name of the column to use in
        /// comparison.</param>
        /// <param name="operatorProperty">The operator to use for comparison.
        /// Possible values include: 'In', 'Contains'</param>
        /// <param name="values">Array of values to use for comparison</param>
        public ReportConfigComparisonExpression(string name, string operatorProperty, IList<string> values)
        {
            Name = name;
            OperatorProperty = operatorProperty;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the column to use in comparison.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the operator to use for comparison. Possible values
        /// include: 'In', 'Contains'
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// Gets or sets array of values to use for comparison
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (OperatorProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OperatorProperty");
            }
            if (Values == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Values");
            }
            if (Values != null)
            {
                if (Values.Count < 1)
                {
                    throw new ValidationException(ValidationRules.MinItems, "Values", 1);
                }
            }
        }
    }
}
