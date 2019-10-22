// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A SQL DB Table data set mapping.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SqlDBTable")]
    [Rest.Serialization.JsonTransformation]
    public partial class SqlDBTableDataSetMapping : DataSetMapping
    {
        /// <summary>
        /// Initializes a new instance of the SqlDBTableDataSetMapping class.
        /// </summary>
        public SqlDBTableDataSetMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlDBTableDataSetMapping class.
        /// </summary>
        /// <param name="databaseName">DatabaseName name of the sink data
        /// set</param>
        /// <param name="dataSetId">The id of the source data set.</param>
        /// <param name="sqlServerResourceId">Resource id of SQL server</param>
        /// <param name="tableName">SQL DB table name.</param>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="dataSetMappingStatus">Gets the status of the data set
        /// mapping. Possible values include: 'Ok', 'Broken'</param>
        public SqlDBTableDataSetMapping(string databaseName, string dataSetId, string sqlServerResourceId, string tableName, string id = default(string), string name = default(string), string type = default(string), string dataSetMappingStatus = default(string))
            : base(id, name, type)
        {
            DatabaseName = databaseName;
            DataSetId = dataSetId;
            DataSetMappingStatus = dataSetMappingStatus;
            SqlServerResourceId = sqlServerResourceId;
            TableName = tableName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets databaseName name of the sink data set
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the id of the source data set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetId")]
        public string DataSetId { get; set; }

        /// <summary>
        /// Gets the status of the data set mapping. Possible values include:
        /// 'Ok', 'Broken'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetMappingStatus")]
        public string DataSetMappingStatus { get; set; }

        /// <summary>
        /// Gets or sets resource id of SQL server
        /// </summary>
        [JsonProperty(PropertyName = "properties.sqlServerResourceId")]
        public string SqlServerResourceId { get; set; }

        /// <summary>
        /// Gets or sets SQL DB table name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tableName")]
        public string TableName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DatabaseName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DatabaseName");
            }
            if (DataSetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSetId");
            }
            if (SqlServerResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SqlServerResourceId");
            }
            if (TableName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TableName");
            }
        }
    }
}
