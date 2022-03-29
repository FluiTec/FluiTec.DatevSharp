using System;
using FluiTec.DatevSharp.Attributes;
using FluiTec.DatevSharp.Rows.Enums;

namespace FluiTec.DatevSharp.Rows.BookingRow
{
	public partial class BookingRow
	{
		/// <summary>   Gets or sets the volume. </summary>
		///
		/// <value> The volume. </value>
		/// <remarks>
		/// MaxLength=13
		/// </remarks>
        [DatevField(0,1)]
		public decimal Volume { get; set; }

		/// <summary>   Gets or sets the claim. </summary>
		///
		/// <value> The claim. </value>
		/// <remarks>
		/// S/H (Soll/Haben)         
		/// </remarks>
        [DatevField(1,1)]
		public Claim Claim { get; set; }

		/// <summary>   Gets or sets the currency symbol. </summary>
		///
		/// <value> The currency symbol. </value>
		/// <remarks>
		/// MaxLength=3, ISO 4217, see https://msdn.microsoft.com/de-de/library/system.globalization.regioninfo.isocurrencysymbol(v=vs.110).aspx
		/// </remarks>
        [DatevField(2,1)]
		public string CurrencySymbol { get; set; }

		/// <summary>   Gets or sets the exchange rage. </summary>
		///
		/// <value> The exchange rage. </value>
		/// <remarks>
		/// Must be either NULL OR > 0         
		/// </remarks>
        [DatevField(3,1)]
		public decimal? ExchangeRage { get; set; }

		/// <summary>   Gets or sets the basic volume. </summary>
		///
		/// <value> The basic volume. </value>
        [DatevField(4,1)]
		public decimal? BasicVolume { get; set; }

		/// <summary>   Gets or sets the basic volume currency symbol. </summary>
		///
		/// <value> The basic volume currency symbol. </value>
		/// <remarks>
		/// Can be NULL
		/// MaxLength=3, ISO 4217, see https://msdn.microsoft.com/de-de/library/system.globalization.regioninfo.isocurrencysymbol(v=vs.110).aspx
		/// </remarks>
        [DatevField(5,1)]
		public string BasicVolumeCurrencySymbol { get; set; }

		/// <summary>   Gets or sets the account number. </summary>
		///
		/// <value> The account number. </value>
		/// <remarks>
		/// MaxLength=9         
		/// </remarks>
        [DatevField(6,1)]
		public string AccountNumber { get; set; }

		/// <summary>   Gets or sets the contra account number. </summary>
		///
		/// <value> The contra account number. </value>
		/// <remarks>
		/// MaxLength=9         
		/// </remarks>
        [DatevField(7,1)]
		public string ContraAccountNumber { get; set; }

		/// <summary>   Gets or sets the tax key. </summary>
		///
		/// <value> The tax key. </value>
		/// <remarks>
		/// BU-Schlüssel, Length=2-4         
		/// </remarks>
        [DatevField(8,1)]
		public string TaxKey { get; set; }

		/// <summary>   Gets or sets the Date/Time of the date. </summary>
		///
		/// <value> The date. </value>
		/// <remarks>
		/// Not Null         
		/// </remarks>
        [DatevField(9,1)]
		public DateTime? Date { get; set; }

		/// <summary>   Gets or sets the document field 1. </summary>
		///
		/// <value> The document field 1. </value>
		/// <remarks>
		/// MaxLength=36         
		/// </remarks>
        [DatevField(10,1)]
		public string DocumentField1 { get; set; }

		/// <summary>   Gets or sets the document field 2. </summary>
		///
		/// <value> The document field 2. </value>
		/// <remarks>
		/// MaxLength=12         
		/// </remarks>
        [DatevField(11,1)]
		public string DocumentField2 { get; set; }

		/// <summary>   Gets or sets the cash discount. </summary>
		///
		/// <value> The cash discount. </value>
		/// <remarks>
		/// Must not be 0, NULL however is allowed         
		/// </remarks>
        [DatevField(12,1)]
		public decimal? CashDiscount { get; set; }

        /// <summary>   Gets or sets the booking text. </summary>
        ///
        /// <value> The booking text. </value>
        /// <remarks>
        /// MaxLength=60         
        /// </remarks>
        [DatevField(13, 1)]
        public string BookingText { get; set; }

        /// <summary>   Gets or sets the blocked. </summary>
        ///
        /// <value> The blocked. </value>
        [DatevField(14, 1)]
        public bool? Blocked { get; set; }

        /// <summary>   Gets or sets the diverse account number. </summary>
        ///
        /// <value> The diverse account number. </value>
        /// <remarks>
        /// MaxLenght=9         
        /// </remarks>
        [DatevField(15, 1)]
        public string DiverseAccountNumber { get; set; }

		/// <summary>   Gets or sets the partner bank. </summary>
		///
		/// <value> The partner bank. </value>
		/// <remarks>
		/// MaxLength=3
		/// </remarks>
		[DatevField(16, 1)]
        public string PartnerBank { get; set; }

		/// <summary>   Gets or sets the circumstances. </summary>
		///
		/// <value> The circumstances. </value>
		/// <remarks>
		/// MaxLength=2
		/// 31 = Mahnzins
		/// 40 = Mahngebühr
		/// </remarks>
		[DatevField(17, 1)]
        public string Circumstances { get; set; }

		/// <summary>   Gets or sets a value indicating whether the interest block. </summary>
		///
		/// <value> true if interest block, false if not. </value>
		/// <remarks>
		/// Zinsberechnungssperre         
		/// </remarks>
		[DatevField(18, 1)]
        public bool? InterestBlock { get; set; }

		/// <summary>   Gets or sets the document link. </summary>
		///
		/// <value> The document link. </value>
		/// <remarks>
		/// MaxLength=210         
		/// </remarks>
		[DatevField(19, 1)]
        public string DocumentLink { get; set; }

        /// <summary>   Gets or sets the type of the payment. </summary>
        ///
        /// <value> The type of the payment. </value>
        /// <remarks>
        /// MaxLength=2
        /// 1 = Lastschrift
        /// 2 = Mahnung
        /// 3 = Zahlung
        /// </remarks>
        [DatevField(89, 2)]
        public PaymentType PaymentType { get; set; }

		/// <summary>   Gets or sets the type of the cash discount. </summary>
		///
		/// <value> The type of the cash discount. </value>
		/// <remarks>
		/// MaxLength=1,
		/// 1 = Einkauf von Waren
		/// 2 = Erwerb von Roh-Hilfs- und Betriebsstoffen
		/// </remarks>
		[DatevField(93,2)]
        public CashDiscountType CashDiscountType { get; set; }

        /// <summary>   Gets or sets the type of the booking. </summary>
        ///
        /// <value> The type of the booking. </value>
        /// <remarks>
        /// MaxLength=2
        /// AA = Angeforderte Anzahlung/
        ///		 Abschlagsrechnung
        /// AG = Erhaltene Anzahlung(Geldeingang)
        /// AV = Erhaltene Anzahlung(Verbindlichkeit)
        /// SR = Schlussrechnung
        /// SU = Schlussrechnung(Umbuchung)
        /// SG = Schlussrechnung(Geldeingang)
        /// SO = Sonstige
        /// </remarks>
        [DatevField(95, 4)]
        public BookingType BookingType { get; set; }

        /// <summary>
        /// Gets the source for the.
        /// </summary>
        ///
        /// <value>
        /// The source.
        /// </value>
		[DatevField(101,4)]
        public string Source => "SV";

		/// <summary>   Gets or sets the cash discount block. </summary>
		///
		/// <value> The cash discount block. </value>
		[DatevField(105,5)]
        public bool? CashDiscountBlock { get; set; }

		/// <summary>   Gets or sets the proprietor. </summary>
		///
		/// <value> The proprietor. </value>
		/// <remarks>
		/// MaxLength=76         
		/// </remarks>
		[DatevField(106, 5)]
        public string Proprietor { get; set; }

        /// <summary>   Gets or sets a value indicating whether the fixing. </summary>
        ///
        /// <value> true if fixing, false if not. </value>
		/// <remarks>
        /// Default=false         
        /// </remarks>
        [DatevField(113, 7)]
		public bool Fixing { get; set; }

		/// <summary>   Gets or sets the activity date. </summary>
		///
		/// <value> The activity date. </value>
		[DatevField(114, 7)]
        [DatevField(115, 7)]
		public DateTime? ActivityDate { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        ///
        /// <value>
        /// The due date.
        /// </value>
        [DatevField(116, 8)]
		public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the general reversal.
        /// </summary>
        ///
        /// <value>
        /// The general reversal.
        /// </value>
		[DatevField(117, 9)]
		public bool? GeneralReversal { get; set; }

        /// <summary>
        /// Gets or sets the tax rate.
        /// </summary>
        ///
        /// <value>
        /// The tax rate.
        /// </value>
        [DatevField(118,9)]
		public float? TaxRate { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        ///
        /// <value>
        /// The country.
        /// </value>
        [DatevField(119,9)]
		public Country? Country { get; set; }

		[DatevField(120,10)]
		public string SettlementReference { get; set; }

        /// <summary>
        /// Gets or sets the accruals basis accounting.
        /// </summary>
        ///
        /// <value>
        /// The accruals basis accounting.
        /// </value>
        [DatevField(121,11)]
		public AccrualsBasisAccounting? AccrualsBasisAccounting { get; set; }

        /// <summary>   Gets or sets the identifier of the country code and tax. </summary>
        ///
        /// <value> The identifier of the country code and tax. </value>
        /// <remarks>
        /// MaxLength=15         
        /// </remarks>
        [DatevField(122,12)]
		public string StateCodeAndTaxId { get; set; }

        /// <summary>
        /// Gets or sets the tax rate.
        /// </summary>
        ///
        /// <value>
        /// The tax rate.
        /// </value>
        [DatevField(123, 12)]
        public float? EuTaxRate { get; set; }
	}
}