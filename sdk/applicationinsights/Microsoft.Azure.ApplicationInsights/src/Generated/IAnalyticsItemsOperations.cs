// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// AnalyticsItemsOperations operations.
    /// </summary>
    public partial interface IAnalyticsItemsOperations
    {
        /// <summary>
        /// Gets a list of Analytics Items defined within an Application
        /// Insights component.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the Application Insights component resource.
        /// </param>
        /// <param name='scopePath'>
        /// Enum indicating if this item definition is owned by a specific user
        /// or is shared between all users with access to the Application
        /// Insights component. Possible values include: 'analyticsItems',
        /// 'myanalyticsItems'
        /// </param>
        /// <param name='scope'>
        /// Enum indicating if this item definition is owned by a specific user
        /// or is shared between all users with access to the Application
        /// Insights component. Possible values include: 'shared', 'user'
        /// </param>
        /// <param name='type'>
        /// Enum indicating the type of the Analytics item. Possible values
        /// include: 'none', 'query', 'function', 'folder', 'recent'
        /// </param>
        /// <param name='includeContent'>
        /// Flag indicating whether or not to return the content of each
        /// applicable item. If false, only return the item information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IList<ApplicationInsightsComponentAnalyticsItem>>> ListWithHttpMessagesAsync(string resourceGroupName, string resourceName, string scopePath, string scope = default(string), string type = default(string), bool? includeContent = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a specific Analytics Items defined within an Application
        /// Insights component.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the Application Insights component resource.
        /// </param>
        /// <param name='scopePath'>
        /// Enum indicating if this item definition is owned by a specific user
        /// or is shared between all users with access to the Application
        /// Insights component. Possible values include: 'analyticsItems',
        /// 'myanalyticsItems'
        /// </param>
        /// <param name='id'>
        /// The Id of a specific item defined in the Application Insights
        /// component
        /// </param>
        /// <param name='name'>
        /// The name of a specific item defined in the Application Insights
        /// component
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ApplicationInsightsComponentAnalyticsItem>> GetWithHttpMessagesAsync(string resourceGroupName, string resourceName, string scopePath, string id = default(string), string name = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds or Updates a specific Analytics Item within an Application
        /// Insights component.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the Application Insights component resource.
        /// </param>
        /// <param name='scopePath'>
        /// Enum indicating if this item definition is owned by a specific user
        /// or is shared between all users with access to the Application
        /// Insights component. Possible values include: 'analyticsItems',
        /// 'myanalyticsItems'
        /// </param>
        /// <param name='itemProperties'>
        /// Properties that need to be specified to create a new item and add
        /// it to an Application Insights component.
        /// </param>
        /// <param name='overrideItem'>
        /// Flag indicating whether or not to force save an item. This allows
        /// overriding an item if it already exists.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ApplicationInsightsComponentAnalyticsItem>> PutWithHttpMessagesAsync(string resourceGroupName, string resourceName, string scopePath, ApplicationInsightsComponentAnalyticsItem itemProperties, bool? overrideItem = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a specific Analytics Items defined within an Application
        /// Insights component.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the Application Insights component resource.
        /// </param>
        /// <param name='scopePath'>
        /// Enum indicating if this item definition is owned by a specific user
        /// or is shared between all users with access to the Application
        /// Insights component. Possible values include: 'analyticsItems',
        /// 'myanalyticsItems'
        /// </param>
        /// <param name='id'>
        /// The Id of a specific item defined in the Application Insights
        /// component
        /// </param>
        /// <param name='name'>
        /// The name of a specific item defined in the Application Insights
        /// component
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, string scopePath, string id = default(string), string name = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
