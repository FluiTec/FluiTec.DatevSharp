namespace FluiTec.Datev.Models.Helpers
{
	/// <summary>   An int helper. </summary>
	public static class IntHelper
	{
		/// <summary>   A decimal extension method that converts a num to a datev. </summary>
		/// <param name="num">  The num to act on. </param>
		/// <returns>   num as a string. </returns>
		public static string ToDatev(this int num)
		{
			return num.ToString();
		}

		/// <summary>   A decimal extension method that converts a num to a datev. </summary>
		/// <param name="num">  The num to act on. </param>
		/// <returns>   num as a string. </returns>
		public static string ToDatev(this int? num)
		{
			return num?.ToString();
		}
	}
}