using System;
using FluiTec.DatevSharp.Rows.Enums;

namespace FluiTec.DatevSharp.Helpers
{
    /// <summary>
    /// An enum helper.
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// An AddressType extension method that value to datev.
        /// </summary>
        ///
        /// <param name="addressType">  The addressType to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ValueToDatev(this AddressType addressType)
        {
            return Convert.ToInt32(addressType).ToString().ToDatev();
        }
    }
}