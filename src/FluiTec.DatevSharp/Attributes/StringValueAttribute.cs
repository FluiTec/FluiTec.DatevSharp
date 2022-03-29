using System;

namespace FluiTec.DatevSharp.Attributes
{
    /// <summary>
    ///     Attribute for string value. This class cannot be inherited.
    /// </summary>
    public sealed class StringValueAttribute : Attribute
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="value">    The value. </param>
        public StringValueAttribute(string value)
        {
            Value = value;
        }

        /// <summary>
        ///     Gets the value.
        /// </summary>
        /// <value>
        ///     The value.
        /// </value>
        public string Value { get; }
    }
}