using System;
using FluiTec.DatevSharp.Attributes;
using FluiTec.DatevSharp.Interfaces;
using FluiTec.DatevSharp.Rows.Enums;
using FluiTec.DatevSharp.Rows.Maps;

namespace FluiTec.DatevSharp.Rows.AddressRow
{
    /// <summary>   The address row. </summary>
    [DatevRow(typeof(AddressMap), typeof(HeaderRow))]
    public class AddressRow : IDatevRow
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
        /// Gets or sets the bank code 1.
        /// </summary>
        ///
        /// <value>
        /// The bank code 1.
        /// </value>
        [DatevField(40, 1)]
        public string BankCode1 { get; set; }

        /// <summary>
        /// Gets or sets the bank name 1.
        /// </summary>
        ///
        /// <value>
        /// The bank name 1.
        /// </value>
        [DatevField(41, 1)]
        public string BankName1 { get; set; }

        /// <summary>
        /// Gets or sets the bank account number 1.
        /// </summary>
        ///
        /// <value>
        /// The bank account number 1.
        /// </value>
        [DatevField(42, 1)]
        public string BankAccountNumber1 { get; set; }

        /// <summary>
        /// Gets or sets the bank country 1.
        /// </summary>
        ///
        /// <value>
        /// The bank country 1.
        /// </value>
        [DatevField(43, 1)]
        public Country? BankCountry1 { get; set; }

        /// <summary>
        /// Gets or sets the iban 1.
        /// </summary>
        ///
        /// <value>
        /// The iban 1.
        /// </value>
        [DatevField(44, 1)]
        public string Iban1 { get; set; }

        /// <summary>
        /// Gets or sets the iban 1 correct.
        /// </summary>
        ///
        /// <value>
        /// The iban 1 correct.
        /// </value>
        [DatevField(45, 1)]
        public bool? Iban1Correct { get; set; }

        /// <summary>
        /// Gets or sets the swift 1.
        /// </summary>
        ///
        /// <value>
        /// The swift 1.
        /// </value>
        [DatevField(46, 1)]
        public string Swift1 { get; set; }

        /// <summary>
        /// Gets or sets the divergent account holder 1.
        /// </summary>
        ///
        /// <value>
        /// The divergent account holder 1.
        /// </value>
        [DatevField(47, 1)]
        public string DivergentAccountHolder1 { get; set; }

        /// <summary>
        ///     Gets the marker main banking account 1.
        /// </summary>
        /// <value>
        ///     The marker main banking account 1.
        /// </value>
        [DatevField(48, 1)]
        public bool MarkerMainBankingAccount1 { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the bank valid from 1.
        /// </summary>
        ///
        /// <value>
        /// The bank valid from 1.
        /// </value>
        [DatevField(49, 1)]
        public DateTime? BankValidFrom1 { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the bank valid till 1.
        /// </summary>
        ///
        /// <value>
        /// The bank valid till 1.
        /// </value>
        [DatevField(50, 1)]
        public DateTime? BankValidTill1 { get; set; }

        /// <summary>
        /// Gets or sets the bank code 2.
        /// </summary>
        ///
        /// <value>
        /// The bank code 2.
        /// </value>
        [DatevField(51, 1)]
        public string BankCode2 { get; set; }

        /// <summary>
        /// Gets or sets the bank name 2.
        /// </summary>
        ///
        /// <value>
        /// The bank name 2.
        /// </value>
        [DatevField(52, 1)]
        public string BankName2 { get; set; }

        /// <summary>
        /// Gets or sets the bank account number 2.
        /// </summary>
        ///
        /// <value>
        /// The bank account number 2.
        /// </value>
        [DatevField(53, 1)]
        public string BankAccountNumber2 { get; set; }

        /// <summary>
        /// Gets or sets the bank country 2.
        /// </summary>
        ///
        /// <value>
        /// The bank country 2.
        /// </value>
        [DatevField(54, 1)]
        public Country? BankCountry2 { get; set; }

        /// <summary>
        /// Gets or sets the iban 2.
        /// </summary>
        ///
        /// <value>
        /// The iban 2.
        /// </value>
        [DatevField(55, 1)]
        public string Iban2 { get; set; }

        /// <summary>
        /// Gets or sets the iban 2 correct.
        /// </summary>
        ///
        /// <value>
        /// The iban 2 correct.
        /// </value>
        [DatevField(56, 1)]
        public bool? Iban2Correct { get; set; }

        /// <summary>
        /// Gets or sets the swift 2.
        /// </summary>
        ///
        /// <value>
        /// The swift 2.
        /// </value>
        [DatevField(57, 1)]
        public string Swift2 { get; set; }

        /// <summary>
        /// Gets or sets the divergent account holder 2.
        /// </summary>
        ///
        /// <value>
        /// The divergent account holder 2.
        /// </value>
        [DatevField(58, 1)]
        public string DivergentAccountHolder2 { get; set; }

        /// <summary>
        ///     Gets the marker main banking account 2.
        /// </summary>
        /// <value>
        ///     The marker main banking account 2.
        /// </value>
        [DatevField(59, 1)]
        public bool MarkerMainBankingAccount2 { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the bank valid from 2.
        /// </summary>
        ///
        /// <value>
        /// The bank valid from 2.
        /// </value>
        [DatevField(60, 1)]
        public DateTime? BankValidFrom2 { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the bank valid till 2.
        /// </summary>
        ///
        /// <value>
        /// The bank valid till 2.
        /// </value>
        [DatevField(61, 1)]
        public DateTime? BankValidTill2 { get; set; }

        /// <summary>
        /// Gets or sets the bank code 3.
        /// </summary>
        ///
        /// <value>
        /// The bank code 3.
        /// </value>
        [DatevField(62, 1)]
        public string BankCode3 { get; set; }

        /// <summary>
        /// Gets or sets the bank name 3.
        /// </summary>
        ///
        /// <value>
        /// The bank name 3.
        /// </value>
        [DatevField(63, 1)]
        public string BankName3 { get; set; }

        /// <summary>
        /// Gets or sets the bank account number 3.
        /// </summary>
        ///
        /// <value>
        /// The bank account number 3.
        /// </value>
        [DatevField(64, 1)]
        public string BankAccountNumber3 { get; set; }

        /// <summary>
        /// Gets or sets the bank country 3.
        /// </summary>
        ///
        /// <value>
        /// The bank country 3.
        /// </value>
        [DatevField(65, 1)]
        public Country? BankCountry3 { get; set; }

        /// <summary>
        /// Gets or sets the iban 3.
        /// </summary>
        ///
        /// <value>
        /// The iban 3.
        /// </value>
        [DatevField(66, 1)]
        public string Iban3 { get; set; }

        /// <summary>
        /// Gets or sets the iban 3 correct.
        /// </summary>
        ///
        /// <value>
        /// The iban 3 correct.
        /// </value>
        [DatevField(67, 1)]
        public bool? Iban3Correct { get; set; }

        /// <summary>
        /// Gets or sets the swift 3.
        /// </summary>
        ///
        /// <value>
        /// The swift 3.
        /// </value>
        [DatevField(68, 1)]
        public string Swift3 { get; set; }

        /// <summary>
        /// Gets or sets the divergent account holder 3.
        /// </summary>
        ///
        /// <value>
        /// The divergent account holder 3.
        /// </value>
        [DatevField(69, 1)]
        public string DivergentAccountHolder3 { get; set; }

        /// <summary>
        ///     Gets the marker main banking account 3.
        /// </summary>
        /// <value>
        ///     The marker main banking account 3.
        /// </value>
        [DatevField(70, 1)]
        public bool MarkerMainBankingAccount3 { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the bank valid from 3.
        /// </summary>
        ///
        /// <value>
        /// The bank valid from 3.
        /// </value>
        [DatevField(71, 1)]
        public DateTime? BankValidFrom3 { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the bank valid till 3.
        /// </summary>
        ///
        /// <value>
        /// The bank valid till 3.
        /// </value>
        [DatevField(72, 1)]
        public DateTime? BankValidTill3 { get; set; }

        /// <summary>
        /// Gets or sets the bank code 4.
        /// </summary>
        ///
        /// <value>
        /// The bank code 4.
        /// </value>
        [DatevField(73, 1)]
        public string BankCode4 { get; set; }

        /// <summary>
        /// Gets or sets the bank name 4.
        /// </summary>
        ///
        /// <value>
        /// The bank name 4.
        /// </value>
        [DatevField(74, 1)]
        public string BankName4 { get; set; }

        /// <summary>
        /// Gets or sets the bank account number 4.
        /// </summary>
        ///
        /// <value>
        /// The bank account number 4.
        /// </value>
        [DatevField(75, 1)]
        public string BankAccountNumber4 { get; set; }

        /// <summary>
        /// Gets or sets the bank country 4.
        /// </summary>
        ///
        /// <value>
        /// The bank country 4.
        /// </value>
        [DatevField(76, 1)]
        public Country? BankCountry4 { get; set; }

        /// <summary>
        /// Gets or sets the iban 4.
        /// </summary>
        ///
        /// <value>
        /// The iban 4.
        /// </value>
        [DatevField(77, 1)]
        public string Iban4 { get; set; }

        /// <summary>
        /// Gets or sets the iban 4 correct.
        /// </summary>
        ///
        /// <value>
        /// The iban 4 correct.
        /// </value>
        [DatevField(78, 1)]
        public bool? Iban4Correct { get; set; }

        /// <summary>
        /// Gets or sets the swift 4.
        /// </summary>
        ///
        /// <value>
        /// The swift 4.
        /// </value>
        [DatevField(79, 1)]
        public string Swift4 { get; set; }

        /// <summary>
        /// Gets or sets the divergent account holder 4.
        /// </summary>
        ///
        /// <value>
        /// The divergent account holder 4.
        /// </value>
        [DatevField(80, 1)]
        public string DivergentAccountHolder4 { get; set; }

        /// <summary>
        ///     Gets the marker main banking account 4.
        /// </summary>
        /// <value>
        ///     The marker main banking account 4.
        /// </value>
        [DatevField(81, 1)]
        public bool MarkerMainBankingAccount4 { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the bank valid from 4.
        /// </summary>
        ///
        /// <value>
        /// The bank valid from 4.
        /// </value>
        [DatevField(82, 1)]
        public DateTime? BankValidFrom4 { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the bank valid till 4.
        /// </summary>
        ///
        /// <value>
        /// The bank valid till 4.
        /// </value>
        [DatevField(83, 1)]
        public DateTime? BankValidTill4 { get; set; }

        /// <summary>
        /// Gets or sets the bank code 5.
        /// </summary>
        ///
        /// <value>
        /// The bank code 5.
        /// </value>
        [DatevField(84, 1)]
        public string BankCode5 { get; set; }

        /// <summary>
        /// Gets or sets the bank name 5.
        /// </summary>
        ///
        /// <value>
        /// The bank name 5.
        /// </value>
        [DatevField(85, 1)]
        public string BankName5 { get; set; }

        /// <summary>
        /// Gets or sets the bank account number 5.
        /// </summary>
        ///
        /// <value>
        /// The bank account number 5.
        /// </value>
        [DatevField(86, 1)]
        public string BankAccountNumber5 { get; set; }

        /// <summary>
        /// Gets or sets the bank country 5.
        /// </summary>
        ///
        /// <value>
        /// The bank country 5.
        /// </value>
        [DatevField(87, 1)]
        public Country? BankCountry5 { get; set; }

        /// <summary>
        /// Gets or sets the iban 5.
        /// </summary>
        ///
        /// <value>
        /// The iban 5.
        /// </value>
        [DatevField(88, 1)]
        public string Iban5 { get; set; }

        /// <summary>
        /// Gets or sets the iban 5 correct.
        /// </summary>
        ///
        /// <value>
        /// The iban 5 correct.
        /// </value>
        [DatevField(89, 1)]
        public bool? Iban5Correct { get; set; }

        /// <summary>
        /// Gets or sets the swift 5.
        /// </summary>
        ///
        /// <value>
        /// The swift 5.
        /// </value>
        [DatevField(90, 1)]
        public string Swift5 { get; set; }

        /// <summary>
        /// Gets or sets the divergent account holder 5.
        /// </summary>
        ///
        /// <value>
        /// The divergent account holder 5.
        /// </value>
        [DatevField(91, 1)]
        public string DivergentAccountHolder5 { get; set; }

        /// <summary>
        ///     Gets the marker main banking account 5.
        /// </summary>
        /// <value>
        ///     The marker main banking account 5.
        /// </value>
        [DatevField(92, 1)]
        public bool MarkerMainBankingAccount5 { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the bank valid from 5.
        /// </summary>
        ///
        /// <value>
        /// The bank valid from 5.
        /// </value>
        [DatevField(93, 1)]
        public DateTime? BankValidFrom5 { get; set; }

        /// <summary>
        /// Gets or sets the Date/Time of the bank valid till 5.
        /// </summary>
        ///
        /// <value>
        /// The bank valid till 5.
        /// </value>
        [DatevField(94, 1)]
        public DateTime? BankValidTill5 { get; set; }
    }
}