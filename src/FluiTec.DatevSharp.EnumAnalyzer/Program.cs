using System.Reflection;
using FluiTec.DatevSharp.Helpers;
using FluiTec.DatevSharp.Rows.Enums;

namespace FluiTec.DatevSharp.EnumAnalyzer;

internal class Program
{
    static List<string> enumNames = new();

    private static void Main(string[] args)
    {
        Console.WriteLine("Output to be excepted: NO OUTPUT");
        Console.WriteLine("If any name of an enum appears here - please add Value 'Undefined' as with [StringValue(null)]");
        var categories = new[]
        {
            DataCategories.Instance.AddressCategory,
            DataCategories.Instance.TermsOfPaymentCategory,
            DataCategories.Instance.BookingCategory
        };

        foreach (var cat in categories)
        {
            Console.WriteLine($"Add enums of {cat.Name}");
            DumpEnums(cat);
        }

        foreach (var name in enumNames.Distinct())
            Console.WriteLine(name);

        Console.WriteLine("Done");
    }

    private static void DumpEnums(DataCategory category)
    {
        foreach (var version in category.Versions)
        {
            foreach (var field in version.FormatDescription.Fields.OrderBy(f => f.OrdinalNumber))
            {
                var label = !string.IsNullOrWhiteSpace(field.LabelAlias) ? field.LabelAlias : field.Label;
                var map = category.RowType.GetDatevMetadata().GetMap();
                var memberMap = map.FindByOrdinalNumber(field.OrdinalNumber);
                
                if (memberMap == null) continue;
                if (memberMap.Member.MemberType != MemberTypes.Property) continue;
                var propertyInfo = (PropertyInfo)memberMap.Member;
                var memberType = propertyInfo.PropertyType;
                
                if (memberType.IsEnum && field.Necessary == 0)
                {
                    var values = Enum.GetValues(memberType);
                    var hasUndefined = false;
                    var hasStringValues = false;
                    foreach (var value in values)
                    {
                        var name = Enum.GetName(memberType, value);
                        var sv = EnumHelper.GetStringValue(memberType, name);
                        if (name == "Undefined")
                            hasUndefined = true;
                        else if (sv != null)
                            hasStringValues = true;
                    }

                    if (!hasUndefined && hasStringValues)
                    {
                        enumNames.Add(memberType.FullName!);
                    }
                }
            }
        }
    }
}