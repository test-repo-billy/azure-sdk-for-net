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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ChargesOperations operations.
    /// </summary>
    public partial interface IChargesOperations
    {
        /// <summary>
        /// Lists the charges based for the defined scope.
        /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
        /// </summary>
        /// <param name='scope'>
        /// The scope associated with charges operations. This includes
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
        /// for Department scope, and
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
        /// for EnrollmentAccount scope. For department and enrollment
        /// accounts, you can also add billing period to the scope using
        /// '/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'.
        /// For e.g. to specify billing period at department scope use
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}'.
        /// Also, Modern Commerce Account scopes are
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}'
        /// for billingAccount scope,
        /// '/providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
        /// for billingProfile scope,
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}'
        /// for invoiceSection scope, and
        /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/customers/{customerId}'
        /// specific for partners.
        /// </param>
        /// <param name='startDate'>
        /// Start date
        /// </param>
        /// <param name='endDate'>
        /// End date
        /// </param>
        /// <param name='filter'>
        /// May be used to filter charges by properties/usageEnd (Utc time),
        /// properties/usageStart (Utc time). The filter supports 'eq', 'lt',
        /// 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne',
        /// 'or', or 'not'. Tag filter is a key value pair string where key and
        /// value is separated by a colon (:).
        /// </param>
        /// <param name='apply'>
        /// May be used to group charges for billingAccount scope by
        /// properties/billingProfileId, properties/invoiceSectionId,
        /// properties/customerId (specific for Partner Led), or for
        /// billingProfile scope by properties/invoiceSectionId.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ChargesListResult>> ListByScopeWithHttpMessagesAsync(string scope, string startDate = default(string), string endDate = default(string), string filter = default(string), string apply = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
