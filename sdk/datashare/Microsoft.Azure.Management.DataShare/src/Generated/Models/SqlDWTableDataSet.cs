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
    /// A SQL DW table dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SqlDWTable")]
    [Rest.Serialization.JsonTransformation]
    public partial class SqlDWTableDataSet : DataSet
    {
        /// <summary>
        /// Initializes a new instance of the SqlDWTableDataSet class.
        /// </summary>
        public SqlDWTableDataSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlDWTableDataSet class.
        /// </summary>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="dataSetId">Unique id for identifying a data set
        /// resource</param>
        /// <param name="dataWarehouseName">DataWarehouse name of the source
        /// data set</param>
        /// <param name="sqlServerResourceId">Resource id of SQL server</param>
        /// <param name="tableName">SQL DW table name.</param>
        public SqlDWTableDataSet(string id = default(string), string name = default(string), string type = default(string), string dataSetId = default(string), string dataWarehouseName = default(string), string sqlServerResourceId = default(string), string tableName = default(string))
            : base(id, name, type)
        {
            DataSetId = dataSetId;
            DataWarehouseName = dataWarehouseName;
            SqlServerResourceId = sqlServerResourceId;
            TableName = tableName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unique id for identifying a data set resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetId")]
        public string DataSetId { get; private set; }

        /// <summary>
        /// Gets or sets dataWarehouse name of the source data set
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataWarehouseName")]
        public string DataWarehouseName { get; set; }

        /// <summary>
        /// Gets or sets resource id of SQL server
        /// </summary>
        [JsonProperty(PropertyName = "properties.sqlServerResourceId")]
        public string SqlServerResourceId { get; set; }

        /// <summary>
        /// Gets or sets SQL DW table name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tableName")]
        public string TableName { get; set; }

    }
}
