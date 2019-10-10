// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FrontendEndpointsOperations.
    /// </summary>
    public static partial class FrontendEndpointsOperationsExtensions
    {
            /// <summary>
            /// Lists all of the frontend endpoints within a Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            public static IPage<FrontendEndpoint> ListByFrontDoor(this IFrontendEndpointsOperations operations, string resourceGroupName, string frontDoorName)
            {
                return operations.ListByFrontDoorAsync(resourceGroupName, frontDoorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the frontend endpoints within a Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FrontendEndpoint>> ListByFrontDoorAsync(this IFrontendEndpointsOperations operations, string resourceGroupName, string frontDoorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFrontDoorWithHttpMessagesAsync(resourceGroupName, frontDoorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a Frontend endpoint with the specified name within the specified Front
            /// Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='frontendEndpointName'>
            /// Name of the Frontend endpoint which is unique within the Front Door.
            /// </param>
            public static FrontendEndpoint Get(this IFrontendEndpointsOperations operations, string resourceGroupName, string frontDoorName, string frontendEndpointName)
            {
                return operations.GetAsync(resourceGroupName, frontDoorName, frontendEndpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Frontend endpoint with the specified name within the specified Front
            /// Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='frontendEndpointName'>
            /// Name of the Frontend endpoint which is unique within the Front Door.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FrontendEndpoint> GetAsync(this IFrontendEndpointsOperations operations, string resourceGroupName, string frontDoorName, string frontendEndpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, frontDoorName, frontendEndpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Enables a frontendEndpoint for HTTPS traffic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='frontendEndpointName'>
            /// Name of the Frontend endpoint which is unique within the Front Door.
            /// </param>
            /// <param name='customHttpsConfiguration'>
            /// The configuration specifying how to enable HTTPS
            /// </param>
            public static void EnableHttps(this IFrontendEndpointsOperations operations, string resourceGroupName, string frontDoorName, string frontendEndpointName, CustomHttpsConfiguration customHttpsConfiguration)
            {
                operations.EnableHttpsAsync(resourceGroupName, frontDoorName, frontendEndpointName, customHttpsConfiguration).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables a frontendEndpoint for HTTPS traffic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='frontendEndpointName'>
            /// Name of the Frontend endpoint which is unique within the Front Door.
            /// </param>
            /// <param name='customHttpsConfiguration'>
            /// The configuration specifying how to enable HTTPS
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EnableHttpsAsync(this IFrontendEndpointsOperations operations, string resourceGroupName, string frontDoorName, string frontendEndpointName, CustomHttpsConfiguration customHttpsConfiguration, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.EnableHttpsWithHttpMessagesAsync(resourceGroupName, frontDoorName, frontendEndpointName, customHttpsConfiguration, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Disables a frontendEndpoint for HTTPS traffic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='frontendEndpointName'>
            /// Name of the Frontend endpoint which is unique within the Front Door.
            /// </param>
            public static void DisableHttps(this IFrontendEndpointsOperations operations, string resourceGroupName, string frontDoorName, string frontendEndpointName)
            {
                operations.DisableHttpsAsync(resourceGroupName, frontDoorName, frontendEndpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disables a frontendEndpoint for HTTPS traffic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='frontendEndpointName'>
            /// Name of the Frontend endpoint which is unique within the Front Door.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DisableHttpsAsync(this IFrontendEndpointsOperations operations, string resourceGroupName, string frontDoorName, string frontendEndpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DisableHttpsWithHttpMessagesAsync(resourceGroupName, frontDoorName, frontendEndpointName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Enables a frontendEndpoint for HTTPS traffic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='frontendEndpointName'>
            /// Name of the Frontend endpoint which is unique within the Front Door.
            /// </param>
            /// <param name='customHttpsConfiguration'>
            /// The configuration specifying how to enable HTTPS
            /// </param>
            public static void BeginEnableHttps(this IFrontendEndpointsOperations operations, string resourceGroupName, string frontDoorName, string frontendEndpointName, CustomHttpsConfiguration customHttpsConfiguration)
            {
                operations.BeginEnableHttpsAsync(resourceGroupName, frontDoorName, frontendEndpointName, customHttpsConfiguration).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables a frontendEndpoint for HTTPS traffic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='frontendEndpointName'>
            /// Name of the Frontend endpoint which is unique within the Front Door.
            /// </param>
            /// <param name='customHttpsConfiguration'>
            /// The configuration specifying how to enable HTTPS
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginEnableHttpsAsync(this IFrontendEndpointsOperations operations, string resourceGroupName, string frontDoorName, string frontendEndpointName, CustomHttpsConfiguration customHttpsConfiguration, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginEnableHttpsWithHttpMessagesAsync(resourceGroupName, frontDoorName, frontendEndpointName, customHttpsConfiguration, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Disables a frontendEndpoint for HTTPS traffic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='frontendEndpointName'>
            /// Name of the Frontend endpoint which is unique within the Front Door.
            /// </param>
            public static void BeginDisableHttps(this IFrontendEndpointsOperations operations, string resourceGroupName, string frontDoorName, string frontendEndpointName)
            {
                operations.BeginDisableHttpsAsync(resourceGroupName, frontDoorName, frontendEndpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disables a frontendEndpoint for HTTPS traffic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='frontendEndpointName'>
            /// Name of the Frontend endpoint which is unique within the Front Door.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDisableHttpsAsync(this IFrontendEndpointsOperations operations, string resourceGroupName, string frontDoorName, string frontendEndpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDisableHttpsWithHttpMessagesAsync(resourceGroupName, frontDoorName, frontendEndpointName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all of the frontend endpoints within a Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FrontendEndpoint> ListByFrontDoorNext(this IFrontendEndpointsOperations operations, string nextPageLink)
            {
                return operations.ListByFrontDoorNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the frontend endpoints within a Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FrontendEndpoint>> ListByFrontDoorNextAsync(this IFrontendEndpointsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByFrontDoorNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
