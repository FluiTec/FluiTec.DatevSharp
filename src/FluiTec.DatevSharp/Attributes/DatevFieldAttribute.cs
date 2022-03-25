using System;

namespace FluiTec.DatevSharp.Attributes
{
    /// <summary>
    /// A datev field.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DatevFieldAttribute : Attribute
    {
        /// <summary>
        /// Gets the field number. (base: 1)
        /// </summary>
        ///
        /// <value>
        /// The field number. (base: 1)
        /// </value>
        public int FieldOrdinalNumber { get; }

        /// <summary>
        /// Gets the valid from version.
        /// </summary>
        ///
        /// <value>
        /// The valid from version.
        /// </value>
        public int ValidFromVersion { get; }

        /// <summary>
        /// Gets the valid till version.
        /// </summary>
        ///
        /// <value>
        /// The valid till version.
        /// </value>
        public int? ValidTillVersion { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        ///
        /// <param name="fieldOrdinalNumber">   The field number. </param>
        /// <param name="validFromVersion">     The valid from version. </param>
        public DatevFieldAttribute(int fieldOrdinalNumber, int validFromVersion) : this(fieldOrdinalNumber, validFromVersion,
            null)
        {

        }

        /// <summary>
        /// Constructor.
        /// </summary>
        ///
        /// <param name="fieldOrdinalNumber">   The field number. </param>
        /// <param name="validFromVersion">     The valid from version. </param>
        /// <param name="validTillVersion">     The valid till version. </param>
        public DatevFieldAttribute(int fieldOrdinalNumber, int validFromVersion, int? validTillVersion)
        {
            FieldOrdinalNumber = fieldOrdinalNumber;
            ValidFromVersion = validFromVersion;
            ValidTillVersion = validTillVersion;
        }
    }
}