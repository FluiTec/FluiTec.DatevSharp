using FluiTec.DatevSharp.Rows;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Rows;

/// <summary>
///     The address header row test.
/// </summary>
public class HeaderRowTest
{
    /// <summary>
    ///     Can get header.
    /// </summary>
    /// <param name="version">  The version. </param>
    /// <param name="row">      The row. </param>
    public void CanGetHeader(DataCategoryVersion version, HeaderRow row)
    {
        Assert.IsFalse(string.IsNullOrWhiteSpace(row.ToRow(version)));
    }
}