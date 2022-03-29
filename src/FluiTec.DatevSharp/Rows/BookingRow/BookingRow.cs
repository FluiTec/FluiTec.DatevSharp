using System.Globalization;
using System.Threading;
using FluiTec.DatevSharp.Attributes;
using FluiTec.DatevSharp.Interfaces;
using FluiTec.DatevSharp.Rows.Enums;
using FluiTec.DatevSharp.Rows.Maps;

namespace FluiTec.DatevSharp.Rows.BookingRow
{
    /// <summary>   A booking row. </summary>
    [DatevRow(typeof(BookingMap), typeof(HeaderRow))]
    public partial class BookingRow : IDatevRow
    {
        /// <summary>   Default constructor. </summary>
        public BookingRow()
        {
            Claim = Claim.Debit;
            CurrencySymbol = new RegionInfo(Thread.CurrentThread.CurrentUICulture.LCID).ISOCurrencySymbol;
            Fixing = false;
        }
    }
}