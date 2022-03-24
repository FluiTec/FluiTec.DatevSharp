using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests;

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
    public void CanGetCorrectNumbers()
    {
        Assert.AreEqual(21, DataCategories.BookingCategory.Number);
        Assert.AreEqual(16, DataCategories.AddressCategory.Number);
        Assert.AreEqual(46, DataCategories.TermsOfPaymentCategory.Number);
    }

    [TestMethod]
    public void CanGetCorrectNames()
    {
        Assert.AreEqual("Bookings", DataCategories.BookingCategory.Name);
        Assert.AreEqual("Addresses", DataCategories.AddressCategory.Name);
        Assert.AreEqual("TermsOfPayment", DataCategories.TermsOfPaymentCategory.Name);

        Assert.AreEqual("Buchungsstapel", DataCategories.BookingCategory.DatevName);
        Assert.AreEqual("Debitoren", DataCategories.AddressCategory.DatevName);
        Assert.AreEqual("Zahlungsbedingungen", DataCategories.TermsOfPaymentCategory.DatevName);
    }
}