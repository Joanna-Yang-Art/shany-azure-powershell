// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ValidateOperationOperations operations.
    /// </summary>
    public partial interface IValidateOperationOperations
    {
        /// <summary>
        /// Validate operation for specified backed up item in the form of an asynchronous operation. Returns tracking headers which can be tracked using GetValidateOperationResult API.
        /// </summary>
        /// <remarks>
        /// Validate operation for specified backed up item in the form of an asynchronous operation. Returns tracking headers which can be tracked using GetValidateOperationResult API.
        /// </remarks>
        /// <param name='vaultName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is present.
        /// </param>
        /// <param name='parameters'>
        /// resource validate operation request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> TriggerWithHttpMessagesAsync(string vaultName, string resourceGroupName, ValidateOperationRequest parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Validate operation for specified backed up item in the form of an asynchronous operation. Returns tracking headers which can be tracked using GetValidateOperationResult API.
        /// </summary>
        /// <remarks>
        /// Validate operation for specified backed up item in the form of an asynchronous operation. Returns tracking headers which can be tracked using GetValidateOperationResult API.
        /// </remarks>
        /// <param name='vaultName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is present.
        /// </param>
        /// <param name='parameters'>
        /// resource validate operation request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> BeginTriggerWithHttpMessagesAsync(string vaultName, string resourceGroupName, ValidateOperationRequest parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}