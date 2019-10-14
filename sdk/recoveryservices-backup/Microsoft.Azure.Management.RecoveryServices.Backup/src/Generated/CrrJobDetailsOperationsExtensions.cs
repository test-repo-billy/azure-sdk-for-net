// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CrrJobDetailsOperations.
    /// </summary>
    public static partial class CrrJobDetailsOperationsExtensions
    {
            /// <summary>
            /// Get CRR job details from target region.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Azure region to hit Api
            /// </param>
            public static JobResource Get(this ICrrJobDetailsOperations operations, string azureRegion)
            {
                return operations.GetAsync(azureRegion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get CRR job details from target region.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='azureRegion'>
            /// Azure region to hit Api
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobResource> GetAsync(this ICrrJobDetailsOperations operations, string azureRegion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(azureRegion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
