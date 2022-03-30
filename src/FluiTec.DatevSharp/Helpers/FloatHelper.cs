using System.Globalization;

namespace FluiTec.DatevSharp.Helpers
{
    /// <summary>
    ///     A float helper.
    /// </summary>
    public static class FloatHelper
    {
        /// <summary>
        ///     A float extension method that converts a num to a datev.
        /// </summary>
        /// <param name="num">  The num to act on. </param>
        /// <returns>
        ///     Num as a string.
        /// </returns>
        public static string ToDatev(this float num)
        {
            return num.ToString("0.00");
        }

        /// <summary>
        ///     A float extension method that converts a num to a datev.
        /// </summary>
        /// <param name="num">  The num to act on. </param>
        /// <returns>
        ///     Num as a string.
        /// </returns>
        public static string ToDatev(this float? num)
        {
            return num?.ToString("0.00");
        }
    }
}