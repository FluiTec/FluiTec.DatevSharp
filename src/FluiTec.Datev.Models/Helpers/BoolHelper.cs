namespace FluiTec.Datev.Models.Helpers
{
	public static class BoolHelper
	{
		/// <summary>   A bool extension method that converts a b to a datev. </summary>
		/// <param name="b">    The b to act on. </param>
		/// <returns>   b as a string. </returns>
		public static string ToDatev(this bool b)
		{
			return b ? "1" : "0";
		}

		/// <summary>   A bool extension method that converts a b to a datev. </summary>
		/// <param name="b">    The b to act on. </param>
		/// <returns>   b as a string. </returns>
		public static string ToDatev(this bool? b)
		{
			if (!b.HasValue) return string.Empty;
			return b.Value ? "1" : "0";
		}
	}
}