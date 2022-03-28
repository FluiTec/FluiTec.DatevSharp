using System.Globalization;
using System.Threading;
using FluiTec.DatevSharp.Attributes;
using FluiTec.DatevSharp.Rows.Maps;

namespace FluiTec.DatevSharp.Rows.BookingRow
{
	/// <summary>   A booking row. </summary>
    [DatevRow(typeof(BookingMap), typeof(HeaderRow))]
	public partial class BookingRow : Interfaces.IDatevRow
	{
		/// <summary>   Default constructor. </summary>
		public BookingRow()
		{
			Claim = "S";
			CurrencySymbol = new RegionInfo(Thread.CurrentThread.CurrentUICulture.LCID).ISOCurrencySymbol;
			Fixing = false;
		}
	}
}