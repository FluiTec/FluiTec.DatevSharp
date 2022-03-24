using FluiTec.DatevSharp.Rows.BookingRow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Rows.BookingRow;

[TestClass]
public class BookingHeaderRowTest : HeaderRowTest
{
    [TestMethod]
    public void CanConvertToRow()
    {
        foreach (var version in DataCategories.Instance.BookingCategory.Versions)
        {
            var header = new BookingHeaderRow();
            CanGetHeader(version, header);
        }
    }
}