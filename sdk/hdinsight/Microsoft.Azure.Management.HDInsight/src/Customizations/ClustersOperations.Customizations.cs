﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.HDInsight
{
    using Microsoft.Azure.Management.HDInsight.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    internal partial class ClustersOperations : IServiceOperations<HDInsightManagementClient>, IClustersOperations
    {
        /// <summary>
        /// Creates a new HDInsight cluster with the specified parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// Required. The name of the cluster.
        /// </param>
        /// <param name='clusterCreateParameters'>
        /// Required. The cluster create request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The GetCluster operation response.
        /// </returns>
        public async Task<AzureOperationResponse<Cluster>> CreateWithHttpMessagesAsync(string resourceGroupName, string clusterName, ClusterCreateParameters clusterCreateParameters, CancellationToken cancellationToken)
        {
            var createParamsExtended = CreateParametersConverter.GetExtendedClusterCreateParameters(clusterName, clusterCreateParameters);
            return await CreateWithHttpMessagesAsync(resourceGroupName, clusterName, createParamsExtended, null, cancellationToken);
        }

        /// <summary>
        /// Begins creating a new HDInsight cluster with the specified
        /// parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// Required. The name of the cluster.
        /// </param>
        /// <param name='clusterCreateParameters'>
        /// Required. The cluster create request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The CreateCluster operation response.
        /// </returns>
        public async Task<AzureOperationResponse<Cluster>> BeginCreatingAsync(string resourceGroupName, string clusterName, ClusterCreateParameters clusterCreateParameters, CancellationToken cancellationToken)
        {
            var createParamsExtended = CreateParametersConverter.GetExtendedClusterCreateParameters(clusterName, clusterCreateParameters);
            return await BeginCreateWithHttpMessagesAsync(resourceGroupName, clusterName, createParamsExtended, null, cancellationToken);
        }

        /// <summary>
        /// Resizes the specified HDInsight cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// Required. The name of the cluster.
        /// </param>
        /// <param name='targetInstanceCount'>
        /// Required. The target instance count for the resize operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The cluster long running operation response.
        /// </returns>
        public async Task<AzureOperationResponse> ResizeAsync(string resourceGroupName, string clusterName, int targetInstanceCount, CancellationToken cancellationToken)
        {
            var resizeParams = new ClusterResizeParameters { TargetInstanceCount = targetInstanceCount };
            return await ResizeWithHttpMessagesAsync(resourceGroupName, clusterName, resizeParams, null, cancellationToken);
        }

        /// <summary>
        /// Begins resizing the specified HDInsight cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// Required. The name of the cluster.
        /// </param>
        /// <param name='targetInstanceCount'>
        /// Required. The target instance count for the resize operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The cluster long running operation response.
        /// </returns>
        public async Task<AzureOperationResponse> BeginResizingAsync(string resourceGroupName, string clusterName, int targetInstanceCount,
            CancellationToken cancellationToken)
        {
            var resizeParams = new ClusterResizeParameters { TargetInstanceCount = targetInstanceCount };
            return await BeginResizeWithHttpMessagesAsync(resourceGroupName, clusterName, resizeParams, null, cancellationToken);
        }

        /// <summary>
        /// Executes script actions on specified HDInsight Running cluster.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// Required. The name of the cluster.
        /// </param>
        /// <param name='scriptActions'>
        /// Required. The list of script actions that needs to be executed.
        /// </param>      
        /// <param name='persistOnSuccess'>
        /// Required. Flag indicating if the script needs to be persisted.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The cluster long running operation response.
        /// </returns>
        public async Task<AzureOperationResponse> ExecuteScriptActionsAsync(string resourceGroupName, string clusterName, IList<RuntimeScriptAction> scriptActions,
            bool persistOnSuccess, CancellationToken cancellationToken)
        {
            ExecuteScriptActionParameters executeScriptActionsParams = new ExecuteScriptActionParameters { ScriptActions = scriptActions, PersistOnSuccess = persistOnSuccess };
            return await ExecuteScriptActionsWithHttpMessagesAsync(resourceGroupName, clusterName, executeScriptActionsParams, null, cancellationToken);
        }

        /// <summary>
        /// Begins Executing script actions on specified HDInsight Running cluster
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='clusterName'>
        /// Required. The name of the cluster.
        /// </param>
        /// <param name='scriptActions'>
        /// Required. The list of script actions that needs to be executed.
        /// </param>      
        /// <param name='persistOnSuccess'>
        /// Required. Flag indicating if the script needs to be persisted.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The cluster long running operation response.
        /// </returns>
        public async Task<AzureOperationResponse> BeginExecuteScriptActionsAsync(string resourceGroupName, string clusterName, IList<RuntimeScriptAction> scriptActions,
            bool persistOnSuccess, CancellationToken cancellationToken)
        {
            var executeScriptActionsParams = new ExecuteScriptActionParameters { ScriptActions = scriptActions, PersistOnSuccess = persistOnSuccess };
            return await BeginExecuteScriptActionsWithHttpMessagesAsync(resourceGroupName, clusterName, executeScriptActionsParams, null, cancellationToken);
        }
    }
}
