// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support
{

    /// <summary>
    /// The mode of the connected registry resource that indicates the permissions of the registry.
    /// </summary>
    public partial struct ConnectedRegistryMode :
        System.IEquatable<ConnectedRegistryMode>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectedRegistryMode Mirror = @"Mirror";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectedRegistryMode ReadOnly = @"ReadOnly";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectedRegistryMode ReadWrite = @"ReadWrite";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectedRegistryMode Registry = @"Registry";

        /// <summary>the value for an instance of the <see cref="ConnectedRegistryMode" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ConnectedRegistryMode"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ConnectedRegistryMode(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ConnectedRegistryMode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ConnectedRegistryMode" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ConnectedRegistryMode(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ConnectedRegistryMode</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectedRegistryMode e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ConnectedRegistryMode (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ConnectedRegistryMode && Equals((ConnectedRegistryMode)obj);
        }

        /// <summary>Returns hashCode for enum ConnectedRegistryMode</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ConnectedRegistryMode</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ConnectedRegistryMode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ConnectedRegistryMode" />.</param>

        public static implicit operator ConnectedRegistryMode(string value)
        {
            return new ConnectedRegistryMode(value);
        }

        /// <summary>Implicit operator to convert ConnectedRegistryMode to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ConnectedRegistryMode" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectedRegistryMode e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ConnectedRegistryMode</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectedRegistryMode e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectedRegistryMode e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ConnectedRegistryMode</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectedRegistryMode e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectedRegistryMode e2)
        {
            return e2.Equals(e1);
        }
    }
}