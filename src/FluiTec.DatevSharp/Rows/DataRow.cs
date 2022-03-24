using System.Text;

namespace FluiTec.DatevSharp.Rows
{
    /// <summary>
    /// A data row.
    /// </summary>
    public abstract class DataRow : Interfaces.IDatevRow, Interfaces.IVersionDatevRow
    {
        /// <summary>
        /// Converts this object to a row.
        /// </summary>
        ///
        /// <returns>
        /// This object as a string.
        /// </returns>
        public abstract string ToRow();

        public string ToRow(DataCategoryVersion version)
        {
            var sb = new StringBuilder();
            return sb.ToString();
        }
    }
}