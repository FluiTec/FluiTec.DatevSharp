using System;
using System.Collections.Generic;

namespace FluiTec.DatevSharp.Attributes
{
    /// <summary>
    /// A datev field.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DatevField : Attribute
    {
        /// <summary>
        /// Gets the field number. (base: 1)
        /// </summary>
        ///
        /// <value>
        /// The field number. (base: 1)
        /// </value>
        public int FieldNumber { get; }

        /// <summary>
        /// Gets the valid versions.
        /// </summary>
        ///
        /// <value>
        /// The valid versions.
        /// </value>
        public IEnumerable<int> ValidVersions { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        ///
        /// <param name="fieldNumber">      The field number. (base: 1) </param>
        /// <param name="validVersions">    The valid versions. </param>
        // ReSharper disable ParameterTypeCanBeEnumerable.Local
        public DatevField(int fieldNumber, int[] validVersions)
        // ReSharper restore ParameterTypeCanBeEnumerable.Local
        {
            FieldNumber = fieldNumber;
            ValidVersions = validVersions;
        }
    }
}