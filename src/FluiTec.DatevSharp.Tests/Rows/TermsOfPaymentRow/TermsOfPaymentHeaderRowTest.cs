using FluiTec.DatevSharp.Rows.TermsOfPaymentRow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Rows.TermsOfPaymentRow;

[TestClass]
public class TermsOfPaymentHeaderRowTest : HeaderRowTest
{
    [TestMethod]
    public void CanConvertToRow()
    {
        foreach (var version in DataCategories.Instance.TermsOfPaymentCategory.Versions)
        {
            var header = new TermsOfPaymentHeaderRow();
            CanGetHeader(version, header);
        }
    }
}