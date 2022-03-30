using System;
using FluiTec.DatevSharp.Attributes;
using FluiTec.DatevSharp.Interfaces;
using FluiTec.DatevSharp.Rows.Enums;
using FluiTec.DatevSharp.Rows.Maps;

namespace FluiTec.DatevSharp.Rows.AddressRow
{
    /// <summary>   The address row. </summary>
    [DatevRow(typeof(AddressMap), typeof(HeaderRow))]
    public partial class AddressRow : IDatevRow
    {
        /// <summary>   Gets or sets the account number. </summary>
        /// <value> The account number. </value>
        [DatevField(0, 1)]
        public int AccountNumber { get; set; }

        /// <summary>   Gets or sets the name enterprise. </summary>
        /// <value> The name enterprise. </value>
        /// <remarks>
        ///     MaxLength=50
        /// </remarks>
        [DatevField(1, 1)]
        public string Name_Enterprise { get; set; }

        /// <summary>   Gets or sets the name extension 1. </summary>
        /// <value> The name extension 1. </value>
        /// <remarks>
        ///     MaxLength=50
        /// </remarks>
        [DatevField(2, 1)]
        public string Name_Enterprise_Extension { get; set; }

        /// <summary>   Gets or sets the name person. </summary>
        /// <value> The name person. </value>
        /// <remarks>
        ///     MaxLength=30
        /// </remarks>
        [DatevField(3, 1)]
        public string Name_Person { get; set; }

        /// <summary>   Gets or sets the person's first name. </summary>
        /// <value> The name of the first. </value>
        /// <remarks>
        ///     MaxLength=30
        /// </remarks>
        [DatevField(4, 1)]
        public string FirstName_Person { get; set; }

        /// <summary>   Gets or sets the name. </summary>
        /// <value> The name. </value>
        /// <remarks>
        ///     MaxLength=50
        /// </remarks>
        [DatevField(5, 1)]
        public string Name { get; set; }

        /// <summary>   Gets or sets the type of the address. </summary>
        /// <value> The type of the address. </value>
        /// <remarks>
        ///     MaxLength=1, PossibleValues= 0-2 incl.
        /// </remarks>
        [DatevField(6, 1)]
        public AddressType AddressType { get; set; }

        /// <summary>   Gets or sets the name of the short. </summary>
        /// <value> The name of the short. </value>
        /// <remarks>
        ///     MaxLength=15
        /// </remarks>
        [DatevField(7, 1)]
        public string ShortName { get; set; }

        /// <summary>
        ///     Gets or sets the country.
        /// </summary>
        /// <value>
        ///     The country.
        /// </value>
        [DatevField(8, 1)]
        public Country? EuCountry { get; set; }

        /// <summary>
        /// Gets or sets the tax identifier number.
        /// </summary>
        ///
        /// <value>
        /// The tax identifier number.
        /// </value>
        [DatevField(9,1)]
        public string TaxIdNumber { get; set; }

        /// <summary>   Gets or sets the salutation. </summary>
        /// <value> The salutation. </value>
        /// <remarks>
        ///     MaxLength=30
        /// </remarks>
        [DatevField(10, 1)]
        public string Salutation { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        ///
        /// <value>
        /// The title.
        /// </value>
        [DatevField(11,1)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the nobility title.
        /// </summary>
        ///
        /// <value>
        /// The nobility title.
        /// </value>
        [DatevField(12, 1)]
        public string NobilityTitle { get; set; }

        /// <summary>
        /// Gets or sets the name prefix.
        /// </summary>
        ///
        /// <value>
        /// The name prefix.
        /// </value>
        [DatevField(13, 1)]
        public string NamePrefix { get; set; }

        /// <summary>   Gets or sets the type of the postal address. </summary>
        /// <value> The type of the postal address. </value>
        /// <remarks>
        ///     STR, PF, GK
        ///     MaxLength=3
        /// </remarks>
        [DatevField(14, 1)]
        public PostalAddressType PostalAddressType { get; set; }

        /// <summary>   Gets or sets the street. </summary>
        /// <value> The street. </value>
        /// <remarks>
        ///     MaxLength=36
        /// </remarks>
        [DatevField(15, 1)]
        public string Street { get; set; }

        /// <summary>   Gets or sets the post box. </summary>
        /// <value> The post box. </value>
        /// <remarks>
        ///     MaxLength=10
        /// </remarks>
        [DatevField(16, 1)]
        public string PostBox { get; set; }

        /// <summary>   Gets or sets the zip code. </summary>
        /// <value> The zip code. </value>
        /// <remarks>
        ///     MaxLength=10
        /// </remarks>
        [DatevField(17, 1)]
        public string ZipCode { get; set; }

        /// <summary>   Gets or sets the city. </summary>
        /// <value> The city. </value>
        /// <remarks>
        ///     MaxLength=30
        /// </remarks>
        [DatevField(18, 1)]
        public string City { get; set; }

        /// <summary>
        ///     Gets or sets the country.
        /// </summary>
        /// <value>
        ///     The country.
        /// </value>
        [DatevField(19, 1)]
        public Country? Country { get; set; }

        /// <summary>   Gets or sets the TransportAddition. </summary>
        /// <value> The TransportAddition. </value>
        /// <remarks>
        ///     MaxLength=50
        /// </remarks>
        [DatevField(20, 1)]
        public string TransportAddition { get; set; }

        /// <summary>   Gets or sets the AddressAddition. </summary>
        /// <value> The TransportAddition. </value>
        /// <remarks>
        ///     MaxLength=36
        /// </remarks>
        [DatevField(21, 1)]
        public string AddressAddition { get; set; }

        /// <summary>
        /// Gets or sets the divergent salutation.
        /// </summary>
        ///
        /// <value>
        /// The divergent salutation.
        /// </value>
        [DatevField(22, 1)]
        public string DivergentSalutation { get; set; }

        /// <summary>
        /// Gets or sets the delivery directive 1.
        /// </summary>
        ///
        /// <value>
        /// The delivery directive 1.
        /// </value>
        [DatevField(23, 1)]
        public string DeliveryDirective1 { get; set; }

        /// <summary>
        /// Gets or sets the delivery directive 2.
        /// </summary>
        ///
        /// <value>
        /// The delivery directive 2.
        /// </value>
        [DatevField(24, 1)]
        public string DeliveryDirective2 { get; set; }

        /// <summary>
        ///     Gets the marker correspondence address.
        /// </summary>
        /// <value>
        ///     The marker correspondence address.
        /// </value>
        /// <remarks>
        ///     MaxLength=1
        ///     Only valid value = 1
        /// </remarks>
        [DatevField(25, 1)]
        public int MarkerCorrespondenceAddress => 1;

        /// <summary>
        /// Gets or sets the Date/Time of the valid from.
        /// </summary>
        ///
        /// <value>
        /// The valid from.
        /// </value>
        [DatevField(26, 1)]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the valid till.
        /// </summary>
        ///
        /// <value>
        /// The valid till.
        /// </value>
        [DatevField(27, 1)]
        public DateTime? ValidTill { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        ///
        /// <value>
        /// The phone.
        /// </value>
        [DatevField(28, 1)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the phone note.
        /// </summary>
        ///
        /// <value>
        /// The phone note.
        /// </value>
        [DatevField(29, 1)]
        public string PhoneNote { get; set; }

        /// <summary>
        /// Gets or sets the management phone.
        /// </summary>
        ///
        /// <value>
        /// The management phone.
        /// </value>
        [DatevField(30, 1)]
        public string ManagementPhone { get; set; }

        /// <summary>
        /// Gets or sets the management phone note.
        /// </summary>
        ///
        /// <value>
        /// The management phone note.
        /// </value>
        [DatevField(31, 1)]
        public string ManagementPhoneNote { get; set; }

        /// <summary>
        /// Gets or sets the mail.
        /// </summary>
        ///
        /// <value>
        /// The mail.
        /// </value>
        [DatevField(32, 1)]
        public string Mail { get; set; }

        /// <summary>
        /// Gets or sets the mail note.
        /// </summary>
        ///
        /// <value>
        /// The mail note.
        /// </value>
        [DatevField(33, 1)]
        public string MailNote { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        ///
        /// <value>
        /// The website.
        /// </value>
        [DatevField(34, 1)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or sets the website note.
        /// </summary>
        ///
        /// <value>
        /// The website note.
        /// </value>
        [DatevField(35, 1)]
        public string WebsiteNote { get; set; }

        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        ///
        /// <value>
        /// The fax.
        /// </value>
        [DatevField(36, 1)]
        public string Fax { get; set; }

        /// <summary>
        /// Gets or sets the fax note.
        /// </summary>
        ///
        /// <value>
        /// The fax note.
        /// </value>
        [DatevField(37, 1)]
        public string FaxNote { get; set; }

        /// <summary>
        /// Gets or sets the other.
        /// </summary>
        ///
        /// <value>
        /// The other.
        /// </value>
        [DatevField(38, 1)]
        public string Other { get; set; }

        /// <summary>
        /// Gets or sets the other note.
        /// </summary>
        ///
        /// <value>
        /// The other note.
        /// </value>
        [DatevField(39, 1)]
        public string OtherNote { get; set; }

        /// <summary>
        /// Gets or sets the letter salutation.
        /// </summary>
        ///
        /// <value>
        /// The letter salutation.
        /// </value>
        [DatevField(96, 1)]
        public string LetterSalutation { get; set; }

        /// <summary>
        /// Gets or sets the complimentary close.
        /// </summary>
        ///
        /// <value>
        /// The complimentary close.
        /// </value>
        [DatevField(97,1)]
        public string ComplimentaryClose { get; set; }

        /// <summary>
        /// Gets or sets the customer number.
        /// </summary>
        ///
        /// <value>
        /// The customer number.
        /// </value>
        [DatevField(98,1)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Gets or sets the tax number.
        /// </summary>
        ///
        /// <value>
        /// The tax number.
        /// </value>
        [DatevField(99, 1)]
        public string TaxNumber { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        ///
        /// <value>
        /// The language.
        /// </value>
        [DatevField(100, 1)]
        public Language? Language { get; set; }

        /// <summary>
        /// Gets or sets the contact person.
        /// </summary>
        ///
        /// <value>
        /// The contact person.
        /// </value>
        [DatevField(101, 1)]
        public string ContactPerson { get; set; }

        /// <summary>
        /// Gets or sets the representative.
        /// </summary>
        ///
        /// <value>
        /// The representative.
        /// </value>
        [DatevField(102, 1)]
        public string Representative { get; set; }

        /// <summary>
        /// Gets or sets the referee.
        /// </summary>
        ///
        /// <value>
        /// The referee.
        /// </value>
        [DatevField(103,1)]
        public string Referee { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this object is diverse.
        /// </summary>
        ///
        /// <value>
        /// True if this object is diverse, false if not.
        /// </value>
        [DatevField(104,1)]
        public bool IsDiverse { get; set; }

        /// <summary>
        /// Gets or sets the output target.
        /// </summary>
        ///
        /// <value>
        /// The output target.
        /// </value>
        [DatevField(105, 1)]
        public OutputTarget? OutputTarget { get; set; }

        /// <summary>
        /// Gets or sets the currency handling.
        /// </summary>
        ///
        /// <value>
        /// The currency handling.
        /// </value>
        [DatevField(106,1)]
        public CurrencyHandling? CurrencyHandling { get; set; }

        /// <summary>
        /// Gets or sets the credit limit.
        /// </summary>
        ///
        /// <value>
        /// The credit limit.
        /// </value>
        [DatevField(107,1)]
        public decimal? CreditLimit { get; set; }

        /// <summary>
        /// Gets or sets the terms of payment number.
        /// </summary>
        ///
        /// <value>
        /// The terms of payment number.
        /// </value>
        [DatevField(108, 1)]
        public int? TermsOfPaymentNumber { get; set; }

        /// <summary>
        /// Gets or sets the debitor due days.
        /// </summary>
        ///
        /// <value>
        /// The debitor due days.
        /// </value>
        [DatevField(109, 1)]
        public int? DebitorDueDays { get; set; }

        /// <summary>
        /// Gets or sets the debitor cash discount.
        /// </summary>
        ///
        /// <value>
        /// The debitor cash discount.
        /// </value>
        [DatevField(110, 1)]
        public float? DebitorCashDiscount { get; set; }

        /// <summary>
        /// Gets or sets the creditor due days 1.
        /// </summary>
        ///
        /// <value>
        /// The creditor due days 1.
        /// </value>
        [DatevField(111, 1)]
        public int? CreditorDueDays1 { get; set; }

        /// <summary>
        /// Gets or sets the creditor cash discount 1.
        /// </summary>
        ///
        /// <value>
        /// The creditor cash discount 1.
        /// </value>
        [DatevField(112, 1)]
        public float CreditorCashDiscount1 { get; set; }

        /// <summary>
        /// Gets or sets the creditor due days 2.
        /// </summary>
        ///
        /// <value>
        /// The creditor due days 2.
        /// </value>
        [DatevField(113, 1)]
        public int? CreditorDueDays2 { get; set; }

        /// <summary>
        /// Gets or sets the creditor cash discount 2.
        /// </summary>
        ///
        /// <value>
        /// The creditor cash discount 2.
        /// </value>
        [DatevField(114, 1)]
        public float CreditorCashDiscount2 { get; set; }

        /// <summary>
        /// Gets or sets the creditor due days 3.
        /// </summary>
        ///
        /// <value>
        /// The creditor due days 3.
        /// </value>
        [DatevField(115, 1)]
        public int? CreditorDueDays3 { get; set; }

        /// <summary>
        /// Gets or sets the creditor due days 4.
        /// </summary>
        ///
        /// <value>
        /// The creditor due days 4.
        /// </value>
        [DatevField(116, 1)]
        public int? CreditorDueDays4 { get; set; }

        /// <summary>
        /// Gets or sets the creditor cash discount 4.
        /// </summary>
        ///
        /// <value>
        /// The creditor cash discount 4.
        /// </value>
        [DatevField(117, 1)]
        public float CreditorCashDiscount4 { get; set; }

        /// <summary>
        /// Gets or sets the creditor due days 5.
        /// </summary>
        ///
        /// <value>
        /// The creditor due days 5.
        /// </value>
        [DatevField(118, 1)]
        public int? CreditorDueDays5 { get; set; }

        /// <summary>
        /// Gets or sets the creditor cash discount 5.
        /// </summary>
        ///
        /// <value>
        /// The creditor cash discount 5.
        /// </value>
        [DatevField(119, 1)]
        public float CreditorCashDiscount5 { get; set; }

        /// <summary>
        /// Gets or sets the admonition.
        /// </summary>
        ///
        /// <value>
        /// The admonition.
        /// </value>
        [DatevField(120, 1)]
        public Admonition? Admonition { get; set; }

        /// <summary>
        /// Gets or sets the account statement.
        /// </summary>
        ///
        /// <value>
        /// The account statement.
        /// </value>
        [DatevField(121,1)]
        public AccountStatement? AccountStatement { get; set; }

        /// <summary>
        /// Gets or sets the admonition text 1.
        /// </summary>
        ///
        /// <value>
        /// The admonition text 1.
        /// </value>
        [DatevField(122, 1)]
        public AdmontitionText? AdmonitionText1 { get; set; }

        /// <summary>
        /// Gets or sets the admonition text 2.
        /// </summary>
        ///
        /// <value>
        /// The admonition text 2.
        /// </value>
        [DatevField(123, 1)]
        public AdmontitionText? AdmonitionText2 { get; set; }

        /// <summary>
        /// Gets or sets the admonition text 3.
        /// </summary>
        ///
        /// <value>
        /// The admonition text 3.
        /// </value>
        [DatevField(124, 1)]
        public AdmontitionText? AdmonitionText3 { get; set; }

        /// <summary>
        /// Gets or sets the account statement text.
        /// </summary>
        ///
        /// <value>
        /// The account statement text.
        /// </value>
        [DatevField(125, 1)]
        public AccountStatementText? AccountStatementText { get; set; }

        /// <summary>
        /// Gets or sets the admonition limit.
        /// </summary>
        ///
        /// <value>
        /// The admonition limit.
        /// </value>
        [DatevField(126,1)]
        public decimal? AdmonitionLimit { get; set; }

        /// <summary>
        /// Gets or sets the admonition limit percent.
        /// </summary>
        ///
        /// <value>
        /// The admonition limit percent.
        /// </value>
        [DatevField(127, 1)]
        public float? AdmonitionLimitPercent { get; set; }

        /// <summary>
        /// Gets or sets the interest calculation.
        /// </summary>
        ///
        /// <value>
        /// The interest calculation.
        /// </value>
        [DatevField(128, 1)]
        public InterestCalculation? InterestCalculation { get; set; }

        /// <summary>
        /// Gets or sets the admonition interest rate 1.
        /// </summary>
        ///
        /// <value>
        /// The admonition interest rate 1.
        /// </value>
        [DatevField(129, 1)]
        public float? AdmonitionInterestRate1 { get; set; }

        /// <summary>
        /// Gets or sets the admonition interest rate 2.
        /// </summary>
        ///
        /// <value>
        /// The admonition interest rate 2.
        /// </value>
        [DatevField(130, 1)]
        public float? AdmonitionInterestRate2 { get; set; }

        /// <summary>
        /// Gets or sets the admonition interest rate 3.
        /// </summary>
        ///
        /// <value>
        /// The admonition interest rate 3.
        /// </value>
        [DatevField(131, 1)]
        public float? AdmonitionInterestRate3 { get; set; }

        /// <summary>
        /// Gets or sets the debit advice.
        /// </summary>
        ///
        /// <value>
        /// The debit advice.
        /// </value>
        [DatevField(132,1)]
        public DebitAdvice? DebitAdvice { get; set; }

        /// <summary>
        /// Gets or sets the method.
        /// </summary>
        ///
        /// <value>
        /// The method.
        /// </value>
        [DatevField(133,1)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets the debit advice bank.
        /// </summary>
        ///
        /// <value>
        /// The debit advice bank.
        /// </value>
        [DatevField(134,1)]
        public int? DebitAdviceBank { get; set; }

        /// <summary>
        /// Gets or sets the payment transfer medium.
        /// </summary>
        ///
        /// <value>
        /// The payment transfer medium.
        /// </value>
        [DatevField(135,1)]
        public PaymentTransferMedium? PaymentTransferMedium { get; set; }

        /// <summary>
        /// Gets or sets the individual field 1.
        /// </summary>
        ///
        /// <value>
        /// The individual field 1.
        /// </value>
        [DatevField(136,1)]
        public string IndividualField1 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 2.
        /// </summary>
        ///
        /// <value>
        /// The individual field 2.
        /// </value>
        [DatevField(137, 1)]
        public string IndividualField2 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 3.
        /// </summary>
        ///
        /// <value>
        /// The individual field 3.
        /// </value>
        [DatevField(138, 1)]
        public string IndividualField3 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 4.
        /// </summary>
        ///
        /// <value>
        /// The individual field 4.
        /// </value>
        [DatevField(139, 1)]
        public string IndividualField4 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 5.
        /// </summary>
        ///
        /// <value>
        /// The individual field 5.
        /// </value>
        [DatevField(140, 1)]
        public string IndividualField5 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 6.
        /// </summary>
        ///
        /// <value>
        /// The individual field 6.
        /// </value>
        [DatevField(141, 1)]
        public string IndividualField6 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 7.
        /// </summary>
        ///
        /// <value>
        /// The individual field 7.
        /// </value>
        [DatevField(142, 1)]
        public string IndividualField7 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 8.
        /// </summary>
        ///
        /// <value>
        /// The individual field 8.
        /// </value>
        [DatevField(143, 1)]
        public string IndividualField8 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 9.
        /// </summary>
        ///
        /// <value>
        /// The individual field 9.
        /// </value>
        [DatevField(144, 1)]
        public string IndividualField9 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 10.
        /// </summary>
        ///
        /// <value>
        /// The individual field 10.
        /// </value>
        [DatevField(145, 1)]
        public string IndividualField10 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 11.
        /// </summary>
        ///
        /// <value>
        /// The individual field 11.
        /// </value>
        [DatevField(146, 1)]
        public string IndividualField11 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 12.
        /// </summary>
        ///
        /// <value>
        /// The individual field 12.
        /// </value>
        [DatevField(147, 1)]
        public string IndividualField12 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 13.
        /// </summary>
        ///
        /// <value>
        /// The individual field 13.
        /// </value>
        [DatevField(148, 1)]
        public string IndividualField13 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 14.
        /// </summary>
        ///
        /// <value>
        /// The individual field 14.
        /// </value>
        [DatevField(149, 1)]
        public string IndividualField14 { get; set; }

        /// <summary>
        /// Gets or sets the individual field 15.
        /// </summary>
        ///
        /// <value>
        /// The individual field 15.
        /// </value>
        [DatevField(150, 1)]
        public string IndividualField15 { get; set; }

        /// <summary>
        /// Gets or sets the billing divergent salutation.
        /// </summary>
        ///
        /// <value>
        /// The billing divergent salutation.
        /// </value>
        [DatevField(151,1)]
        public string BillingDivergentSalutation { get; set; }

        /// <summary>
        /// Gets or sets the type of the billing postal address.
        /// </summary>
        ///
        /// <value>
        /// The type of the billing postal address.
        /// </value>
        [DatevField(152,1)]
        public PostalAddressType BillingPostalAddressType { get; set; }

        /// <summary>
        /// Gets or sets the billing street.
        /// </summary>
        ///
        /// <value>
        /// The billing street.
        /// </value>
        [DatevField(153,1)]
        public string BillingStreet { get; set; }

        /// <summary>
        /// Gets or sets the billing post box.
        /// </summary>
        ///
        /// <value>
        /// The billing post box.
        /// </value>
        [DatevField(154,1)]
        public string BillingPostBox { get; set; }

        /// <summary>
        /// Gets or sets the billing zip code.
        /// </summary>
        ///
        /// <value>
        /// The billing zip code.
        /// </value>
        [DatevField(155,1)]
        public string BillingZipCode { get; set; }

        /// <summary>
        /// Gets or sets the billing city.
        /// </summary>
        ///
        /// <value>
        /// The billing city.
        /// </value>
        [DatevField(156,1)]
        public string BillingCity { get; set; }

        /// <summary>
        /// Gets or sets the billing country.
        /// </summary>
        ///
        /// <value>
        /// The billing country.
        /// </value>
        [DatevField(157,1)]
        public Country? BillingCountry { get; set; }

        /// <summary>
        /// Gets or sets the billing transport addition.
        /// </summary>
        ///
        /// <value>
        /// The billing transport addition.
        /// </value>
        [DatevField(158,1)]
        public string BillingTransportAddition { get; set; }

        /// <summary>
        /// Gets or sets the billing address addition.
        /// </summary>
        ///
        /// <value>
        /// The billing address addition.
        /// </value>
        [DatevField(159,1)]
        public string BillingAddressAddition { get; set; }

        /// <summary>
        /// Gets or sets the billing delivery directive 1.
        /// </summary>
        ///
        /// <value>
        /// The billing delivery directive 1.
        /// </value>
        [DatevField(160,1)]
        public string BillingDeliveryDirective1 { get; set; }

        /// <summary>
        /// Gets or sets the billing delivery directive 2.
        /// </summary>
        ///
        /// <value>
        /// The billing delivery directive 2.
        /// </value>
        [DatevField(161,1)]
        public string BillingDeliveryDirective2 { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the billing valid from.
        /// </summary>
        ///
        /// <value>
        /// The billing valid from.
        /// </value>
        [DatevField(162,1)]
        public DateTime? BillingValidFrom { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the billing valid till.
        /// </summary>
        ///
        /// <value>
        /// The billing valid till.
        /// </value>
        [DatevField(163,1)]
        public DateTime? BillingValidTill { get; set; }

        /// <summary>
        /// Gets or sets the external account number.
        /// </summary>
        ///
        /// <value>
        /// The external account number.
        /// </value>
        [DatevField(219,2)]
        public string ExternalAccountNumber { get; set; }
    }
}