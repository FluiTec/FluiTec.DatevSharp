using System;
using System.Reflection;
using FluiTec.DatevSharp.Attributes;

namespace FluiTec.DatevSharp.Helpers
{
    /// <summary>
    ///     A reflection helper.
    /// </summary>
    public static class ReflectionHelper
    {
        /// <summary>
        ///     A Type extension method that gets datev metadata.
        /// </summary>
        /// <param name="type"> The type to act on. </param>
        /// <returns>
        ///     The datev metadata.
        /// </returns>
        public static DatevRowAttribute GetDatevMetadata(this Type type)
        {
            return type.GetCustomAttribute<DatevRowAttribute>();
        }
    }
}