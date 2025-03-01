// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Defines the cache expiration action for the delivery rule.</summary>
    public partial class DeliveryRuleCacheExpirationAction :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCacheExpirationAction,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCacheExpirationActionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1 __deliveryRuleAction1 = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.DeliveryRuleAction1();

        /// <summary>Internal Acessors for Parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParameters Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCacheExpirationActionInternal.Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.CacheExpirationActionParameters()); set { {_parameter = value;} } }

        /// <summary>Internal Acessors for ParameterCacheType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCacheExpirationActionInternal.ParameterCacheType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal)Parameter).CacheType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal)Parameter).CacheType = value; }

        /// <summary>Internal Acessors for ParameterTypeName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleCacheExpirationActionInternal.ParameterTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal)Parameter).TypeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal)Parameter).TypeName = value; }

        /// <summary>The name of the action for the delivery rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeliveryRuleAction Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1Internal)__deliveryRuleAction1).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1Internal)__deliveryRuleAction1).Name = value ; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParameters _parameter;

        /// <summary>Defines the parameters for the action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.CacheExpirationActionParameters()); set => this._parameter = value; }

        /// <summary>Caching behavior for the requests</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CacheBehavior ParameterCacheBehavior { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal)Parameter).CacheBehavior; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal)Parameter).CacheBehavior = value ; }

        /// <summary>
        /// The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ParameterCacheDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal)Parameter).CacheDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal)Parameter).CacheDuration = value ?? null; }

        /// <summary>The level at which the content needs to be cached.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ParameterCacheType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal)Parameter).CacheType; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ParameterTypeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParametersInternal)Parameter).TypeName; }

        /// <summary>Creates an new <see cref="DeliveryRuleCacheExpirationAction" /> instance.</summary>
        public DeliveryRuleCacheExpirationAction()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__deliveryRuleAction1), __deliveryRuleAction1);
            await eventListener.AssertObjectIsValid(nameof(__deliveryRuleAction1), __deliveryRuleAction1);
        }
    }
    /// Defines the cache expiration action for the delivery rule.
    public partial interface IDeliveryRuleCacheExpirationAction :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1
    {
        /// <summary>Caching behavior for the requests</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Caching behavior for the requests",
        SerializedName = @"cacheBehavior",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CacheBehavior) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CacheBehavior ParameterCacheBehavior { get; set; }
        /// <summary>
        /// The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss",
        SerializedName = @"cacheDuration",
        PossibleTypes = new [] { typeof(string) })]
        string ParameterCacheDuration { get; set; }
        /// <summary>The level at which the content needs to be cached.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"The level at which the content needs to be cached.",
        SerializedName = @"cacheType",
        PossibleTypes = new [] { typeof(string) })]
        string ParameterCacheType { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"typeName",
        PossibleTypes = new [] { typeof(string) })]
        string ParameterTypeName { get;  }

    }
    /// Defines the cache expiration action for the delivery rule.
    internal partial interface IDeliveryRuleCacheExpirationActionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRuleAction1Internal
    {
        /// <summary>Defines the parameters for the action.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.ICacheExpirationActionParameters Parameter { get; set; }
        /// <summary>Caching behavior for the requests</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CacheBehavior ParameterCacheBehavior { get; set; }
        /// <summary>
        /// The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss
        /// </summary>
        string ParameterCacheDuration { get; set; }
        /// <summary>The level at which the content needs to be cached.</summary>
        string ParameterCacheType { get; set; }

        string ParameterTypeName { get; set; }

    }
}