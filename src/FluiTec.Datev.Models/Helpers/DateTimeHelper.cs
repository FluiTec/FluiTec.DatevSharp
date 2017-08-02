using System;

namespace FluiTec.Datev.Models.Helpers
{
	/// <summary>   A date time helper. </summary>
	public static class DateTimeHelper
	{
		/// <summary>
		///     A DateTime extension method that converts a dateTime to a datev date time.
		/// </summary>
		/// <param name="dateTime"> The dateTime to act on. </param>
		/// <returns>   dateTime as a string. </returns>
		public static string ToDatevDateTime(this DateTime dateTime)
		{
			return dateTime.ToString(format: "yyyyMMddHHmmssfff");
		}

		/// <summary>   A DateTime extension method that converts a dateTime to a datev date. </summary>
		/// <param name="dateTime"> The dateTime to act on. </param>
		/// <returns>   dateTime as a string. </returns>
		public static string ToDatevDate(this DateTime dateTime)
		{
			return dateTime.ToString(format: "yyyyMMdd");
		}

		/// <summary>
		///     A DateTime extension method that converts a dateTime to a datev date time.
		/// </summary>
		/// <param name="dateTime"> The dateTime to act on. </param>
		/// <returns>   dateTime as a string. </returns>
		public static string ToDatevDateTime(this DateTime? dateTime)
		{
			return dateTime?.ToString(format: "yyyyMMddHHmmssfff");
		}

		/// <summary>   A DateTime extension method that converts a dateTime to a datev date. </summary>
		/// <param name="dateTime"> The dateTime to act on. </param>
		/// <returns>   dateTime as a string. </returns>
		public static string ToDatevDate(this DateTime? dateTime)
		{
			return dateTime?.ToString(format: "yyyyMMdd");
		}

		/// <summary>
		///     A DateTime? extension method that converts a dateTime to a short datev date.
		/// </summary>
		/// <param name="dateTime"> The dateTime to act on. </param>
		/// <returns>   dateTime as a string. </returns>
		public static string ToShortDatevDate(this DateTime? dateTime)
		{
			return dateTime?.ToString(format: "ddMM");
		}

		/// <summary>
		///     A DateTime extension method that converts a dateTime to a short datev sate.
		/// </summary>
		/// <param name="dateTime"> The dateTime to act on. </param>
		/// <returns>   dateTime as a string. </returns>
		public static string ToShortDatevSate(this DateTime dateTime)
		{
			return dateTime.ToString(format: "ddMM");
		}

		/// <summary>
		///     A DateTime? extension method that converts a dateTime to a short datev year.
		/// </summary>
		/// <param name="dateTime"> The dateTime to act on. </param>
		/// <returns>   dateTime as a string. </returns>
		public static string ToShortDatevYear(this DateTime? dateTime)
		{
			return dateTime?.ToString(format: "yyyy");
		}

		/// <summary>
		///     A DateTime? extension method that converts a dateTime to a short datev year.
		/// </summary>
		/// <param name="dateTime"> The dateTime to act on. </param>
		/// <returns>   dateTime as a string. </returns>
		public static string ToShortDatevYear(this DateTime dateTime)
		{
			return dateTime.ToString(format: "yyyy");
		}

		/// <summary>
		///     A DateTime extension method that converts a dateTime to a datev date reverse.
		/// </summary>
		/// <param name="dateTime"> The dateTime to act on. </param>
		/// <returns>   dateTime as a string. </returns>
		public static string ToDatevDateReverse(this DateTime dateTime)
		{
			return dateTime.ToString(format: "ddMMyyyy");
		}

		/// <summary>
		///     A DateTime extension method that converts a dateTime to a datev date reverse.
		/// </summary>
		/// <param name="dateTime"> The dateTime to act on. </param>
		/// <returns>   dateTime as a string. </returns>
		public static string ToDatevDateReverse(this DateTime? dateTime)
		{
			return dateTime?.ToString(format: "ddMMyyyy");
		}
	}
}