// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IntegrationServiceEnvironmentsOperations.
    /// </summary>
    public static partial class IntegrationServiceEnvironmentsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of integration service environments by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            public static IPage<IntegrationServiceEnvironment> ListBySubscription(this IIntegrationServiceEnvironmentsOperations operations, int? top = default(int?))
            {
                return operations.ListBySubscriptionAsync(top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration service environments by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IntegrationServiceEnvironment>> ListBySubscriptionAsync(this IIntegrationServiceEnvironmentsOperations operations, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of integration service environments by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            public static IPage<IntegrationServiceEnvironment> ListByResourceGroup(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, int? top = default(int?))
            {
                return operations.ListByResourceGroupAsync(resourceGroup, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration service environments by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IntegrationServiceEnvironment>> ListByResourceGroupAsync(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroup, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an integration service environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            public static IntegrationServiceEnvironment Get(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, string integrationServiceEnvironmentName)
            {
                return operations.GetAsync(resourceGroup, integrationServiceEnvironmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an integration service environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationServiceEnvironment> GetAsync(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, string integrationServiceEnvironmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroup, integrationServiceEnvironmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an integration service environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='integrationServiceEnvironment'>
            /// The integration service environment.
            /// </param>
            public static IntegrationServiceEnvironment CreateOrUpdate(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, string integrationServiceEnvironmentName, IntegrationServiceEnvironment integrationServiceEnvironment)
            {
                return operations.CreateOrUpdateAsync(resourceGroup, integrationServiceEnvironmentName, integrationServiceEnvironment).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an integration service environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='integrationServiceEnvironment'>
            /// The integration service environment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationServiceEnvironment> CreateOrUpdateAsync(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, string integrationServiceEnvironmentName, IntegrationServiceEnvironment integrationServiceEnvironment, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroup, integrationServiceEnvironmentName, integrationServiceEnvironment, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an integration service environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='integrationServiceEnvironment'>
            /// The integration service environment.
            /// </param>
            public static IntegrationServiceEnvironment Update(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, string integrationServiceEnvironmentName, IntegrationServiceEnvironment integrationServiceEnvironment)
            {
                return operations.UpdateAsync(resourceGroup, integrationServiceEnvironmentName, integrationServiceEnvironment).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an integration service environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='integrationServiceEnvironment'>
            /// The integration service environment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationServiceEnvironment> UpdateAsync(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, string integrationServiceEnvironmentName, IntegrationServiceEnvironment integrationServiceEnvironment, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroup, integrationServiceEnvironmentName, integrationServiceEnvironment, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an integration service environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            public static void Delete(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, string integrationServiceEnvironmentName)
            {
                operations.DeleteAsync(resourceGroup, integrationServiceEnvironmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an integration service environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, string integrationServiceEnvironmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroup, integrationServiceEnvironmentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates an integration service environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='integrationServiceEnvironment'>
            /// The integration service environment.
            /// </param>
            public static IntegrationServiceEnvironment BeginCreateOrUpdate(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, string integrationServiceEnvironmentName, IntegrationServiceEnvironment integrationServiceEnvironment)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroup, integrationServiceEnvironmentName, integrationServiceEnvironment).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an integration service environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='integrationServiceEnvironment'>
            /// The integration service environment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationServiceEnvironment> BeginCreateOrUpdateAsync(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, string integrationServiceEnvironmentName, IntegrationServiceEnvironment integrationServiceEnvironment, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroup, integrationServiceEnvironmentName, integrationServiceEnvironment, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an integration service environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='integrationServiceEnvironment'>
            /// The integration service environment.
            /// </param>
            public static IntegrationServiceEnvironment BeginUpdate(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, string integrationServiceEnvironmentName, IntegrationServiceEnvironment integrationServiceEnvironment)
            {
                return operations.BeginUpdateAsync(resourceGroup, integrationServiceEnvironmentName, integrationServiceEnvironment).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an integration service environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='integrationServiceEnvironment'>
            /// The integration service environment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationServiceEnvironment> BeginUpdateAsync(this IIntegrationServiceEnvironmentsOperations operations, string resourceGroup, string integrationServiceEnvironmentName, IntegrationServiceEnvironment integrationServiceEnvironment, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroup, integrationServiceEnvironmentName, integrationServiceEnvironment, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of integration service environments by subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IntegrationServiceEnvironment> ListBySubscriptionNext(this IIntegrationServiceEnvironmentsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration service environments by subscription.
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
            public static async Task<IPage<IntegrationServiceEnvironment>> ListBySubscriptionNextAsync(this IIntegrationServiceEnvironmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of integration service environments by resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IntegrationServiceEnvironment> ListByResourceGroupNext(this IIntegrationServiceEnvironmentsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration service environments by resource group.
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
            public static async Task<IPage<IntegrationServiceEnvironment>> ListByResourceGroupNextAsync(this IIntegrationServiceEnvironmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
