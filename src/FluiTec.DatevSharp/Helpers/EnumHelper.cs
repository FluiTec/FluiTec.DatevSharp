using System;
using System.Text;
using FluiTec.DatevSharp.Attributes;
using FluiTec.DatevSharp.Rows.Enums;

namespace FluiTec.DatevSharp.Helpers
{
    /// <summary>
    /// An enum helper.
    /// </summary>
    public static class EnumHelper
    {
        #region enumTypes

        private static readonly Type PostalAddressTypeType = typeof(PostalAddressType);
        private static readonly Type ClaimType = typeof(Claim);
        private static readonly Type TaxationTypeType = typeof(TaxationType);
        private static readonly Type BookingTypeType = typeof(BookingType);
        private static readonly Type CountryType = typeof(Country);
        private static readonly Type AccrualsBasisAccountingType = typeof(AccrualsBasisAccounting);

        #endregion

        #region Private Methods

        /// <summary>
        /// Gets string value.
        /// </summary>
        ///
        /// <param name="enumType">     Type of the enum. </param>
        /// <param name="fieldName">    Name of the field. </param>
        ///
        /// <returns>
        /// The string value.
        /// </returns>
        private static string GetStringValue(Type enumType, string fieldName)
        {
            var fieldInfo = enumType.GetField(fieldName);
            return fieldInfo.GetCustomAttributes(typeof(StringValueAttribute), false)
                is StringValueAttribute[] attrs && attrs.Length > 0
                ? attrs[0].Value
                : null;
        }

        #endregion

        #region ToDatev

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

        /// <summary>
        /// An DueType extension method that value to datev.
        /// </summary>
        ///
        /// <param name="dueType">  The dueType to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ValueToDatev(this DueType dueType)
        {
            return Convert.ToInt32(dueType).ToString();
        }

        /// <summary>
        /// An PaymentType extension method that value to datev.
        /// </summary>
        ///
        /// <param name="paymentType">  The paymentType to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ValueToDatev(this PaymentType paymentType)
        {
            return Convert.ToInt32(paymentType).ToString();
        }

        /// <summary>
        /// An CashDiscountType extension method that value to datev.
        /// </summary>
        ///
        /// <param name="cashDiscountType"> The cashDiscountType to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ValueToDatev(this CashDiscountType cashDiscountType)
        {
            return Convert.ToInt32(cashDiscountType).ToString();
        }

        /// <summary>
        /// An AccrualsBasisAccounting extension method that value to datev.
        /// </summary>
        ///
        /// <param name="accrualsBasisAccounting">  The accrualsBasisAccounting to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ValueToDatev(this AccrualsBasisAccounting accrualsBasisAccounting)
        {
            return Convert.ToInt32(accrualsBasisAccounting).ToString().ToDatev();
        }

        /// <summary>
        /// A PostalAddressType extension method that converts a postalAddressType to a datev.
        /// </summary>
        ///
        /// <param name="postalAddressType">    The postalAddressType to act on. </param>
        ///
        /// <returns>
        /// PostalAddressType as a string.
        /// </returns>
        public static string ToDatev(this PostalAddressType postalAddressType)
        {
            return GetStringValue(PostalAddressTypeType, postalAddressType.ToString());
        }

        /// <summary>
        /// A Claim extension method that converts a claim to a datev.
        /// </summary>
        ///
        /// <param name="claim">    The claim to act on. </param>
        ///
        /// <returns>
        /// Claim as a string.
        /// </returns>
        public static string ToDatev(this Claim claim)
        {
            return GetStringValue(ClaimType, claim.ToString());
        }

        /// <summary>
        /// A TaxationType extension method that converts a TaxationType to a datev.
        /// </summary>
        ///
        /// <param name="taxationType"> The taxationType to act on. </param>
        ///
        /// <returns>
        /// TaxationType as a string.
        /// </returns>
        public static string ToDatev(this TaxationType taxationType)
        {
            return GetStringValue(TaxationTypeType, taxationType.ToString());
        }

        /// <summary>
        /// A BookingType extension method that converts a BookingType to a datev.
        /// </summary>
        ///
        /// <param name="bookingType">  The bookingType to act on. </param>
        ///
        /// <returns>
        /// BookingType as a string.
        /// </returns>
        public static string ToDatev(this BookingType bookingType)
        {
            return GetStringValue(BookingTypeType, bookingType.ToString());
        }

        /// <summary>
        /// A Country extension method that converts a postalAddressType to a datev.
        /// </summary>
        ///
        /// <param name="country">  The country to act on. </param>
        ///
        /// <returns>
        /// Country as a string.
        /// </returns>
        public static string ToDatev(this Country country)
        {
            return GetStringValue(CountryType, country.ToString());
        }

        #endregion
    }
}