using FluiTec.DatevSharp.Rows.AddressRow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Rows.AddressRow;

[TestClass]
public class AddressHeaderRowTest : HeaderRowTest
{
    [TestMethod]
    public void CanConvertToRow()
    {
        foreach (var version in DataCategories.Instance.AddressCategory.Versions)
        {
            var header = new AddressHeaderRow();
            CanGetHeader(version, header);
        }
    }
}