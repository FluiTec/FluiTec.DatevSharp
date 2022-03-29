using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FluiTec.DatevSharp.Helpers;

namespace FluiTec.DatevSharp.Rows.Maps.Base
{
    /// <summary>
    ///     Map of class.
    /// </summary>
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    public class ClassMap<T> : ClassMap
    {
        /// <summary>
        ///     Default constructor.
        /// </summary>
        public ClassMap()
        {
            GenericMembers = new List<MemberOutputMap<T>>();
        }

        /// <summary>
        ///     Gets the members.
        /// </summary>
        /// <value>
        ///     The members.
        /// </value>
        public List<MemberOutputMap<T>> GenericMembers { get; }

        /// <summary>
        ///     Maps.
        /// </summary>
        /// <typeparam name="TProperty">    Type of the property. </typeparam>
        /// <param name="expression">   The expression. </param>
        /// <param name="datevOutput">  The datev output. </param>
        protected void Map<TProperty>(Expression<Func<T, TProperty>> expression, Func<T, string> datevOutput)
        {
            var members = ExpressionHelper.GetMembers(expression);
            var member = new MemberOutputMap<T>(members.Pop(), datevOutput);

            Members.Add(member);
            GenericMembers.Add(member);
        }

        /// <summary>
        ///     Searches for the first ordinal number.
        /// </summary>
        /// <param name="ordinalNumber">    The ordinal number. </param>
        /// <returns>
        ///     The found ordinal number.
        /// </returns>
        public MemberOutputMap<T> FindGenericByOrdinalNumber(int ordinalNumber)
        {
            return GenericMembers
                .FirstOrDefault(m => m.FieldAttributes
                    .Any(a => a.FieldOrdinalNumber == ordinalNumber));
        }
    }

    /// <summary>
    ///     Map of class.
    /// </summary>
    public abstract class ClassMap : IClassMap
    {
        /// <summary>
        ///     Specialized default constructor for use only by derived class.
        /// </summary>
        protected ClassMap()
        {
            Members = new List<MemberOutputMap>();
        }

        /// <summary>
        ///     Gets the members.
        /// </summary>
        /// <value>
        ///     The members.
        /// </value>
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public List<MemberOutputMap> Members { get; }

        /// <summary>
        ///     Searches for the first ordinal number.
        /// </summary>
        /// <param name="ordinalNumber">    The ordinal number. </param>
        /// <returns>
        ///     The found ordinal number.
        /// </returns>
        public MemberOutputMap FindByOrdinalNumber(int ordinalNumber)
        {
            return Members
                .FirstOrDefault(m => m.FieldAttributes
                    .Any(a => a.FieldOrdinalNumber == ordinalNumber));
        }
    }
}