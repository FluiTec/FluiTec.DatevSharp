using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FluiTec.DatevSharp.Helpers;

namespace FluiTec.DatevSharp.Rows.Maps
{
    /// <summary>
    /// Map of class.
    /// </summary>
    ///
    /// <typeparam name="T">    Generic type parameter. </typeparam>
    public class ClassMap<T> where T : Interfaces.IDatevRow
    {
        /// <summary>
        /// Gets the members.
        /// </summary>
        ///
        /// <value>
        /// The members.
        /// </value>
        public List<MemberOutputMap<T>> Members { get; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ClassMap()
        {
            Members = new List<MemberOutputMap<T>>();
        }

        /// <summary>
        /// Maps.
        /// </summary>
        ///
        /// <typeparam name="TProperty">    Type of the property. </typeparam>
        /// <param name="expression">   The expression. </param>
        /// <param name="datevOutput">  The datev output. </param>
        protected void Map<TProperty>(Expression<Func<T, TProperty>> expression, Func<T, string> datevOutput)
        {
            var members = ExpressionHelper.GetMembers(expression);
            Members.Add(new MemberOutputMap<T>(members.Pop(), datevOutput));
        }

        /// <summary>
        /// Searches for the first ordinal number.
        /// </summary>
        ///
        /// <param name="ordinalNumber">    The ordinal number. </param>
        ///
        /// <returns>
        /// The found ordinal number.
        /// </returns>
        public MemberOutputMap<T> FindByOrdinalNumber(int ordinalNumber)
        {
            return Members
                .FirstOrDefault(m => m.FieldAttributes
                    .Any(a => a.FieldOrdinalNumber == ordinalNumber));
        }
    }
}