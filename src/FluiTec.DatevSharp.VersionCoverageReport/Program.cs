using System.Text;
using FluiTec.DatevSharp.Helpers;

namespace FluiTec.DatevSharp.VersionCoverageReport;

/// <summary>
/// A program.
/// </summary>
internal class Program
{
    /// <summary>
    /// Main entry-point for this application.
    /// </summary>
    private static void Main()
    {
        var categories = new[]
        {
            DataCategories.Instance.AddressCategory, 
            DataCategories.Instance.TermsOfPaymentCategory,
            DataCategories.Instance.BookingCategory
        };

        foreach(var cat in categories)
            CreateCategoryReport(cat);
    }

    /// <summary>
    /// Creates category report.
    /// </summary>
    ///
    /// <param name="category"> The category. </param>
    private static void CreateCategoryReport(DataCategory category)
    {
        var folder = "..\\..\\..\\Reports\\";
        var fileName = $"{category.Name}-CoverageReport.htm";

        var content = GetCategoryReport(category);
        File.WriteAllText(Path.Combine(folder, fileName), content, System.Text.Encoding.Default);
    }

    private static string GetCategoryReport(DataCategory category)
    {
        var sb = new StringBuilder();
        
        // heading
        sb.AppendLine($"<h1>{category.Name}</h1>");
        sb.AppendLine($"<h2>{category.DatevName}</h2>");

        foreach (var version in category.Versions)
        {
            sb.AppendLine($"<h3>V: {version.Version} | DV: {version.DatevVersion} | {version.File}</h3>");
            sb.AppendLine("<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>");
            sb.AppendLine("\t<tr>");
            sb.AppendLine("\t\t<td><b>DatevLabel</b></td>");
            sb.AppendLine("\t\t<td><b>OrdinalNumber</b></td>");
            sb.AppendLine("\t\t<td><b>Mapped</b></td>");
            sb.AppendLine("\t\t<td><b>Property</b></td>");

            foreach (var field in version.FormatDescription.Fields.OrderBy(f => f.OrdinalNumber))
            {
                var label = !string.IsNullOrWhiteSpace(field.LabelAlias) ? field.LabelAlias : field.Label;
                var map = category.RowType.GetDatevMetadata().GetMap();
                var memberMap = map.FindByOrdinalNumber(field.OrdinalNumber);

                sb.AppendLine("\t<tr>");
                sb.AppendLine($"\t\t<td>{label}</td>");
                sb.AppendLine($"\t\t<td>{field.OrdinalNumber}</td>");
                sb.AppendLine($"\t\t<td>{memberMap != null}</td>");
                sb.AppendLine($"\t\t<td>{memberMap?.Member.Name}</td>");
                sb.AppendLine("\t</tr>");
            }

            sb.AppendLine("\t</tr>");
            sb.AppendLine("</table>");
        }

        return sb.ToString();
    }
}