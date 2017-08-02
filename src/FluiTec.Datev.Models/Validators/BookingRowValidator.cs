using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using FluiTec.Datev.Models.Rows;

namespace FluiTec.Datev.Models.Validators
{
	/// <summary>   A booking validator. </summary>
	public class BookingRowValidator : AbstractValidator<BookingRow>, IValidator<IDatevRow>
	{
		/// <summary>   Default constructor. </summary>
		/// <param name="accountLength">    Length of the account. </param>
		public BookingRowValidator(int accountLength)
		{
			AddBasicRules(accountLength);
			AddBookingInfoRules();
			AddMiscRuls();
			AddAdditionInfoRules();
		}

		/// <summary>   Validates the specified instance. </summary>
		/// <param name="instance"> The instance to validate. </param>
		/// <returns>   A ValidationResult object containing any validation failures. </returns>
		public ValidationResult Validate(IDatevRow instance)
		{
			return base.Validate(instance as BookingRow);
		}

		/// <summary>   Validate the specified instance asynchronously. </summary>
		/// <param name="instance">     The instance to validate. </param>
		/// <param name="cancellation"> The cancellation. </param>
		/// <returns>   A ValidationResult object containing any validation failures. </returns>
		public Task<ValidationResult> ValidateAsync(IDatevRow instance,
			CancellationToken cancellation = new CancellationToken())
		{
			return base.ValidateAsync(instance as BookingRow, cancellation);
		}

		private void AddBasicRules(int accountLength)
		{
			RuleFor(booking => booking.Volume).GreaterThan(valueToCompare: 0);
			RuleFor(booking => booking.Volume).LessThanOrEqualTo(valueToCompare: 9999999999.99m); // avoid havin length>13
			RuleFor(booking => booking.Claim)
				.Must(claim => claim == "S" || claim == "H")
				.WithMessage(errorMessage: "Claim must either be 'S' or 'H'!");
			RuleFor(booking => booking.ExchangeRage)
				.Must(rate => rate == null || rate > 0)
				.WithMessage(errorMessage: "ExchangeRate must be NULL or > 0!");
			RuleFor(booking => booking.BasicVolume)
				.Must(bv => bv == null || bv > 0 && bv < 9999999999.99m)
				.WithMessage(errorMessage: "BasicVolume must be NULL OR >0 and <max!");
			RuleFor(booking => booking)
				.Must(booking => booking.BasicVolumeCurrencySymbol == null || booking.BasicVolume.HasValue)
				.WithMessage(errorMessage: "If BasicVolumeCurrencySymbol is used, BasicVolume can not be NULL!");
			RuleFor(booking => booking.AccountNumber).Length(accountLength).NotNull();
			RuleFor(booking => booking.ContraAccountNumber).Length(accountLength - 1).NotNull();
			RuleFor(booking => booking.TaxKey).Length(exactLength: 2);
			RuleFor(booking => booking.Date).NotNull();
			RuleFor(booking => booking.DocumentField1).Length(min: 0, max: 12);
			RuleFor(booking => booking.DocumentField2).Length(min: 0, max: 12);
			RuleFor(booking => booking.CashDiscount)
				.Must(bv => bv == null || bv > 0 && bv < 9999999999.99m)
				.WithMessage(errorMessage: "CashDiscount must be NULL OR >0 and <max!");
			RuleFor(booking => booking.BookingText).Length(min: 0, max: 60);
			RuleFor(booking => booking.DiverseAccountNumber).Length(min: 0, max: 9);
			RuleFor(booking => booking.PartnerBank).Length(min: 0, max: 3);
			RuleFor(booking => booking.PartnerBank).Length(min: 0, max: 210);
			RuleFor(booking => booking.CashDiscountType)
				.Must(bv => bv == null || bv > 0 && bv <= 2)
				.WithMessage(errorMessage: "CashDiscountType must be NULL OR >0 and <max!");
			RuleFor(booking => booking.BookingType).Length(min: 0, max: 2);
			RuleFor(booking => booking.PaymentType)
				.Must(bv => bv == null || bv > 0 && bv <= 99)
				.WithMessage(errorMessage: "PaymentType must be NULL OR >0 and <max!");
			RuleFor(booking => booking.Proprietor).Length(min: 0, max: 76);
		}

		private void AddBookingInfoRules()
		{
			RuleFor(booking => booking.BookingInfoType1).Length(min: 0, max: 20);
			RuleFor(booking => booking.BookingInfoContent1).Length(min: 0, max: 210);
			RuleFor(booking => booking.BookingInfoType2).Length(min: 0, max: 20);
			RuleFor(booking => booking.BookingInfoContent2).Length(min: 0, max: 210);
			RuleFor(booking => booking.BookingInfoType3).Length(min: 0, max: 20);
			RuleFor(booking => booking.BookingInfoContent3).Length(min: 0, max: 210);
			RuleFor(booking => booking.BookingInfoType4).Length(min: 0, max: 20);
			RuleFor(booking => booking.BookingInfoContent4).Length(min: 0, max: 210);
			RuleFor(booking => booking.BookingInfoType5).Length(min: 0, max: 20);
			RuleFor(booking => booking.BookingInfoContent5).Length(min: 0, max: 210);
			RuleFor(booking => booking.BookingInfoType6).Length(min: 0, max: 20);
			RuleFor(booking => booking.BookingInfoContent6).Length(min: 0, max: 210);
			RuleFor(booking => booking.BookingInfoType7).Length(min: 0, max: 20);
			RuleFor(booking => booking.BookingInfoContent7).Length(min: 0, max: 210);
			RuleFor(booking => booking.BookingInfoType8).Length(min: 0, max: 20);
			RuleFor(booking => booking.BookingInfoContent8).Length(min: 0, max: 210);
		}

		private void AddMiscRuls()
		{
			RuleFor(booking => booking.CostCenter1).Length(min: 0, max: 8);
			RuleFor(booking => booking.CostCenter2).Length(min: 0, max: 8);
			RuleFor(booking => booking.CostAmount)
				.Must(bv => bv == null || bv > 0 && bv < 9999999999.99m)
				.WithMessage(errorMessage: "CostAmount must be NULL OR >0 and <max!");
			RuleFor(booking => booking.CountryCodeAndTaxId).Length(min: 0, max: 15);
			RuleFor(booking => booking.EuroTax)
				.Must(bv => bv == null || bv > 0 && bv < 99.99m)
				.WithMessage(errorMessage: "EuroTax must be NULL OR >0 and <max!");
			RuleFor(booking => booking.DifferentTaxType).Length(min: 0, max: 1);
			RuleFor(booking => booking.IntentionLL)
				.Must(bv => bv == null || bv > 0 && bv <= 999)
				.WithMessage(errorMessage: "IntentionLL must be NULL OR >0 and <=max!");
			RuleFor(booking => booking.FunctionLL)
				.Must(bv => bv == null || bv > 0 && bv <= 999)
				.WithMessage(errorMessage: "FunctionLL must be NULL OR >0 and <=max!");
			RuleFor(booking => booking.BU49FunctionType)
				.Must(bv => bv == null || bv > 0 && bv <= 9)
				.WithMessage(errorMessage: "BU49FunctionType must be NULL OR >0 and <=max!");
			RuleFor(booking => booking.BU49FunctionNumber)
				.Must(bv => bv == null || bv > 0 && bv <= 99)
				.WithMessage(errorMessage: "BU49FunctionNumber must be NULL OR >0 and <=max!");
			RuleFor(booking => booking.BU49FunctionAddition)
				.Must(bv => bv == null || bv > 0 && bv <= 999)
				.WithMessage(errorMessage: "BU49FunctionAddition must be NULL OR >0 and <=max!");
			RuleFor(booking => booking.Amount)
				.Must(bv => bv == null || bv > 0 && bv <= 99999999)
				.WithMessage(errorMessage: "Amount must be NULL OR >0 and <=max!");
			RuleFor(booking => booking.Weight)
				.Must(bv => bv == null || bv > 0 && bv <= 99999999.99m)
				.WithMessage(errorMessage: "Weight must be NULL OR >0 and <=max!");
			RuleFor(booking => booking.ClaimType).Length(min: 0, max: 10);
			RuleFor(booking => booking.OrderNumber).Length(min: 0, max: 30);
			RuleFor(booking => booking.TaxKeyPrepayment)
				.Must(bv => bv == null || bv > 0 && bv <= 99)
				.WithMessage(errorMessage: "TaxKeyPrepayment must be NULL OR >0 and <=max!");
			RuleFor(booking => booking.CountryCodePrePayment).Length(min: 0, max: 2);
			RuleFor(booking => booking.IntentionLLPrepayment)
				.Must(bv => bv == null || bv > 0 && bv <= 999)
				.WithMessage(errorMessage: "IntentionLLPrepayment must be NULL OR >0 and <=max!");
			RuleFor(booking => booking.EuroTaxPrepayment)
				.Must(bv => bv == null || bv > 0 && bv < 99.99m)
				.WithMessage(errorMessage: "EuroTaxPrepayment must be NULL OR >0 and <max!");
			RuleFor(booking => booking.SepaReference).Length(min: 0, max: 35);
			RuleFor(booking => booking.ParticipantNumber)
				.Must(bv => bv == null || bv > 0 && bv < 9999)
				.WithMessage(errorMessage: "ParticipantNumber must be NULL OR >0 and <max!");
			RuleFor(booking => booking.IdentificationNumber).Length(min: 0, max: 11);
			RuleFor(booking => booking.PainterNumber).Length(min: 0, max: 20);
			RuleFor(booking => booking.SoBilIntention).Length(min: 0, max: 30);
			RuleFor(booking => booking.SoBilKey)
				.Must(bv => bv == null || bv > 0 && bv < 99)
				.WithMessage(errorMessage: "SoBilKey must be NULL OR >0 and <max!");
		}

		private void AddAdditionInfoRules()
		{
			RuleFor(booking => booking.AdditionalInfoType1).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent1).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType2).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent2).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType3).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent3).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType4).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent4).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType5).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent5).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType6).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent6).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType7).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent7).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType8).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent8).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType9).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent9).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType10).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent10).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType11).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent11).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType12).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent12).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType13).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent13).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType14).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent14).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType15).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent15).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType16).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent16).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType17).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent17).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType18).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent18).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType19).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent19).Length(min: 0, max: 210);
			RuleFor(booking => booking.AdditionalInfoType20).Length(min: 0, max: 20);
			RuleFor(booking => booking.AdditionalInfoContent20).Length(min: 0, max: 210);
		}
	}
}