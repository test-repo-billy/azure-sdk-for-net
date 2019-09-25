// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReservationsSummariesOperations.
    /// </summary>
    public static partial class ReservationsSummariesOperationsExtensions
    {
            /// <summary>
            /// Lists the reservations summaries for daily or monthly grain.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='grain'>
            /// Can be daily or monthly. Possible values include: 'DailyGrain',
            /// 'MonthlyGrain'
            /// </param>
            /// <param name='filter'>
            /// Required only for daily grain. The properties/UsageDate for start date and
            /// end date. The filter supports 'le' and  'ge'
            /// </param>
            public static IPage<ReservationSummary> ListByReservationOrder(this IReservationsSummariesOperations operations, string reservationOrderId, string grain, string filter = default(string))
            {
                return operations.ListByReservationOrderAsync(reservationOrderId, grain, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the reservations summaries for daily or monthly grain.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='grain'>
            /// Can be daily or monthly. Possible values include: 'DailyGrain',
            /// 'MonthlyGrain'
            /// </param>
            /// <param name='filter'>
            /// Required only for daily grain. The properties/UsageDate for start date and
            /// end date. The filter supports 'le' and  'ge'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReservationSummary>> ListByReservationOrderAsync(this IReservationsSummariesOperations operations, string reservationOrderId, string grain, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReservationOrderWithHttpMessagesAsync(reservationOrderId, grain, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the reservations summaries for daily or monthly grain.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='reservationId'>
            /// Id of the reservation
            /// </param>
            /// <param name='grain'>
            /// Can be daily or monthly. Possible values include: 'DailyGrain',
            /// 'MonthlyGrain'
            /// </param>
            /// <param name='filter'>
            /// Required only for daily grain. The properties/UsageDate for start date and
            /// end date. The filter supports 'le' and  'ge'
            /// </param>
            public static IPage<ReservationSummary> ListByReservationOrderAndReservation(this IReservationsSummariesOperations operations, string reservationOrderId, string reservationId, string grain, string filter = default(string))
            {
                return operations.ListByReservationOrderAndReservationAsync(reservationOrderId, reservationId, grain, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the reservations summaries for daily or monthly grain.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='reservationOrderId'>
            /// Order Id of the reservation
            /// </param>
            /// <param name='reservationId'>
            /// Id of the reservation
            /// </param>
            /// <param name='grain'>
            /// Can be daily or monthly. Possible values include: 'DailyGrain',
            /// 'MonthlyGrain'
            /// </param>
            /// <param name='filter'>
            /// Required only for daily grain. The properties/UsageDate for start date and
            /// end date. The filter supports 'le' and  'ge'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReservationSummary>> ListByReservationOrderAndReservationAsync(this IReservationsSummariesOperations operations, string reservationOrderId, string reservationId, string grain, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReservationOrderAndReservationWithHttpMessagesAsync(reservationOrderId, reservationId, grain, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the reservations summaries for daily or monthly grain.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// BillingAccount ID
            /// </param>
            /// <param name='grain'>
            /// Can be daily or monthly. Possible values include: 'DailyGrain',
            /// 'MonthlyGrain'
            /// </param>
            /// <param name='filter'>
            /// Required only for daily grain. The properties/UsageDate for start date and
            /// end date. The filter supports 'le' and  'ge'
            /// </param>
            public static IPage<ReservationSummary> ListByBillingAccountId(this IReservationsSummariesOperations operations, string billingAccountId, string grain, string filter = default(string))
            {
                return operations.ListByBillingAccountIdAsync(billingAccountId, grain, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the reservations summaries for daily or monthly grain.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// BillingAccount ID
            /// </param>
            /// <param name='grain'>
            /// Can be daily or monthly. Possible values include: 'DailyGrain',
            /// 'MonthlyGrain'
            /// </param>
            /// <param name='filter'>
            /// Required only for daily grain. The properties/UsageDate for start date and
            /// end date. The filter supports 'le' and  'ge'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ReservationSummary>> ListByBillingAccountIdAsync(this IReservationsSummariesOperations operations, string billingAccountId, string grain, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountIdWithHttpMessagesAsync(billingAccountId, grain, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the reservations summaries for daily or monthly grain.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReservationSummary> ListByReservationOrderNext(this IReservationsSummariesOperations operations, string nextPageLink)
            {
                return operations.ListByReservationOrderNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the reservations summaries for daily or monthly grain.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
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
            public static async Task<IPage<ReservationSummary>> ListByReservationOrderNextAsync(this IReservationsSummariesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReservationOrderNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the reservations summaries for daily or monthly grain.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReservationSummary> ListByReservationOrderAndReservationNext(this IReservationsSummariesOperations operations, string nextPageLink)
            {
                return operations.ListByReservationOrderAndReservationNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the reservations summaries for daily or monthly grain.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
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
            public static async Task<IPage<ReservationSummary>> ListByReservationOrderAndReservationNextAsync(this IReservationsSummariesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReservationOrderAndReservationNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the reservations summaries for daily or monthly grain.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ReservationSummary> ListByBillingAccountIdNext(this IReservationsSummariesOperations operations, string nextPageLink)
            {
                return operations.ListByBillingAccountIdNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the reservations summaries for daily or monthly grain.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
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
            public static async Task<IPage<ReservationSummary>> ListByBillingAccountIdNextAsync(this IReservationsSummariesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountIdNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
