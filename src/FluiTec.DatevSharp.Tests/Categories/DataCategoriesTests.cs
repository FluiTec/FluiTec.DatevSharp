using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Categories;

[TestClass]
public class DataCategoriesTests
{
    [TestMethod]
    public void CanGetInstace()
    {
        var instance = DataCategories.Instance;
        Assert.IsNotNull(instance);
    }

    [TestMethod]
    public void CanGetCategories()
    {
        Assert.IsNotNull(DataCategories.Instance.AddressCategory);
        Assert.IsNotNull(DataCategories.Instance.BookingCategory);
        Assert.IsNotNull(DataCategories.Instance.TermsOfPaymentCategory);
    }
}