using FluiTec.DatevSharp.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Rows.AddressRow;

[TestClass]
public class AddressRowTest : RowTest
{
    public override IDatevRow CreateRow()
    {
        return new DatevSharp.Rows.AddressRow.AddressBaseRow();
    }
}