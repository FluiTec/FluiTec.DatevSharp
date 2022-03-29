using System;
using System.Collections.Generic;
using System.Reflection;
using FluentValidation.Internal;
using FluiTec.DatevSharp.Attributes;

namespace FluiTec.DatevSharp.Rows.Maps.Base
{
    /// <summary>
    ///     Map of member outputs.
    /// </summary>
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    public class MemberOutputMap<T> : MemberOutputMap
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="member">       The member. </param>
        /// <param name="datevOutput">  A function delegate that yields a string. </param>
        public MemberOutputMap(MemberInfo member, Func<T, string> datevOutput) : base(member,
            datevOutput.CoerceToNonGeneric())
        {
            GenericDatevOutput = datevOutput;
        }

        /// <summary>
        ///     Gets the datev output.
        /// </summary>
        /// <value>
        ///     A function delegate that yields a string.
        /// </value>
        public Func<T, string> GenericDatevOutput { get; }
    }

    /// <summary>
    ///     Map of member outputs.
    /// </summary>
    public class MemberOutputMap : IMemberOutputMap
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="member">           The member. </param>
        /// <param name="objDatevOutput">   The object datev output. </param>
        public MemberOutputMap(MemberInfo member, Func<object, string> objDatevOutput)
        {
            Member = member;
            FieldAttributes = member.GetCustomAttributes<DatevFieldAttribute>();
            DatevOutput = objDatevOutput;
        }

        /// <summary>
        ///     Gets the member.
        /// </summary>
        /// <value>
        ///     The member.
        /// </value>
        public MemberInfo Member { get; }

        /// <summary>
        ///     Gets the field attributes.
        /// </summary>
        /// <value>
        ///     The field attributes.
        /// </value>
        public IEnumerable<DatevFieldAttribute> FieldAttributes { get; }

        /// <summary>
        ///     Gets the datev output.
        /// </summary>
        /// <value>
        ///     A function delegate that yields a string.
        /// </value>
        public Func<object, string> DatevOutput { get; }
    }
}