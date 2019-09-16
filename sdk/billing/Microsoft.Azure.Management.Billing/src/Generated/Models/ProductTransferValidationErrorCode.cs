// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{

    /// <summary>
    /// Defines values for ProductTransferValidationErrorCode.
    /// </summary>
    public static class ProductTransferValidationErrorCode
    {
        public const string InvalidSource = "InvalidSource";
        public const string ProductNotActive = "ProductNotActive";
        public const string InsufficientPermissionOnSource = "InsufficientPermissionOnSource";
        public const string InsufficientPermissionOnDestination = "InsufficientPermissionOnDestination";
        public const string DestinationBillingProfilePastDue = "DestinationBillingProfilePastDue";
        public const string ProductTypeNotSupported = "ProductTypeNotSupported";
        public const string CrossBillingAccountNotAllowed = "CrossBillingAccountNotAllowed";
        public const string NotAvailableForDestinationMarket = "NotAvailableForDestinationMarket";
        public const string OneTimePurchaseProductTransferNotAllowed = "OneTimePurchaseProductTransferNotAllowed";
    }
}
