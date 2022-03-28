using System.Collections.Generic;

namespace FluiTec.DatevSharp.Rows.Maps
{
    /// <summary>
    /// Interface for class map.
    /// </summary>
    public interface IClassMap
    {
        /// <summary>
        /// Gets the members.
        /// </summary>
        ///
        /// <value>
        /// The members.
        /// </value>
        List<MemberOutputMap> Members { get; }

        /// <summary>
        /// Searches for the first ordinal number.
        /// </summary>
        ///
        /// <param name="ordinalNumber">    The ordinal number. </param>
        ///
        /// <returns>
        /// The found ordinal number.
        /// </returns>
        MemberOutputMap FindByOrdinalNumber(int ordinalNumber);
    }
}