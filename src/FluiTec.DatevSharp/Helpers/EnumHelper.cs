using System;
using FluiTec.DatevSharp.Attributes;
using FluiTec.DatevSharp.Rows.Enums;

namespace FluiTec.DatevSharp.Helpers
{
    /// <summary>
    ///     An enum helper.
    /// </summary>
    public static class EnumHelper
    {
        #region Private Methods

        /// <summary>
        ///     Gets string value.
        /// </summary>
        /// <param name="enumType">     Type of the enum. </param>
        /// <param name="fieldName">    Name of the field. </param>
        /// <returns>
        ///     The string value.
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

        #region enumTypes

        private static readonly Type PostalAddressTypeType = typeof(PostalAddressType);
        private static readonly Type ClaimType = typeof(Claim);
        private static readonly Type TaxationTypeType = typeof(TaxationType);
        private static readonly Type BookingTypeType = typeof(BookingType);
        private static readonly Type CountryType = typeof(Country);

        #endregion

        #region ToDatev

        /// <summary>
        ///     An AddressType extension method that value to datev.
        /// </summary>
        /// <param name="addressType">  The addressType to act on. </param>
        /// <returns>
        ///     A string.
        /// </returns>
        public static string ToDatev(this AddressType addressType)
        {
            return Convert.ToInt32(addressType).ToString().ToDatev();
        }

        /// <summary>
        ///     An DueType extension method that value to datev.
        /// </summary>
        /// <param name="dueType">  The dueType to act on. </param>
        /// <returns>
        ///     A string.
        /// </returns>
        public static string ToDatev(this DueType dueType)
        {
            return Convert.ToInt32(dueType).ToString();
        }

        /// <summary>
        ///     An PaymentType extension method that value to datev.
        /// </summary>
        /// <param name="paymentType">  The paymentType to act on. </param>
        /// <returns>
        ///     A string.
        /// </returns>
        public static string ToDatev(this PaymentType paymentType)
        {
            return Convert.ToInt32(paymentType).ToString();
        }

        /// <summary>
        ///     An CashDiscountType extension method that value to datev.
        /// </summary>
        /// <param name="cashDiscountType"> The cashDiscountType to act on. </param>
        /// <returns>
        ///     A string.
        /// </returns>
        public static string ToDatev(this CashDiscountType cashDiscountType)
        {
            return Convert.ToInt32(cashDiscountType).ToString();
        }

        /// <summary>
        /// An Language extension method that value to datev.
        /// </summary>
        ///
        /// <param name="language"> The language to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ToDatev(this Language language)
        {
            return Convert.ToInt32(language).ToString();
        }

        /// <summary>
        /// An OutputTarget extension method that value to datev.
        /// </summary>
        ///
        /// <param name="outputTarget"> The outputTarget to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ToDatev(this OutputTarget outputTarget)
        {
            return Convert.ToInt32(outputTarget).ToString();
        }

        /// <summary>
        /// An CurrencyHandling extension method that value to datev.
        /// </summary>
        ///
        /// <param name="currencyHandling"> The currencyHandling to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ToDatev(this CurrencyHandling? currencyHandling)
        {
            return currencyHandling.HasValue ? Convert.ToInt32(currencyHandling.Value).ToString().ToDatev() : "\"\"";
        }

        /// <summary>
        /// An Admonition extension method that value to datev.
        /// </summary>
        ///
        /// <param name="admonition">   The admonition to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ToDatev(this Admonition admonition)
        {
            return Convert.ToInt32(admonition).ToString();
        }

        /// <summary>
        /// An AccountStatement extension method that value to datev.
        /// </summary>
        ///
        /// <param name="accountStatement"> The accountStatement to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ToDatev(this AccountStatement accountStatement)
        {
            return Convert.ToInt32(accountStatement).ToString();
        }

        /// <summary>
        /// An AdmontitionText extension method that value to datev.
        /// </summary>
        ///
        /// <param name="accountStatement"> The accountStatement to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ToDatev(this AdmontitionText accountStatement)
        {
            return Convert.ToInt32(accountStatement).ToString();
        }

        /// <summary>
        /// An InterestCalculation extension method that value to datev.
        /// </summary>
        ///
        /// <param name="interestCalculation">  The interestCalculation to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ToDatev(this InterestCalculation interestCalculation)
        {
            return Convert.ToInt32(interestCalculation).ToString();
        }

        /// <summary>
        /// An PaymentTransferMedium extension method that value to datev.
        /// </summary>
        ///
        /// <param name="paymentTransferMedium">    The paymentTransferMedium to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ToDatev(this PaymentTransferMedium? paymentTransferMedium)
        {
            return paymentTransferMedium.HasValue ? Convert.ToInt32(paymentTransferMedium).ToString() : "\"\"";
        }

        /// <summary>
        /// An DebitAdvice extension method that value to datev.
        /// </summary>
        ///
        /// <param name="debitAdvice">  The debitAdvice to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ToDatev(this DebitAdvice? debitAdvice)
        {
            return debitAdvice.HasValue ? Convert.ToInt32(debitAdvice.Value).ToString().ToDatev() : "\"\"";
        }

        /// <summary>
        /// An AccountStatementText extension method that value to datev.
        /// </summary>
        ///
        /// <param name="accountStatementText"> The accountStatementText to act on. </param>
        ///
        /// <returns>
        /// A string.
        /// </returns>
        public static string ToDatev(this AccountStatementText accountStatementText)
        {
            return Convert.ToInt32(accountStatementText).ToString();
        }

        /// <summary>
        ///     An AccrualsBasisAccounting extension method that value to datev.
        /// </summary>
        /// <param name="accrualsBasisAccounting">  The accrualsBasisAccounting to act on. </param>
        /// <returns>
        ///     A string.
        /// </returns>
        public static string ToDatev(this AccrualsBasisAccounting accrualsBasisAccounting)
        {
            return Convert.ToInt32(accrualsBasisAccounting).ToString().ToDatev();
        }

        /// <summary>
        ///     A PostalAddressType extension method that converts a postalAddressType to a datev.
        /// </summary>
        /// <param name="postalAddressType">    The postalAddressType to act on. </param>
        /// <returns>
        ///     PostalAddressType as a string.
        /// </returns>
        public static string ToDatev(this PostalAddressType postalAddressType)
        {
            return GetStringValue(PostalAddressTypeType, postalAddressType.ToString()).ToDatev();
        }

        /// <summary>
        ///     A Claim extension method that converts a claim to a datev.
        /// </summary>
        /// <param name="claim">    The claim to act on. </param>
        /// <returns>
        ///     Claim as a string.
        /// </returns>
        public static string ToDatev(this Claim claim)
        {
            return GetStringValue(ClaimType, claim.ToString()).ToDatev();
        }

        /// <summary>
        ///     A TaxationType extension method that converts a TaxationType to a datev.
        /// </summary>
        /// <param name="taxationType"> The taxationType to act on. </param>
        /// <returns>
        ///     TaxationType as a string.
        /// </returns>
        public static string ToDatev(this TaxationType taxationType)
        {
            return GetStringValue(TaxationTypeType, taxationType.ToString()).ToDatev();
        }

        /// <summary>
        ///     A BookingType extension method that converts a BookingType to a datev.
        /// </summary>
        /// <param name="bookingType">  The bookingType to act on. </param>
        /// <returns>
        ///     BookingType as a string.
        /// </returns>
        public static string ToDatev(this BookingType bookingType)
        {
            return GetStringValue(BookingTypeType, bookingType.ToString()).ToDatev();
        }

        /// <summary>
        ///     A Country extension method that converts a postalAddressType to a datev.
        /// </summary>
        /// <param name="country">  The country to act on. </param>
        /// <returns>
        ///     Country as a string.
        /// </returns>
        public static string ToDatev(this Country country)
        {
            return GetStringValue(CountryType, country.ToString()).ToDatev();
        }

        /// <summary>
        ///     A PostalAddressType extension method that converts a postalAddressType to a datev.
        /// </summary>
        /// <param name="country">  The country to act on. </param>
        /// <returns>
        ///     PostalAddressType as a string.
        /// </returns>
        public static string ToDatev(this Country? country)
        {
            return country == null ? "\"\"" : GetStringValue(CountryType, country.ToString()).ToDatev();
        }

        #endregion
    }
}