using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using FluiTec.Datev.Models.Rows;

namespace FluiTec.Datev.Models.Validators
{
	/// <summary>   The terms of payment row validator. </summary>
	public class TermsOfPaymentRowValidator : AbstractValidator<TermsOfPaymentRow>, IValidator<IDatevRow>
	{
		/// <summary>   Default constructor. </summary>
		public TermsOfPaymentRowValidator()
		{
			RuleFor(top => top.Number).GreaterThanOrEqualTo(valueToCompare: 10).LessThanOrEqualTo(valueToCompare: 999);
			RuleFor(top => top.Name).Length(min: 0, max: 40);
			RuleFor(top => top.DueType)
				.Must(dt => dt == null || dt > 0 && dt < 3)
				.WithMessage(errorMessage: "DueType must be NULL OR >0 and <max!");
			RuleFor(top => top.CashDiscount1Percent)
				.Must(perc => perc == null || perc > 0 && perc < 1000)
				.WithMessage(errorMessage: "CashDiscount1Percent must be NULL OR >0 and <max!");
			RuleFor(top => top.CashDiscount1Days)
				.Must(days => days == null || days > 0 && days < 999)
				.WithMessage(errorMessage: "CashDiscount1Days must be NULL OR >0 and <max!");
			RuleFor(top => top.CashDiscount2Percent)
				.Must(perc => perc == null || perc > 0 && perc < 1000)
				.WithMessage(errorMessage: "CashDiscount2Percent must be NULL OR >0 and <max!");
			RuleFor(top => top.CashDiscount2Days)
				.Must(days => days == null || days > 0 && days < 999)
				.WithMessage(errorMessage: "CashDiscount2Days must be NULL OR >0 and <max!");
			RuleFor(top => top.Days)
				.Must(days => days == null || days > 0 && days < 999)
				.WithMessage(errorMessage: "Days must be NULL OR >0 and <max!");
		}

		/// <summary>   Validates the specified instance. </summary>
		/// <param name="instance"> The instance to validate. </param>
		/// <returns>   A ValidationResult object containing any validation failures. </returns>
		public ValidationResult Validate(IDatevRow instance)
		{
			return base.Validate(instance as TermsOfPaymentRow);
		}

		/// <summary>   Validates the asynchronous. </summary>
		/// <param name="instance">     The instance. </param>
		/// <param name="cancellation"> The cancellation. </param>
		/// <returns>   A Task. </returns>
		public Task<ValidationResult> ValidateAsync(IDatevRow instance,
			CancellationToken cancellation = new CancellationToken())
		{
			return base.ValidateAsync(instance as TermsOfPaymentRow, cancellation);
		}
	}
}