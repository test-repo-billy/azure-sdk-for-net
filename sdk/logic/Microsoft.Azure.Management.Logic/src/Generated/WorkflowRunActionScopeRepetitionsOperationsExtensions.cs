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
    /// Extension methods for WorkflowRunActionScopeRepetitionsOperations.
    /// </summary>
    public static partial class WorkflowRunActionScopeRepetitionsOperationsExtensions
    {
            /// <summary>
            /// List the workflow run action scoped repetitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='runName'>
            /// The workflow run name.
            /// </param>
            /// <param name='actionName'>
            /// The workflow action name.
            /// </param>
            public static IPage<WorkflowRunActionRepetitionDefinition> List(this IWorkflowRunActionScopeRepetitionsOperations operations, string resourceGroupName, string workflowName, string runName, string actionName)
            {
                return operations.ListAsync(resourceGroupName, workflowName, runName, actionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the workflow run action scoped repetitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='runName'>
            /// The workflow run name.
            /// </param>
            /// <param name='actionName'>
            /// The workflow action name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkflowRunActionRepetitionDefinition>> ListAsync(this IWorkflowRunActionScopeRepetitionsOperations operations, string resourceGroupName, string workflowName, string runName, string actionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workflowName, runName, actionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a workflow run action scoped repetition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='runName'>
            /// The workflow run name.
            /// </param>
            /// <param name='actionName'>
            /// The workflow action name.
            /// </param>
            /// <param name='repetitionName'>
            /// The workflow repetition.
            /// </param>
            public static WorkflowRunActionRepetitionDefinition Get(this IWorkflowRunActionScopeRepetitionsOperations operations, string resourceGroupName, string workflowName, string runName, string actionName, string repetitionName)
            {
                return operations.GetAsync(resourceGroupName, workflowName, runName, actionName, repetitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a workflow run action scoped repetition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='workflowName'>
            /// The workflow name.
            /// </param>
            /// <param name='runName'>
            /// The workflow run name.
            /// </param>
            /// <param name='actionName'>
            /// The workflow action name.
            /// </param>
            /// <param name='repetitionName'>
            /// The workflow repetition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkflowRunActionRepetitionDefinition> GetAsync(this IWorkflowRunActionScopeRepetitionsOperations operations, string resourceGroupName, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workflowName, runName, actionName, repetitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the workflow run action scoped repetitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WorkflowRunActionRepetitionDefinition> ListNext(this IWorkflowRunActionScopeRepetitionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the workflow run action scoped repetitions.
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
            public static async Task<IPage<WorkflowRunActionRepetitionDefinition>> ListNextAsync(this IWorkflowRunActionScopeRepetitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
