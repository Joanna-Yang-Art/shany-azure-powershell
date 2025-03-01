// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The response model for the undo edit runbook operation.
    /// </summary>
    public partial class RunbookDraftUndoEditResult
    {
        /// <summary>
        /// Initializes a new instance of the RunbookDraftUndoEditResult class.
        /// </summary>
        public RunbookDraftUndoEditResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunbookDraftUndoEditResult class.
        /// </summary>

        /// <param name="statusCode">
        /// Possible values include: 'Continue', 'SwitchingProtocols', 'OK', 'Created',
        /// 'Accepted', 'NonAuthoritativeInformation', 'NoContent', 'ResetContent',
        /// 'PartialContent', 'MultipleChoices', 'Ambiguous', 'MovedPermanently',
        /// 'Moved', 'Found', 'Redirect', 'SeeOther', 'RedirectMethod', 'NotModified',
        /// 'UseProxy', 'Unused', 'TemporaryRedirect', 'RedirectKeepVerb',
        /// 'BadRequest', 'Unauthorized', 'PaymentRequired', 'Forbidden', 'NotFound',
        /// 'MethodNotAllowed', 'NotAcceptable', 'ProxyAuthenticationRequired',
        /// 'RequestTimeout', 'Conflict', 'Gone', 'LengthRequired',
        /// 'PreconditionFailed', 'RequestEntityTooLarge', 'RequestUriTooLong',
        /// 'UnsupportedMediaType', 'RequestedRangeNotSatisfiable',
        /// 'ExpectationFailed', 'UpgradeRequired', 'InternalServerError',
        /// 'NotImplemented', 'BadGateway', 'ServiceUnavailable', 'GatewayTimeout',
        /// 'HttpVersionNotSupported'</param>

        /// <param name="requestId">
        /// </param>
        public RunbookDraftUndoEditResult(string statusCode = default(string), string requestId = default(string))

        {
            this.StatusCode = statusCode;
            this.RequestId = requestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets Possible values include: &#39;Continue&#39;, &#39;SwitchingProtocols&#39;, &#39;OK&#39;, &#39;Created&#39;, &#39;Accepted&#39;, &#39;NonAuthoritativeInformation&#39;, &#39;NoContent&#39;, &#39;ResetContent&#39;, &#39;PartialContent&#39;, &#39;MultipleChoices&#39;, &#39;Ambiguous&#39;, &#39;MovedPermanently&#39;, &#39;Moved&#39;, &#39;Found&#39;, &#39;Redirect&#39;, &#39;SeeOther&#39;, &#39;RedirectMethod&#39;, &#39;NotModified&#39;, &#39;UseProxy&#39;, &#39;Unused&#39;, &#39;TemporaryRedirect&#39;, &#39;RedirectKeepVerb&#39;, &#39;BadRequest&#39;, &#39;Unauthorized&#39;, &#39;PaymentRequired&#39;, &#39;Forbidden&#39;, &#39;NotFound&#39;, &#39;MethodNotAllowed&#39;, &#39;NotAcceptable&#39;, &#39;ProxyAuthenticationRequired&#39;, &#39;RequestTimeout&#39;, &#39;Conflict&#39;, &#39;Gone&#39;, &#39;LengthRequired&#39;, &#39;PreconditionFailed&#39;, &#39;RequestEntityTooLarge&#39;, &#39;RequestUriTooLong&#39;, &#39;UnsupportedMediaType&#39;, &#39;RequestedRangeNotSatisfiable&#39;, &#39;ExpectationFailed&#39;, &#39;UpgradeRequired&#39;, &#39;InternalServerError&#39;, &#39;NotImplemented&#39;, &#39;BadGateway&#39;, &#39;ServiceUnavailable&#39;, &#39;GatewayTimeout&#39;, &#39;HttpVersionNotSupported&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "statusCode")]
        public string StatusCode {get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "requestId")]
        public string RequestId {get; set; }
    }
}