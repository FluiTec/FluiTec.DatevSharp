namespace FluiTec.DatevSharp.Helpers
{
	/// <summary>   A string helper. </summary>
	public static class StringHelper
	{
		/// <summary>   A string extension method that converts a str to a datev string. </summary>
		///
		/// <param name="str">  The str to act on. </param>
		///
		/// <returns>   str as a string. </returns>
		public static string ToDatev(this string str)
		{
			return string.IsNullOrWhiteSpace(str) ? "\"\"" : $"\"{str}\"";
		}
	}
}