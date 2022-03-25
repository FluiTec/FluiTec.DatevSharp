using System.Collections.Generic;

namespace FluiTec.DatevSharp.Helpers
{
	/// <summary>   A string helper. </summary>
	public static class StringHelper
	{
        private static readonly Dictionary<string, string> ReplaceMap = new Dictionary<string, string>
        {
            {"\r\n", " " },
            {"\n", " " },
            {"\"",  "\"\""},
            {"\"", "\"\""},
            {";", ","}
        };

        private static readonly string Regex = string.Join("|", ReplaceMap.Keys);

        /// <summary>   A string extension method that converts a str to a datev string. </summary>
        ///
        /// <param name="str">  The str to act on. </param>
        ///
        /// <returns>   str as a string. </returns>
        public static string ToDatev(this string str)
        {
            return string.IsNullOrWhiteSpace(str)
                ? "\"\""
                : $"\"{System.Text.RegularExpressions.Regex.Replace(str, Regex, m => ReplaceMap[m.Value])}\"";
        }
    }
}