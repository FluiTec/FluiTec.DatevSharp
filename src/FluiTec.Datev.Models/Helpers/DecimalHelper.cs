namespace FluiTec.Datev.Models.Helpers
{
	public static class DecimalHelper
	{
		/// <summary>   A decimal extension method that converts a num to a datev. </summary>
		/// <param name="num">  The num to act on. </param>
		/// <returns>   num as a string. </returns>
		public static string ToDatev(this decimal num)
		{
			return num.ToString(format: "G");
		}

		/// <summary>   A decimal extension method that converts a num to a datev. </summary>
		/// <param name="num">  The num to act on. </param>
		/// <returns>   num as a string. </returns>
		public static string ToDatev(this decimal? num)
		{
			return num?.ToString(format: "G");
		}
	}
}