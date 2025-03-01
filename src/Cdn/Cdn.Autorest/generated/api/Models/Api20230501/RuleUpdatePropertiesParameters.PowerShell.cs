// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>The JSON object that contains the properties of the rule to update.</summary>
    [System.ComponentModel.TypeConverter(typeof(RuleUpdatePropertiesParametersTypeConverter))]
    public partial class RuleUpdatePropertiesParameters
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.RuleUpdatePropertiesParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RuleUpdatePropertiesParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.RuleUpdatePropertiesParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParameters" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RuleUpdatePropertiesParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RuleUpdatePropertiesParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RuleUpdatePropertiesParameters" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.RuleUpdatePropertiesParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RuleUpdatePropertiesParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RuleSetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).RuleSetName = (string) content.GetValueForProperty("RuleSetName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).RuleSetName, global::System.Convert.ToString);
            }
            if (content.Contains("Order"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).Order = (int?) content.GetValueForProperty("Order",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).Order, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Condition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).Condition = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCondition[]) content.GetValueForProperty("Condition",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).Condition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCondition>(__y, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.DeliveryRuleConditionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Action"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).Action = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1[]) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).Action, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1>(__y, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.DeliveryRuleAction1TypeConverter.ConvertFrom));
            }
            if (content.Contains("MatchProcessingBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).MatchProcessingBehavior = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior?) content.GetValueForProperty("MatchProcessingBehavior",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).MatchProcessingBehavior, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.RuleUpdatePropertiesParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RuleUpdatePropertiesParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RuleSetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).RuleSetName = (string) content.GetValueForProperty("RuleSetName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).RuleSetName, global::System.Convert.ToString);
            }
            if (content.Contains("Order"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).Order = (int?) content.GetValueForProperty("Order",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).Order, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Condition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).Condition = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCondition[]) content.GetValueForProperty("Condition",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).Condition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCondition>(__y, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.DeliveryRuleConditionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Action"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).Action = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1[]) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).Action, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1>(__y, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.DeliveryRuleAction1TypeConverter.ConvertFrom));
            }
            if (content.Contains("MatchProcessingBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).MatchProcessingBehavior = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior?) content.GetValueForProperty("MatchProcessingBehavior",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IRuleUpdatePropertiesParametersInternal)this).MatchProcessingBehavior, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The JSON object that contains the properties of the rule to update.
    [System.ComponentModel.TypeConverter(typeof(RuleUpdatePropertiesParametersTypeConverter))]
    public partial interface IRuleUpdatePropertiesParameters

    {

    }
}