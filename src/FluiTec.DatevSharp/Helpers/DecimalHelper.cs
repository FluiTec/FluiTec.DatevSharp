using System.Globalization;

namespace FluiTec.DatevSharp.Helpers
{
    /// <summary>   A decimal helper. </summary>
    public static class DecimalHelper
    {
        /// <summary>   (Immutable) the datev number format. </summary>
        private static readonly NumberFormatInfo DatevNumberFormat = new()
        {
            NumberDecimalSeparator = ",",
            NumberGroupSeparator = string.Empty
        };

        /// <summary>   A decimal extension method that converts a num to a datev. </summary>
        /// <param name="num">  The num to act on. </param>
        /// <returns>   num as a string. </returns>
        public static string ToDatev(this decimal num)
        {
            return num.ToString("G", DatevNumberFormat);
        }

        /// <summary>   A decimal extension method that converts a num to a datev. </summary>
        /// <param name="num">  The num to act on. </param>
        /// <returns>   num as a string. </returns>
        public static string ToDatev(this decimal? num)
        {
            return num?.ToString("G", DatevNumberFormat);
        }
    }
}