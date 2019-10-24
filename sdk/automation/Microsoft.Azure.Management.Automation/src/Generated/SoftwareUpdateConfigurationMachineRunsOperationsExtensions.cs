// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SoftwareUpdateConfigurationMachineRunsOperations.
    /// </summary>
    public static partial class SoftwareUpdateConfigurationMachineRunsOperationsExtensions
    {
            /// <summary>
            /// Get a single software update configuration machine run by ID.
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='softwareUpdateConfigurationMachineRunId'>
            /// The ID of the software update configuration machine run.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            public static SoftwareUpdateConfigurationMachineRun GetById(this ISoftwareUpdateConfigurationMachineRunsOperations operations, string resourceGroupName, string automationAccountName, System.Guid softwareUpdateConfigurationMachineRunId, string clientRequestId = default(string))
            {
                return operations.GetByIdAsync(resourceGroupName, automationAccountName, softwareUpdateConfigurationMachineRunId, clientRequestId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a single software update configuration machine run by ID.
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='softwareUpdateConfigurationMachineRunId'>
            /// The ID of the software update configuration machine run.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SoftwareUpdateConfigurationMachineRun> GetByIdAsync(this ISoftwareUpdateConfigurationMachineRunsOperations operations, string resourceGroupName, string automationAccountName, System.Guid softwareUpdateConfigurationMachineRunId, string clientRequestId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(resourceGroupName, automationAccountName, softwareUpdateConfigurationMachineRunId, clientRequestId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Return list of software update configuration machine runs
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation. You can use the following filters:
            /// 'properties/osType', 'properties/status', 'properties/startTime', and
            /// 'properties/softwareUpdateConfiguration/name'.
            /// </param>
            /// <param name='skip'>
            /// Number of entries you skip before returning results.
            /// </param>
            /// <param name='top'>
            /// Maximum number of entries returned in the results collection.
            /// </param>
            public static IPage<SoftwareUpdateConfigurationMachineRun> List(this ISoftwareUpdateConfigurationMachineRunsOperations operations, string resourceGroupName, string automationAccountName, string clientRequestId = default(string), string filter = default(string), string skip = default(string), string top = default(string))
            {
                return operations.ListAsync(resourceGroupName, automationAccountName, clientRequestId, filter, skip, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return list of software update configuration machine runs
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation. You can use the following filters:
            /// 'properties/osType', 'properties/status', 'properties/startTime', and
            /// 'properties/softwareUpdateConfiguration/name'.
            /// </param>
            /// <param name='skip'>
            /// Number of entries you skip before returning results.
            /// </param>
            /// <param name='top'>
            /// Maximum number of entries returned in the results collection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SoftwareUpdateConfigurationMachineRun>> ListAsync(this ISoftwareUpdateConfigurationMachineRunsOperations operations, string resourceGroupName, string automationAccountName, string clientRequestId = default(string), string filter = default(string), string skip = default(string), string top = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, automationAccountName, clientRequestId, filter, skip, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Return list of software update configuration machine runs
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            public static IPage<SoftwareUpdateConfigurationMachineRun> ListNext(this ISoftwareUpdateConfigurationMachineRunsOperations operations, string nextPageLink, string clientRequestId = default(string))
            {
                return operations.ListNextAsync(nextPageLink, clientRequestId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return list of software update configuration machine runs
            /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='clientRequestId'>
            /// Identifies this specific client request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SoftwareUpdateConfigurationMachineRun>> ListNextAsync(this ISoftwareUpdateConfigurationMachineRunsOperations operations, string nextPageLink, string clientRequestId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, clientRequestId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
