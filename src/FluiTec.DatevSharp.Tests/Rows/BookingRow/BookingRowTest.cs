using FluiTec.DatevSharp.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Rows.BookingRow;

[TestClass]
public class BookingRowTest : RowTest
{
    public override IDatevRow CreateRow()
    {
        return new DatevSharp.Rows.BookingRow.BookingRow();
    }
}