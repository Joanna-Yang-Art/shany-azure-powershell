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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Json read settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("JsonReadSettings")]
    public partial class JsonReadSettings : FormatReadSettings
    {
        /// <summary>
        /// Initializes a new instance of the JsonReadSettings class.
        /// </summary>
        public JsonReadSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JsonReadSettings class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="compressionProperties">Compression settings.</param>
        public JsonReadSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), CompressionReadSettings compressionProperties = default(CompressionReadSettings))
            : base(additionalProperties)
        {
            CompressionProperties = compressionProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets compression settings.
        /// </summary>
        [JsonProperty(PropertyName = "compressionProperties")]
        public CompressionReadSettings CompressionProperties { get; set; }

    }
}
