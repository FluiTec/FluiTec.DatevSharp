using System;
using System.Collections.Generic;
using System.Reflection;
using FluiTec.DatevSharp.Attributes;

namespace FluiTec.DatevSharp.Rows.Maps
{
    /// <summary>
    /// Map of member outputs.
    /// </summary>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    public class MemberOutputMap<T>
    {
        /// <summary>
        /// Gets the member.
        /// </summary>
        ///
        /// <value>
        /// The member.
        /// </value>
        public MemberInfo Member { get; }

        /// <summary>
        /// Gets the field attributes.
        /// </summary>
        ///
        /// <value>
        /// The field attributes.
        /// </value>
        public IEnumerable<DatevFieldAttribute> FieldAttributes { get; }

        /// <summary>
        /// Gets the datev output.
        /// </summary>
        ///
        /// <value>
        /// A function delegate that yields a string.
        /// </value>
        public Func<T, string> DatevOutput { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        ///
        /// <param name="member">       The member. </param>
        /// <param name="datevOutput">  A function delegate that yields a string. </param>
        public MemberOutputMap(MemberInfo member, Func<T, string> datevOutput)
        {
            Member = member;
            FieldAttributes = member.GetCustomAttributes<DatevFieldAttribute>();
            DatevOutput = datevOutput;
        }
    }
}