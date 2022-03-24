namespace FluiTec.DatevSharp.Interfaces
{
    /// <summary>
    /// Interface for version datev row.
    /// </summary>
    public interface IVersionDatevRow
    {
        /// <summary>
        /// Converts a version to a row.
        /// </summary>
        ///
        /// <param name="version">  The version. </param>
        ///
        /// <returns>
        /// Version as a string.
        /// </returns>
        string ToRow(DataCategoryVersion version);
    }
}