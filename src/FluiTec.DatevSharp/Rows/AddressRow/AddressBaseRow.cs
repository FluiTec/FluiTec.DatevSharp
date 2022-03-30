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
    }
}