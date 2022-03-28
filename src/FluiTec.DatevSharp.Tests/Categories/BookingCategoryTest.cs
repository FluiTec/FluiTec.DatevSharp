using FluiTec.DatevSharp.Rows.BookingRow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Categories;

[TestClass]
public class BookingCategoryTest : BaseDataCategoryTest
{
    public BookingCategoryTest() : base("Bookings", "Buchungsstapel", typeof(BookingRow))
    {
    }

    protected override DataCategory GetCategory() => DataCategories.Instance.BookingCategory;
}