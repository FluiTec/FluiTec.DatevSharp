using System;

namespace FluiTec.DatevSharp.Helpers
{
    /// <summary>   A unique identifier helper. </summary>
    public static class GuidHelper
    {
        /// <summary>   A GUID extension method that converts an ID to a datev. </summary>
        /// <param name="id">   The ID to act on. </param>
        /// <returns>   ID as a string. </returns>
        public static string ToDatev(this Guid id)
        {
            return id != Guid.Empty ? id.ToString() : "\"\"";
        }
    }
}