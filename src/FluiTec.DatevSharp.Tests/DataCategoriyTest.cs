using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests;

[TestClass]
public class DataCategoriyTest
{
    [TestMethod]
    public void CanGetCorrectNumbers()
    {
        Assert.AreEqual(16, DataCategories.Instance.AddressCategory.Number);
        Assert.AreEqual(21, DataCategories.Instance.BookingCategory.Number);
        Assert.AreEqual(46, DataCategories.Instance.TermsOfPaymentCategory.Number);
    }

    [TestMethod]
    public void CanGetCorrectNames()
    {
        Assert.AreEqual("Bookings", DataCategories.Instance.BookingCategory.Name);
        Assert.AreEqual("Addresses", DataCategories.Instance.AddressCategory.Name);
        Assert.AreEqual("TermsOfPayment", DataCategories.Instance.TermsOfPaymentCategory.Name);

        Assert.AreEqual("Buchungsstapel", DataCategories.Instance.BookingCategory.DatevName);
        Assert.AreEqual("Debitoren", DataCategories.Instance.AddressCategory.DatevName);
        Assert.AreEqual("Zahlungsbedingungen", DataCategories.Instance.TermsOfPaymentCategory.DatevName);
    }
}