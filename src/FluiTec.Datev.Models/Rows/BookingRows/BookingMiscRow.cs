using System;

namespace FluiTec.Datev.Models.Rows
{
	public partial class BookingRow
	{
		/// <summary>   Gets the cost center 1. </summary>
		/// <value> The cost center 1. </value>
		/// <remarks>
		///     MaxLenght=8
		/// </remarks>
		public string CostCenter1 { get; set; }

		/// <summary>   Gets the cost center 2. </summary>
		/// <value> The cost center 2. </value>
		/// <remarks>
		///     MaxLenght=8
		/// </remarks>
		public string CostCenter2 { get; set; }

		/// <summary>   Gets or sets the cost amount. </summary>
		/// <value> The cost amount. </value>
		/// <remarks>
		///     May be NULL, >0 and less than max
		/// </remarks>
		public decimal? CostAmount { get; set; }

		/// <summary>   Gets or sets the identifier of the country code and tax. </summary>
		/// <value> The identifier of the country code and tax. </value>
		/// <remarks>
		///     MaxLength=15
		/// </remarks>
		public string CountryCodeAndTaxId { get; set; }

		/// <summary>   Gets or sets the euro tax. </summary>
		/// <value> The euro tax. </value>
		/// <remarks>
		///     NULL, >0 lte: 99.99
		/// </remarks>
		public decimal? EuroTax { get; set; }

		/// <summary>   Gets or sets the type of the different tax. </summary>
		/// <value> The type of the different tax. </value>
		/// <remarks>
		///     MaxLength=1
		///     I = Ist-Versteuerung
		///     K = keine Umsatzsteuerrechnung
		///     P = Pauschalierung(z.B.für Land- und Forstwirtschaft)
		///     S = Soll-Versteuerung
		/// </remarks>
		public string DifferentTaxType { get; set; }

		/// <summary>   Gets or sets the intention ll. </summary>
		/// <value> The intention ll. </value>
		/// <remarks>
		///     MaxLength=3
		/// </remarks>
		public int? IntentionLL { get; set; }

		/// <summary>   Gets or sets the function ll. </summary>
		/// <value> The function ll. </value>
		/// <remarks>
		///     MaxLength=3
		/// </remarks>
		public int? FunctionLL { get; set; }

		/// <summary>   Gets or sets the type of the bu 49 function. </summary>
		/// <value> The type of the bu 49 function. </value>
		/// <remarks>
		///     MaxLength=1
		/// </remarks>
		public int? BU49FunctionType { get; set; }

		/// <summary>   Gets or sets the bu 49 function number. </summary>
		/// <value> The bu 49 function number. </value>
		/// <remarks>
		///     MaxLength=2
		/// </remarks>
		public int? BU49FunctionNumber { get; set; }

		/// <summary>   Gets or sets the bu 49 function addition. </summary>
		/// <value> The bu 49 function addition. </value>
		/// <remarks>
		///     MaxLength=3
		/// </remarks>
		public int? BU49FunctionAddition { get; set; }

		/// <summary>   Gets or sets the amount. </summary>
		/// <value> The amount. </value>
		/// <remarks>
		///     MaxLength=8
		/// </remarks>
		public int? Amount { get; set; }

		/// <summary>   Gets or sets the weight. </summary>
		/// <value> The weight. </value>
		/// <remarks>
		///     MaxLength=11
		/// </remarks>
		public decimal? Weight { get; set; }

		/// <summary>   Gets or sets the type of the claim. </summary>
		/// <value> The type of the claim. </value>
		/// <remarks>
		///     MaxLength=10
		/// </remarks>
		public string ClaimType { get; set; }

		/// <summary>   Gets or sets the Date/Time of the communal year. </summary>
		/// <value> The communal year. </value>
		/// <remarks>
		///     MaxLength=4
		/// </remarks>
		public DateTime? CommunalYear { get; set; }

		/// <summary>   Gets or sets the Date/Time of the communal due year. </summary>
		/// <value> The communal due year. </value>
		/// <remarks>
		///     MaxLength=4
		/// </remarks>
		public DateTime? CommunalDueYear { get; set; }

		/// <summary>   Gets or sets the order number. </summary>
		/// <value> The order number. </value>
		/// <remarks>
		///     MaxLength=30
		/// </remarks>
		public string OrderNumber { get; set; }

		/// <summary>   Gets or sets the tax key prepayment. </summary>
		/// <value> The tax key prepayment. </value>
		/// <remarks>
		///     MaxLength=2
		/// </remarks>
		public int? TaxKeyPrepayment { get; set; }

		/// <summary>   Gets or sets the country code pre payment. </summary>
		/// <value> The country code pre payment. </value>
		/// <remarks>
		///     MaxLength=2
		/// </remarks>
		public string CountryCodePrePayment { get; set; }

		/// <summary>   Gets or sets the intention ll prepayment. </summary>
		/// <value> The intention ll prepayment. </value>
		/// <remarks>
		///     MaxLength=3
		/// </remarks>
		public int? IntentionLLPrepayment { get; set; }

		/// <summary>   Gets or sets the tax prepayment. </summary>
		/// <value> The tax prepayment. </value>
		/// <remarks>
		///     MaxLength=5
		/// </remarks>
		public decimal? EuroTaxPrepayment { get; set; }

		/// <summary>   Gets or sets the account number prepayment. </summary>
		/// <value> The account number prepayment. </value>
		/// <remarks>
		///     MaxLength=9
		/// </remarks>
		public string AccountNumberPrepayment { get; set; }

		/// <summary>   Gets or sets the cost date. </summary>
		/// <value> The cost date. </value>
		/// <remarks>
		///     MaxLength=6
		/// </remarks>
		public DateTime? CostDate { get; set; }

		/// <summary>   Gets or sets the sepa reference. </summary>
		/// <value> The sepa reference. </value>
		/// <remarks>
		///     MaxLength=35
		/// </remarks>
		public string SepaReference { get; set; }

		/// <summary>   Gets or sets the participant number. </summary>
		/// <value> The participant number. </value>
		/// <remarks>
		///     MaxLength=4
		/// </remarks>
		public int? ParticipantNumber { get; set; }

		/// <summary>   Gets or sets the identification number. </summary>
		/// <value> The identification number. </value>
		/// <remarks>
		///     MaxLength=11
		/// </remarks>
		public string IdentificationNumber { get; set; }

		/// <summary>   Gets or sets the painter number. </summary>
		/// <value> The painter number. </value>
		/// <remarks>
		///     MaxLength=20
		/// </remarks>
		public string PainterNumber { get; set; }

		/// <summary>   Gets or sets the Date/Time of the batch block till. </summary>
		/// <value> The batch block till. </value>
		public DateTime? BatchBlockTill { get; set; }

		/// <summary>   Gets or sets the so bil intention. </summary>
		/// <value> The so bil intention. </value>
		/// <remarks>
		///     MaxLength=30
		/// </remarks>
		public string SoBilIntention { get; set; }

		/// <summary>   Gets or sets the so bil key. </summary>
		/// <value> The so bil key. </value>
		/// <remarks>
		///     MaxLength=2
		/// </remarks>
		public int? SoBilKey { get; set; }
	}
}