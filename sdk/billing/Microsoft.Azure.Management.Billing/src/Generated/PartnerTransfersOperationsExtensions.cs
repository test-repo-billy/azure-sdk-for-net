// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PartnerTransfersOperations.
    /// </summary>
    public static partial class PartnerTransfersOperationsExtensions
    {
            /// <summary>
            /// Initiates the request to transfer the legacy subscriptions or RIs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='customerName'>
            /// Customer name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to initiate the transfer.
            /// </param>
            public static TransferDetails Initiate(this IPartnerTransfersOperations operations, string billingAccountName, string customerName, InitiateTransferRequest parameters)
            {
                return operations.InitiateAsync(billingAccountName, customerName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Initiates the request to transfer the legacy subscriptions or RIs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='customerName'>
            /// Customer name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to initiate the transfer.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransferDetails> InitiateAsync(this IPartnerTransfersOperations operations, string billingAccountName, string customerName, InitiateTransferRequest parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.InitiateWithHttpMessagesAsync(billingAccountName, customerName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the transfer details for given transfer Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='customerName'>
            /// Customer name.
            /// </param>
            /// <param name='transferName'>
            /// Transfer Name.
            /// </param>
            public static TransferDetails Get(this IPartnerTransfersOperations operations, string billingAccountName, string customerName, string transferName)
            {
                return operations.GetAsync(billingAccountName, customerName, transferName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the transfer details for given transfer Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='customerName'>
            /// Customer name.
            /// </param>
            /// <param name='transferName'>
            /// Transfer Name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransferDetails> GetAsync(this IPartnerTransfersOperations operations, string billingAccountName, string customerName, string transferName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, customerName, transferName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels the transfer for given transfer Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='customerName'>
            /// Customer name.
            /// </param>
            /// <param name='transferName'>
            /// Transfer Name.
            /// </param>
            public static TransferDetails Cancel(this IPartnerTransfersOperations operations, string billingAccountName, string customerName, string transferName)
            {
                return operations.CancelAsync(billingAccountName, customerName, transferName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels the transfer for given transfer Id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='customerName'>
            /// Customer name.
            /// </param>
            /// <param name='transferName'>
            /// Transfer Name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransferDetails> CancelAsync(this IPartnerTransfersOperations operations, string billingAccountName, string customerName, string transferName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelWithHttpMessagesAsync(billingAccountName, customerName, transferName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
