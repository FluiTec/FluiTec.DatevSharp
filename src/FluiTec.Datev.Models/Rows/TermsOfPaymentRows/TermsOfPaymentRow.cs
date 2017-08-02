using FluiTec.Datev.Models.Helpers;

namespace FluiTec.Datev.Models.Rows
{
	public class TermsOfPaymentRow : IDatevRow
	{
		#region IDatevRow

		/// <summary>   Converts this object to a row. </summary>
		/// <returns>   This object as a string. </returns>
		public string ToRow()
		{
			return
				$"{Number.ToDatev()};{Name.ToDatev()};{DueType.ToDatev()};{CashDiscount1Percent.ToDatev()};{CashDiscount1Days.ToDatev()};{CashDiscount2Percent.ToDatev()};" +
				$"{CashDiscount2Days.ToDatev()};{Days.ToDatev()};;;;;;;;;;;;;;;;;;;;;;\"\";";
		}

		#endregion

		#region Constructors

		#endregion

		#region Properties

		/// <summary>   Gets or sets the number of.  </summary>
		/// <value> The number. </value>
		/// <remarks>
		///     MaxLength=3, MinLength=2
		/// </remarks>
		public int Number { get; set; }

		/// <summary>   Gets or sets the name. </summary>
		/// <value> The name. </value>
		public string Name { get; set; }

		/// <summary>   Gets or sets the type of the due. </summary>
		/// <value> The type of the due. </value>
		public int? DueType { get; set; }

		/// <summary>   Gets or sets the cash discount 1 percent. </summary>
		/// <value> The cash discount 1 percent. </value>
		/// <remarks>
		///     MaxLength=2 + 2 NKS
		/// </remarks>
		public int? CashDiscount1Percent { get; set; }

		/// <summary>   Gets or sets the cash discount 1 days. </summary>
		/// <value> The cash discount 1 days. </value>
		/// <remarks>
		///     MaxLength=3
		/// </remarks>
		public int? CashDiscount1Days { get; set; }

		/// <summary>   Gets or sets the cash discount 2 percent. </summary>
		/// <value> The cash discount 2 percent. </value>
		/// <remarks>
		///     MaxLength=2 + 2 NKS
		/// </remarks>
		public int? CashDiscount2Percent { get; set; }

		/// <summary>   Gets or sets the cash discount 2 days. </summary>
		/// <value> The cash discount 2 days. </value>
		/// <remarks>
		///     MaxLength=3
		/// </remarks>
		public int? CashDiscount2Days { get; set; }

		/// <summary>   Gets or sets the days. </summary>
		/// <value> The days. </value>
		public int? Days { get; set; }

		#endregion
	}
}