using System;
using FluiTec.DatevSharp.Attributes;
using FluiTec.DatevSharp.Helpers;
using FluiTec.DatevSharp.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Rows;

public abstract class RowTest
{
    public abstract IDatevRow CreateRow();

    [TestMethod]
    public void CanGetRow()
    {
        Assert.IsNotNull(CreateRow());
    }

    /// <summary>
    /// Gets the metadata.
    /// </summary>
    ///
    /// <returns>
    /// The metadata.
    /// </returns>
    protected DatevRowAttribute GetMetadata() =>
        CreateRow().GetType().GetDatevMetadata() ?? throw new InvalidOperationException();

    [TestMethod]
    public void CanGetMetadata()
    {
        Assert.IsNotNull(GetMetadata());
    }

    [TestMethod]
    public void CanGetClassMap()
    {
        Assert.IsNotNull(GetMetadata().GetMap());
    }

    [TestMethod]
    public void CanGetHeader()
    {
        Assert.IsNotNull(GetMetadata().GetHeader());
    }
}