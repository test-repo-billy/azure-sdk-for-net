// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// QuotaOperations operations.
    /// </summary>
    public partial interface IQuotaOperations
    {
        /// <summary>
        /// Gets the current quota limit and usages for the resources provider
        /// for the specified location for the specific resource.
        /// </summary>
        /// <remarks>
        /// This API gets the current quota limit and usages for the secific
        /// resource for resources provider for the specified location. This
        /// response can be used to submit quotaRequests.
        /// </remarks>
        /// <param name='subscriptionId'>
        /// Azure subscription id.
        /// </param>
        /// <param name='providerId'>
        /// Azure resource Provider id.
        /// </param>
        /// <param name='location'>
        /// User's Azure region.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ExceptionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CurrentQuotaLimit>> ListStatusWithHttpMessagesAsync(string subscriptionId, string providerId, string location, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the current quota limit and usages for the resources provider
        /// for the specified location for the specific resource.
        /// </summary>
        /// <remarks>
        /// This API gets the current quota limit and usages for the secific
        /// resource for resources provider for the specified location. This
        /// response can be used to submit quotaRequests.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ExceptionResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CurrentQuotaLimit>> ListStatusNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
