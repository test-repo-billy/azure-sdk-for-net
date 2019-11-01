// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppConfiguration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ConfigurationStoresOperations.
    /// </summary>
    public static partial class ConfigurationStoresOperationsExtensions
    {
            /// <summary>
            /// Lists the configuration stores for a given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skipToken'>
            /// A skip token is used to continue retrieving items after an operation
            /// returns a partial result. If a previous response contains a nextLink
            /// element, the value of the nextLink element will include a skipToken
            /// parameter that specifies a starting point to use for subsequent calls.
            /// </param>
            public static IPage<ConfigurationStore> List(this IConfigurationStoresOperations operations, string skipToken = default(string))
            {
                return operations.ListAsync(skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the configuration stores for a given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skipToken'>
            /// A skip token is used to continue retrieving items after an operation
            /// returns a partial result. If a previous response contains a nextLink
            /// element, the value of the nextLink element will include a skipToken
            /// parameter that specifies a starting point to use for subsequent calls.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConfigurationStore>> ListAsync(this IConfigurationStoresOperations operations, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the configuration stores for a given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='skipToken'>
            /// A skip token is used to continue retrieving items after an operation
            /// returns a partial result. If a previous response contains a nextLink
            /// element, the value of the nextLink element will include a skipToken
            /// parameter that specifies a starting point to use for subsequent calls.
            /// </param>
            public static IPage<ConfigurationStore> ListByResourceGroup(this IConfigurationStoresOperations operations, string resourceGroupName, string skipToken = default(string))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the configuration stores for a given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='skipToken'>
            /// A skip token is used to continue retrieving items after an operation
            /// returns a partial result. If a previous response contains a nextLink
            /// element, the value of the nextLink element will include a skipToken
            /// parameter that specifies a starting point to use for subsequent calls.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConfigurationStore>> ListByResourceGroupAsync(this IConfigurationStoresOperations operations, string resourceGroupName, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the properties of the specified configuration store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            public static ConfigurationStore Get(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName)
            {
                return operations.GetAsync(resourceGroupName, configStoreName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of the specified configuration store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConfigurationStore> GetAsync(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, configStoreName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a configuration store with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='location'>
            /// The location of the resource. This cannot be changed after the resource is
            /// created.
            /// </param>
            /// <param name='tags'>
            /// The tags of the resource.
            /// </param>
            public static ConfigurationStore Create(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, string location, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.CreateAsync(resourceGroupName, configStoreName, location, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a configuration store with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='location'>
            /// The location of the resource. This cannot be changed after the resource is
            /// created.
            /// </param>
            /// <param name='tags'>
            /// The tags of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConfigurationStore> CreateAsync(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, string location, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, configStoreName, location, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a configuration store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            public static void Delete(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName)
            {
                operations.DeleteAsync(resourceGroupName, configStoreName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a configuration store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, configStoreName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a configuration store with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='properties'>
            /// The properties for updating a configuration store.
            /// </param>
            /// <param name='tags'>
            /// The ARM resource tags.
            /// </param>
            public static ConfigurationStore Update(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, object properties = default(object), IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateAsync(resourceGroupName, configStoreName, properties, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a configuration store with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='properties'>
            /// The properties for updating a configuration store.
            /// </param>
            /// <param name='tags'>
            /// The ARM resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConfigurationStore> UpdateAsync(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, object properties = default(object), IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, configStoreName, properties, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the access key for the specified configuration store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='skipToken'>
            /// A skip token is used to continue retrieving items after an operation
            /// returns a partial result. If a previous response contains a nextLink
            /// element, the value of the nextLink element will include a skipToken
            /// parameter that specifies a starting point to use for subsequent calls.
            /// </param>
            public static IPage<ApiKey> ListKeys(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, string skipToken = default(string))
            {
                return operations.ListKeysAsync(resourceGroupName, configStoreName, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the access key for the specified configuration store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='skipToken'>
            /// A skip token is used to continue retrieving items after an operation
            /// returns a partial result. If a previous response contains a nextLink
            /// element, the value of the nextLink element will include a skipToken
            /// parameter that specifies a starting point to use for subsequent calls.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApiKey>> ListKeysAsync(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, configStoreName, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates an access key for the specified configuration store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='id'>
            /// The id of the key to regenerate.
            /// </param>
            public static ApiKey RegenerateKey(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, string id = default(string))
            {
                return operations.RegenerateKeyAsync(resourceGroupName, configStoreName, id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates an access key for the specified configuration store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='id'>
            /// The id of the key to regenerate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiKey> RegenerateKeyAsync(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, string id = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeyWithHttpMessagesAsync(resourceGroupName, configStoreName, id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists a configuration store key-value.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='key'>
            /// The key to retrieve.
            /// </param>
            /// <param name='label'>
            /// The label of the key.
            /// </param>
            public static KeyValue ListKeyValue(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, string key, string label = default(string))
            {
                return operations.ListKeyValueAsync(resourceGroupName, configStoreName, key, label).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a configuration store key-value.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='key'>
            /// The key to retrieve.
            /// </param>
            /// <param name='label'>
            /// The label of the key.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<KeyValue> ListKeyValueAsync(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, string key, string label = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeyValueWithHttpMessagesAsync(resourceGroupName, configStoreName, key, label, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a configuration store with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='location'>
            /// The location of the resource. This cannot be changed after the resource is
            /// created.
            /// </param>
            /// <param name='tags'>
            /// The tags of the resource.
            /// </param>
            public static ConfigurationStore BeginCreate(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, string location, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.BeginCreateAsync(resourceGroupName, configStoreName, location, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a configuration store with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='location'>
            /// The location of the resource. This cannot be changed after the resource is
            /// created.
            /// </param>
            /// <param name='tags'>
            /// The tags of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConfigurationStore> BeginCreateAsync(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, string location, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, configStoreName, location, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a configuration store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            public static void BeginDelete(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName)
            {
                operations.BeginDeleteAsync(resourceGroupName, configStoreName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a configuration store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, configStoreName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a configuration store with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='properties'>
            /// The properties for updating a configuration store.
            /// </param>
            /// <param name='tags'>
            /// The ARM resource tags.
            /// </param>
            public static ConfigurationStore BeginUpdate(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, object properties = default(object), IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.BeginUpdateAsync(resourceGroupName, configStoreName, properties, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a configuration store with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='configStoreName'>
            /// The name of the configuration store.
            /// </param>
            /// <param name='properties'>
            /// The properties for updating a configuration store.
            /// </param>
            /// <param name='tags'>
            /// The ARM resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConfigurationStore> BeginUpdateAsync(this IConfigurationStoresOperations operations, string resourceGroupName, string configStoreName, object properties = default(object), IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, configStoreName, properties, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the configuration stores for a given subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ConfigurationStore> ListNext(this IConfigurationStoresOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the configuration stores for a given subscription.
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
            public static async Task<IPage<ConfigurationStore>> ListNextAsync(this IConfigurationStoresOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the configuration stores for a given resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ConfigurationStore> ListByResourceGroupNext(this IConfigurationStoresOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the configuration stores for a given resource group.
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
            public static async Task<IPage<ConfigurationStore>> ListByResourceGroupNextAsync(this IConfigurationStoresOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the access key for the specified configuration store.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ApiKey> ListKeysNext(this IConfigurationStoresOperations operations, string nextPageLink)
            {
                return operations.ListKeysNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the access key for the specified configuration store.
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
            public static async Task<IPage<ApiKey>> ListKeysNextAsync(this IConfigurationStoresOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
