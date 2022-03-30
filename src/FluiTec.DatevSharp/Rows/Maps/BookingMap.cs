using FluiTec.DatevSharp.Helpers;
using FluiTec.DatevSharp.Rows.Maps.Base;

namespace FluiTec.DatevSharp.Rows.Maps
{
    /// <summary>
    ///     Map of bookings.
    /// </summary>
    public class BookingMap : ClassMap<BookingRow.BookingRow>
    {
        /// <summary>
        ///     Default constructor.
        /// </summary>
        public BookingMap()
        {
            // base
            Map(row => row.Volume, row => row.Volume.ToDatev());
            Map(row => row.Claim, row => row.Claim.ToDatev());
            Map(row => row.CurrencySymbol, row => row.CurrencySymbol.ToDatev());
            Map(row => row.ExchangeRage, row => row.ExchangeRage.ToDatev());
            Map(row => row.BasicVolume, row => row.BasicVolume.ToDatev());
            Map(row => row.BasicVolumeCurrencySymbol, row => row.BasicVolumeCurrencySymbol.ToDatev());
            Map(row => row.AccountNumber, row => row.AccountNumber.ToDatev());
            Map(row => row.ContraAccountNumber, row => row.ContraAccountNumber.ToDatev());
            Map(row => row.TaxKey, row => row.TaxKey.ToDatev());
            Map(row => row.Date, row => row.Date.ToShortDatevDate());
            Map(row => row.DocumentField1, row => row.DocumentField1.ToDatev());
            Map(row => row.DocumentField2, row => row.DocumentField2.ToDatev());
            Map(row => row.CashDiscount, row => row.CashDiscount.ToDatev());
            Map(row => row.BookingText, row => row.BookingText.ToDatev());
            Map(row => row.Blocked, row => row.Blocked.ToDatev());
            Map(row => row.DiverseAccountNumber, row => row.DiverseAccountNumber.ToDatev());
            Map(row => row.PartnerBank, row => row.PartnerBank.ToDatev());
            Map(row => row.Circumstances, row => row.Circumstances.ToDatev());
            Map(row => row.InterestBlock, row => row.InterestBlock.ToDatev());
            Map(row => row.DocumentLink, row => row.DocumentLink.ToDatev());
            Map(row => row.PaymentType, row => row.PaymentType.ToDatev());
            Map(row => row.CashDiscountType, row => row.CashDiscountType.ToDatev());
            Map(row => row.BookingType, row => row.BookingType.ToDatev());
            Map(row => row.Source, row => row.Source.ToDatev());
            Map(row => row.CashDiscountBlock, row => row.CashDiscountBlock.ToDatev());
            Map(row => row.Proprietor, row => row.Proprietor.ToDatev());
            Map(row => row.Fixing, row => row.Fixing.ToDatev());
            Map(row => row.ActivityDate, row => row.ActivityDate.ToDatevDateReverse());
            Map(row => row.DueDate, row => row.DueDate.ToDatevDateReverse());
            Map(row => row.GeneralReversal, row => row.GeneralReversal.ToDatev().ToDatev());
            Map(row => row.TaxRate, row => row.TaxRate.ToDatev());
            Map(row => row.Country, row => row.Country.ToDatev());
            Map(row => row.SettlementReference, row => row.SettlementReference.ToDatev());
            Map(row => row.AccrualsBasisAccounting, row => row.AccrualsBasisAccounting?.ToDatev());
            Map(row => row.StateCodeAndTaxId, row => row.StateCodeAndTaxId.ToDatev());
            Map(row => row.EuTaxRate, row => row.EuTaxRate.ToDatev());

            // document
            Map(row => row.BookingInfoType1, row => row.BookingInfoType1.ToDatev());
            Map(row => row.BookingInfoContent1, row => row.BookingInfoContent1.ToDatev());
            Map(row => row.BookingInfoType2, row => row.BookingInfoType2.ToDatev());
            Map(row => row.BookingInfoContent2, row => row.BookingInfoContent2.ToDatev());
            Map(row => row.BookingInfoType3, row => row.BookingInfoType3.ToDatev());
            Map(row => row.BookingInfoContent3, row => row.BookingInfoContent3.ToDatev());
            Map(row => row.BookingInfoType4, row => row.BookingInfoType4.ToDatev());
            Map(row => row.BookingInfoContent4, row => row.BookingInfoContent4.ToDatev());
            Map(row => row.BookingInfoType5, row => row.BookingInfoType5.ToDatev());
            Map(row => row.BookingInfoContent5, row => row.BookingInfoContent5.ToDatev());
            Map(row => row.BookingInfoType6, row => row.BookingInfoType6.ToDatev());
            Map(row => row.BookingInfoContent6, row => row.BookingInfoContent6.ToDatev());
            Map(row => row.BookingInfoType7, row => row.BookingInfoType7.ToDatev());
            Map(row => row.BookingInfoContent7, row => row.BookingInfoContent7.ToDatev());
            Map(row => row.BookingInfoType8, row => row.BookingInfoType8.ToDatev());
            Map(row => row.BookingInfoContent8, row => row.BookingInfoContent8.ToDatev());

            // misc
            Map(row => row.CostCenter1, row => row.CostCenter1.ToDatev());
            Map(row => row.CostCenter2, row => row.CostCenter2.ToDatev());
            Map(row => row.CostAmount, row => row.CostAmount.ToDatev());
            Map(row => row.CountryCodeAndTaxId, row => row.CountryCodeAndTaxId.ToDatev());
            Map(row => row.EuroTax, row => row.EuroTax.ToDatev());
            Map(row => row.DifferentTaxType, row => row.DifferentTaxType.ToDatev());
            Map(row => row.IntentionLL, row => row.IntentionLL.ToDatev());
            Map(row => row.FunctionLL, row => row.FunctionLL.ToDatev());
            Map(row => row.BU49FunctionType, row => row.BU49FunctionType.ToDatev());
            Map(row => row.BU49FunctionNumber, row => row.BU49FunctionNumber.ToDatev());
            Map(row => row.BU49FunctionAddition, row => row.BU49FunctionAddition.ToDatev());
            Map(row => row.Amount, row => row.Amount.ToDatev());
            Map(row => row.Weight, row => row.Weight.ToDatev());
            Map(row => row.ClaimType, row => row.ClaimType.ToDatev());
            Map(row => row.CommunalYear, row => row.CommunalYear.ToShortDatevYear());
            Map(row => row.CommunalDueYear, row => row.CommunalDueYear.ToShortDatevYear());
            Map(row => row.OrderNumber, row => row.OrderNumber.ToDatev());
            Map(row => row.TaxKeyPrepayment, row => row.TaxKeyPrepayment.ToDatev());
            Map(row => row.CountryCodePrePayment, row => row.CountryCodePrePayment.ToDatev());
            Map(row => row.IntentionLLPrepayment, row => row.IntentionLLPrepayment.ToDatev());
            Map(row => row.EuroTaxPrepayment, row => row.EuroTaxPrepayment.ToDatev());
            Map(row => row.AccountNumberPrepayment, row => row.AccountNumberPrepayment.ToDatev());
            Map(row => row.BookingGuid, row => row.BookingGuid.ToDatev());
            Map(row => row.CostDate, row => row.CostDate.ToDatevDateReverse());
            Map(row => row.SepaReference, row => row.SepaReference.ToDatev());
            Map(row => row.ParticipantNumber, row => row.ParticipantNumber.ToDatev());
            Map(row => row.IdentificationNumber, row => row.IdentificationNumber.ToDatev());
            Map(row => row.PainterNumber, row => row.PainterNumber.ToDatev());
            Map(row => row.BatchBlockTill, row => row.BatchBlockTill.ToDatevDateReverse());
            Map(row => row.SoBilIntention, row => row.SoBilIntention.ToDatev());
            Map(row => row.SoBilKey, row => row.SoBilKey.ToDatev());

            // info
            Map(row => row.AdditionalInfoType1, row => row.AdditionalInfoType1.ToDatev());
            Map(row => row.AdditionalInfoContent1, row => row.AdditionalInfoContent1.ToDatev());
            Map(row => row.AdditionalInfoType2, row => row.AdditionalInfoType2.ToDatev());
            Map(row => row.AdditionalInfoContent2, row => row.AdditionalInfoContent2.ToDatev());
            Map(row => row.AdditionalInfoType3, row => row.AdditionalInfoType3.ToDatev());
            Map(row => row.AdditionalInfoContent3, row => row.AdditionalInfoContent3.ToDatev());
            Map(row => row.AdditionalInfoType4, row => row.AdditionalInfoType4.ToDatev());
            Map(row => row.AdditionalInfoContent4, row => row.AdditionalInfoContent4.ToDatev());
            Map(row => row.AdditionalInfoType5, row => row.AdditionalInfoType5.ToDatev());
            Map(row => row.AdditionalInfoContent5, row => row.AdditionalInfoContent5.ToDatev());
            Map(row => row.AdditionalInfoType6, row => row.AdditionalInfoType6.ToDatev());
            Map(row => row.AdditionalInfoContent6, row => row.AdditionalInfoContent6.ToDatev());
            Map(row => row.AdditionalInfoType7, row => row.AdditionalInfoType7.ToDatev());
            Map(row => row.AdditionalInfoContent7, row => row.AdditionalInfoContent7.ToDatev());
            Map(row => row.AdditionalInfoType8, row => row.AdditionalInfoType8.ToDatev());
            Map(row => row.AdditionalInfoContent8, row => row.AdditionalInfoContent8.ToDatev());
            Map(row => row.AdditionalInfoType9, row => row.AdditionalInfoType9.ToDatev());
            Map(row => row.AdditionalInfoContent9, row => row.AdditionalInfoContent9.ToDatev());
            Map(row => row.AdditionalInfoType10, row => row.AdditionalInfoType10.ToDatev());
            Map(row => row.AdditionalInfoContent10, row => row.AdditionalInfoContent10.ToDatev());
            Map(row => row.AdditionalInfoType11, row => row.AdditionalInfoType11.ToDatev());
            Map(row => row.AdditionalInfoContent11, row => row.AdditionalInfoContent11.ToDatev());
            Map(row => row.AdditionalInfoType12, row => row.AdditionalInfoType12.ToDatev());
            Map(row => row.AdditionalInfoContent12, row => row.AdditionalInfoContent12.ToDatev());
            Map(row => row.AdditionalInfoType13, row => row.AdditionalInfoType13.ToDatev());
            Map(row => row.AdditionalInfoContent13, row => row.AdditionalInfoContent13.ToDatev());
            Map(row => row.AdditionalInfoType14, row => row.AdditionalInfoType14.ToDatev());
            Map(row => row.AdditionalInfoContent14, row => row.AdditionalInfoContent14.ToDatev());
            Map(row => row.AdditionalInfoType15, row => row.AdditionalInfoType15.ToDatev());
            Map(row => row.AdditionalInfoContent15, row => row.AdditionalInfoContent15.ToDatev());
            Map(row => row.AdditionalInfoType16, row => row.AdditionalInfoType16.ToDatev());
            Map(row => row.AdditionalInfoContent16, row => row.AdditionalInfoContent16.ToDatev());
            Map(row => row.AdditionalInfoType17, row => row.AdditionalInfoType17.ToDatev());
            Map(row => row.AdditionalInfoContent17, row => row.AdditionalInfoContent17.ToDatev());
            Map(row => row.AdditionalInfoType18, row => row.AdditionalInfoType18.ToDatev());
            Map(row => row.AdditionalInfoContent18, row => row.AdditionalInfoContent18.ToDatev());
            Map(row => row.AdditionalInfoType19, row => row.AdditionalInfoType19.ToDatev());
            Map(row => row.AdditionalInfoContent19, row => row.AdditionalInfoContent19.ToDatev());
            Map(row => row.AdditionalInfoType20, row => row.AdditionalInfoType20.ToDatev());
            Map(row => row.AdditionalInfoContent20, row => row.AdditionalInfoContent20.ToDatev());
        }
    }
}