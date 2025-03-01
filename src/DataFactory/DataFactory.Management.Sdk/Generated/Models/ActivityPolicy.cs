// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Execution policy for an activity.
    /// </summary>
    public partial class ActivityPolicy
    {
        /// <summary>
        /// Initializes a new instance of the ActivityPolicy class.
        /// </summary>
        public ActivityPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityPolicy class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="timeout">Specifies the timeout for the activity to
        /// run. The default timeout is 7 days. Type: string (or Expression
        /// with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="retry">Maximum ordinary retry attempts. Default is 0.
        /// Type: integer (or Expression with resultType integer), minimum:
        /// 0.</param>
        /// <param name="retryIntervalInSeconds">Interval between each retry
        /// attempt (in seconds). The default is 30 sec.</param>
        /// <param name="secureInput">When set to true, Input from activity is
        /// considered as secure and will not be logged to monitoring.</param>
        /// <param name="secureOutput">When set to true, Output from activity
        /// is considered as secure and will not be logged to
        /// monitoring.</param>
        public ActivityPolicy(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object timeout = default(object), object retry = default(object), int? retryIntervalInSeconds = default(int?), bool? secureInput = default(bool?), bool? secureOutput = default(bool?))
        {
            AdditionalProperties = additionalProperties;
            Timeout = timeout;
            Retry = retry;
            RetryIntervalInSeconds = retryIntervalInSeconds;
            SecureInput = secureInput;
            SecureOutput = secureOutput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets specifies the timeout for the activity to run. The
        /// default timeout is 7 days. Type: string (or Expression with
        /// resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public object Timeout { get; set; }

        /// <summary>
        /// Gets or sets maximum ordinary retry attempts. Default is 0. Type:
        /// integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "retry")]
        public object Retry { get; set; }

        /// <summary>
        /// Gets or sets interval between each retry attempt (in seconds). The
        /// default is 30 sec.
        /// </summary>
        [JsonProperty(PropertyName = "retryIntervalInSeconds")]
        public int? RetryIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets when set to true, Input from activity is considered as
        /// secure and will not be logged to monitoring.
        /// </summary>
        [JsonProperty(PropertyName = "secureInput")]
        public bool? SecureInput { get; set; }

        /// <summary>
        /// Gets or sets when set to true, Output from activity is considered
        /// as secure and will not be logged to monitoring.
        /// </summary>
        [JsonProperty(PropertyName = "secureOutput")]
        public bool? SecureOutput { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RetryIntervalInSeconds != null)
            {
                if (RetryIntervalInSeconds > 86400)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "RetryIntervalInSeconds", 86400);
                }
                if (RetryIntervalInSeconds < 30)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "RetryIntervalInSeconds", 30);
                }
            }
        }
    }
}
