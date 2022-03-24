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
}