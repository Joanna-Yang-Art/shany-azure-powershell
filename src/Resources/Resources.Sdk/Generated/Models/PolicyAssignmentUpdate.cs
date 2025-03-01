// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Resources.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PolicyAssignmentUpdate
    {
        /// <summary>
        /// Initializes a new instance of the PolicyAssignmentUpdate class.
        /// </summary>
        public PolicyAssignmentUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyAssignmentUpdate class.
        /// </summary>
        /// <param name="location">The location of the policy assignment. Only
        /// required when utilizing managed identity.</param>
        /// <param name="identity">The managed identity associated with the
        /// policy assignment.</param>
        public PolicyAssignmentUpdate(string location = default(string), Identity identity = default(Identity))
        {
            Location = location;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the policy assignment. Only required
        /// when utilizing managed identity.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the managed identity associated with the policy
        /// assignment.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

    }
}
