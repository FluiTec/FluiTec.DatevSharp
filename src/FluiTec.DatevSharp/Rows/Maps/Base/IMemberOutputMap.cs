using System;
using System.Collections.Generic;
using System.Reflection;
using FluiTec.DatevSharp.Attributes;

namespace FluiTec.DatevSharp.Rows.Maps.Base
{
    /// <summary>
    /// Interface for member output map.
    /// </summary>
    public interface IMemberOutputMap
    {
        /// <summary>
        /// Gets the member.
        /// </summary>
        ///
        /// <value>
        /// The member.
        /// </value>
        MemberInfo Member { get; }

        /// <summary>
        /// Gets the field attributes.
        /// </summary>
        ///
        /// <value>
        /// The field attributes.
        /// </value>
        IEnumerable<DatevFieldAttribute> FieldAttributes { get; }

        /// <summary>
        /// Gets the datev output.
        /// </summary>
        ///
        /// <value>
        /// A function delegate that yields a string.
        /// </value>
        Func<object, string> DatevOutput { get; }
    }
}