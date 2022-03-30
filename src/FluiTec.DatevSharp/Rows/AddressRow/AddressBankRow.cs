using System;
using FluiTec.DatevSharp.Attributes;
using FluiTec.DatevSharp.Rows.Enums;

namespace FluiTec.DatevSharp.Rows.AddressRow
{
    /// <summary>
    /// The address row.
    /// </summary>
    public partial class AddressRow
    {
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

        /// <summary>
        /// Gets or sets the business partner bank.
        /// </summary>
        ///
        /// <value>
        /// The business partner bank.
        /// </value>
        [DatevField(95, 1)]
        public string BusinessPartnerBank { get; set; }
    }
}