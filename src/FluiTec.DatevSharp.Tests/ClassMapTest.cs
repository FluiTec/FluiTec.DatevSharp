using System.Linq;
using System.Text;
using FluiTec.DatevSharp.Rows.AddressRow;
using FluiTec.DatevSharp.Rows.Enums;
using FluiTec.DatevSharp.Rows.Maps;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests;

[TestClass]
public class ClassMapTest
{
    [TestMethod]
    public void Test()
    {
        var row = new AddressRow
        {
            AccountNumber = 10001,
            Name_Enterprise = "Möbel Mustermann",
            Name_Enterprise_Extension = "Schreinerei",
            AddressType = AddressType.Enterprise,
            ShortName = "mustermann möb",
            Salutation = "Firma",
            PostalAddressType = "STR",
            Street = "Teststraße 1",
            ZipCode = "11111",
            City = "Teststadt"
        };

        var map = new AddressMap();

        var version = DataCategories.Instance.AddressCategory.DefaultVersion;
        var sb = new StringBuilder();
        foreach (var field in version.FormatDescription.Fields.OrderBy(f => f.OrdinalNumber))
        {
            var memberMap = map.FindByOrdinalNumber(field.OrdinalNumber);
            sb.Append(memberMap != null ? $"{memberMap.DatevOutput(row)};" : field.FormatType == "Text" ? "\"\";" : ";");
        }
        
        var result = sb.ToString(0, sb.Length-1);
    }
}