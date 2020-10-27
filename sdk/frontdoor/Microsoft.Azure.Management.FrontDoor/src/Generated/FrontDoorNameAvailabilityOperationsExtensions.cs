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
    /// Extension methods for FrontDoorNameAvailabilityOperations.
    /// </summary>
    public static partial class FrontDoorNameAvailabilityOperationsExtensions
    {
            /// <summary>
            /// Check the availability of a Front Door resource name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='checkFrontDoorNameAvailabilityInput'>
            /// Input to check.
            /// </param>
            public static CheckNameAvailabilityOutput Check(this IFrontDoorNameAvailabilityOperations operations, CheckNameAvailabilityInput checkFrontDoorNameAvailabilityInput)
            {
                return operations.CheckAsync(checkFrontDoorNameAvailabilityInput).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check the availability of a Front Door resource name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='checkFrontDoorNameAvailabilityInput'>
            /// Input to check.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityOutput> CheckAsync(this IFrontDoorNameAvailabilityOperations operations, CheckNameAvailabilityInput checkFrontDoorNameAvailabilityInput, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckWithHttpMessagesAsync(checkFrontDoorNameAvailabilityInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
