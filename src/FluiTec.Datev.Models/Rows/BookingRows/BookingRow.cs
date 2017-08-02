using FluiTec.Datev.Models.Helpers;

namespace FluiTec.Datev.Models.Rows
{
	/// <summary>   A booking row. </summary>
	public partial class BookingRow : IDatevRow
	{
		/// <summary>	Default constructor. </summary>
		/// <param name="isoCurrencySymbol">	The ISO currency symbol. </param>
		public BookingRow(string isoCurrencySymbol)
		{
			Claim = "S";
			CurrencySymbol = isoCurrencySymbol;
			Fixing = false;
		}

		#region Methods

		/// <summary>   Converts this object to a row. </summary>
		/// <returns>   This object as a string. </returns>
		public string ToRow()
		{
			return
				$"{Volume.ToDatev()};{Claim.ToDatev()};{CurrencySymbol.ToDatev()};{ExchangeRage.ToDatev()};{BasicVolume.ToDatev()};{BasicVolumeCurrencySymbol.ToDatev()};{AccountNumber.ToDatev()};{ContraAccountNumber.ToDatev()};{TaxKey.ToDatev()};{Date.ToShortDatevDate()};{DocumentField1.ToDatev()};{DocumentField2.ToDatev()};{CashDiscount.ToDatev()};{BookingText.ToDatev()};{Blocked.ToDatev()};{DiverseAccountNumber.ToDatev()};{PartnerBank.ToDatev()};{Circumstances.ToDatev()};{InterestBlock.ToDatev()};{DocumentLink.ToDatev()};{BookingInfoType1.ToDatev()};{BookingInfoContent1.ToDatev()};{BookingInfoType2.ToDatev()};{BookingInfoContent2.ToDatev()};{BookingInfoType3.ToDatev()};{BookingInfoContent3.ToDatev()};{BookingInfoType4.ToDatev()};{BookingInfoContent4.ToDatev()};{BookingInfoType5.ToDatev()};{BookingInfoContent5.ToDatev()};{BookingInfoType6.ToDatev()};{BookingInfoContent6.ToDatev()};{BookingInfoType7.ToDatev()};{BookingInfoContent7.ToDatev()};{BookingInfoType8.ToDatev()};{BookingInfoContent8.ToDatev()};{CostCenter1.ToDatev()};{CostCenter2.ToDatev()};{CostAmount.ToDatev()};{CountryCodeAndTaxId.ToDatev()};{EuroTax.ToDatev()};{DifferentTaxType.ToDatev()};{IntentionLL.ToDatev()};{FunctionLL.ToDatev()};{BU49FunctionType.ToDatev()};{BU49FunctionNumber.ToDatev()};{BU49FunctionAddition.ToDatev()};{AdditionalInfoType1.ToDatev()};{AdditionalInfoContent1.ToDatev()};{AdditionalInfoType2.ToDatev()};{AdditionalInfoContent2.ToDatev()};{AdditionalInfoType3.ToDatev()};{AdditionalInfoContent3.ToDatev()};{AdditionalInfoType4.ToDatev()};{AdditionalInfoContent4.ToDatev()};{AdditionalInfoType5.ToDatev()};{AdditionalInfoContent5.ToDatev()};{AdditionalInfoType6.ToDatev()};{AdditionalInfoContent6.ToDatev()};{AdditionalInfoType7.ToDatev()};{AdditionalInfoContent7.ToDatev()};{AdditionalInfoType8.ToDatev()};{AdditionalInfoContent8.ToDatev()};{AdditionalInfoType9.ToDatev()};{AdditionalInfoContent9.ToDatev()};{AdditionalInfoType10.ToDatev()};{AdditionalInfoContent10.ToDatev()};{AdditionalInfoType11.ToDatev()};{AdditionalInfoContent11.ToDatev()};{AdditionalInfoType12.ToDatev()};{AdditionalInfoContent12.ToDatev()};{AdditionalInfoType13.ToDatev()};{AdditionalInfoContent13.ToDatev()};{AdditionalInfoType14.ToDatev()};{AdditionalInfoContent14.ToDatev()};{AdditionalInfoType15.ToDatev()};{AdditionalInfoContent15.ToDatev()};{AdditionalInfoType16.ToDatev()};{AdditionalInfoContent16.ToDatev()};{AdditionalInfoType17.ToDatev()};{AdditionalInfoContent17.ToDatev()};{AdditionalInfoType18.ToDatev()};{AdditionalInfoContent18.ToDatev()};{AdditionalInfoType19.ToDatev()};{AdditionalInfoContent19.ToDatev()};{AdditionalInfoType20.ToDatev()};{AdditionalInfoContent20.ToDatev()};{Amount.ToDatev()};{Weight.ToDatev()};{PaymentType.ToDatev()};{ClaimType.ToDatev()};{CommunalYear.ToShortDatevYear()};{CommunalDueYear.ToShortDatevYear()};{CashDiscountType.ToDatev()};{OrderNumber.ToDatev()};{BookingType.ToDatev()};{TaxKeyPrepayment.ToDatev()};{CountryCodePrePayment.ToDatev()};{IntentionLLPrepayment.ToDatev()};{EuroTaxPrepayment.ToDatev()};{AccountNumberPrepayment.ToDatev()};\"SV\";\"\";{CostDate.ToDatevDateReverse()};{SepaReference.ToDatev()};{CashDiscountBlock.ToDatev()};{Proprietor.ToDatev()};{ParticipantNumber.ToDatev()};{IdentificationNumber.ToDatev()};{PainterNumber.ToDatev()};{BatchBlockTill.ToDatevDateReverse()};{SoBilIntention.ToDatev()};{SoBilKey.ToDatev()};{Fixing.ToDatev()};{ActivityDate.ToDatevDateReverse()};{ActivityDate.ToDatevDateReverse()}";
		}

		#endregion
	}
}