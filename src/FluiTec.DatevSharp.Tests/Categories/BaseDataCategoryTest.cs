using System;
using FluiTec.DatevSharp.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Categories;

public abstract class BaseDataCategoryTest
{
    protected BaseDataCategoryTest(string name, string datevName, Type rowType)
    {
        Name = name;
        DatevName = datevName;
        RowType = rowType;
    }

    public string Name { get; }

    public string DatevName { get; }

    public Type RowType { get; }

    protected abstract DataCategory GetCategory();

    [TestMethod]
    public void CanGetCorrectName()
    {
        Assert.AreEqual(Name, GetCategory().Name);
    }

    [TestMethod]
    public void CanGetCorrectDatevName()
    {
        Assert.AreEqual(DatevName, GetCategory().DatevName);
    }

    [TestMethod]
    public void CanGetCorrectRowType()
    {
        Assert.AreEqual(RowType, GetCategory().RowType);
    }

    [TestMethod]
    public void CanGetMetadata()
    {
        var metaData = RowType.GetDatevMetadata();
        Assert.IsNotNull(metaData);
    }
}