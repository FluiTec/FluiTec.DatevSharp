using System.Linq;
using System.Text;
using FluiTec.DatevSharp.Interfaces;

namespace FluiTec.DatevSharp.Rows
{
    /// <summary>
    ///     A header row.
    /// </summary>
    public class HeaderRow : IDatevRow, IVersionDatevRow
    {
        /// <summary>
        ///     Converts this object to a row.
        /// </summary>
        /// <param name="version">  The version. </param>
        /// <returns>
        ///     This object as a string.
        /// </returns>
        public string ToRow(DataCategoryVersion version)
        {
            var min = version.FormatDescription.Fields.Min(f => f.OrdinalNumber);
            var max = version.FormatDescription.Fields.Max(f => f.OrdinalNumber);

            var sb = new StringBuilder();
            for (var ordinal = min; ordinal <= max; ordinal++)
            {
                var field = version.FormatDescription.Fields.Single(f => f.OrdinalNumber == ordinal);
                sb.Append((string.IsNullOrWhiteSpace(field.LabelAlias) ? field.Label : field.LabelAlias) + ";");
            }

            return sb.ToString();
        }

        /// <summary>
        ///     Converts this object to a row.
        /// </summary>
        /// <returns>
        ///     This object as a string.
        /// </returns>
        public virtual string ToRow()
        {
            return string.Empty;
        }
    }
}