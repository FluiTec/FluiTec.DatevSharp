using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests;

[TestClass]
public class DataCategoryVersionTest
{
    [TestMethod]
    public void CanGetFiles()
    {
        CanGetFilesOfCategory(DataCategories.Instance.AddressCategory);
        CanGetFilesOfCategory(DataCategories.Instance.BookingCategory);
        CanGetFilesOfCategory(DataCategories.Instance.TermsOfPaymentCategory);
    }

    private void CanGetFilesOfCategory(DataCategory category)
    {
        foreach(var version in category.Versions)
            Assert.IsNotNull(version.Format);
    }
}