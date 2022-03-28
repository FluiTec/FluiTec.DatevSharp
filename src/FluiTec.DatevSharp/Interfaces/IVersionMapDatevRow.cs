using FluiTec.DatevSharp.Rows.Maps;

namespace FluiTec.DatevSharp.Interfaces
{
    /// <summary>
    /// Interface for version map datev row.
    /// </summary>
    public interface IVersionMapDatevRow
    {
        /// <summary>
        /// Tow row.
        /// </summary>
        ///
        /// <param name="version">  The version. </param>
        /// <param name="classMap"> The class map. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        string TowRow(DataCategoryVersion version, ClassMap classMap);
    }
}