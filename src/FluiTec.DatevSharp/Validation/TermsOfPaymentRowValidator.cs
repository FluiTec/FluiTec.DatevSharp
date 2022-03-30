using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using FluiTec.DatevSharp.Interfaces;
using FluiTec.DatevSharp.Rows.TermsOfPaymentRow;

namespace FluiTec.DatevSharp.Validation
{
    /// <summary>   The terms of payment row validator. </summary>
    public class TermsOfPaymentRowValidator : AbstractValidator<TermsOfPaymentRow>, IValidator<IDatevRow>
    {
        /// <summary>   Default constructor. </summary>
        public TermsOfPaymentRowValidator()
        {
            RuleFor(top => top.Number).GreaterThanOrEqualTo(10).LessThanOrEqualTo(999);
            RuleFor(top => top.Name).Length(0, 40);
            RuleFor(top => top.CashDiscount1Percent)
                .Must(perc => perc == null || perc > 0 && perc < 1000)
                .WithMessage("CashDiscount1Percent must be NULL OR >0 and <max!");
            RuleFor(top => top.CashDiscount1Days)
                .Must(days => days == null || days > 0 && days < 999)
                .WithMessage("CashDiscount1Days must be NULL OR >0 and <max!");
            RuleFor(top => top.CashDiscount2Percent)
                .Must(perc => perc == null || perc > 0 && perc < 1000)
                .WithMessage("CashDiscount2Percent must be NULL OR >0 and <max!");
            RuleFor(top => top.CashDiscount2Days)
                .Must(days => days == null || days > 0 && days < 999)
                .WithMessage("CashDiscount2Days must be NULL OR >0 and <max!");
            RuleFor(top => top.Days)
                .Must(days => days == null || days > 0 && days < 999)
                .WithMessage("Days must be NULL OR >0 and <max!");

            RuleFor(top => top.Period1BillingDay)
                .Must(d => d == null || d > 0 && d < 32)
                .WithMessage("Period1BillingDay must be null or 1-31!");
            RuleFor(top => top.Period1CashDiscount1Day)
                .Must(d => d == null || d > 0 && d < 32)
                .WithMessage("Period1CashDiscount1Day must be null or 1-31!");
            RuleFor(top => top.Period1CashDiscount2Day)
                .Must(d => d == null || d > 0 && d < 32)
                .WithMessage("Period1CashDiscount2Day must be null or 1-31!");
            RuleFor(top => top.Period1DueDay)
                .Must(d => d == null || d > 0 && d < 32)
                .WithMessage("Period1DueDay must be null or 1-31!");

            RuleFor(top => top.Period2BillingDay)
                .Must(d => d == null || d > 0 && d < 32)
                .WithMessage("Period2BillingDay must be null or 1-31!");
            RuleFor(top => top.Period2CashDiscount1Day)
                .Must(d => d == null || d > 0 && d < 32)
                .WithMessage("Period2CashDiscount1Day must be null or 1-31!");
            RuleFor(top => top.Period2CashDiscount2Day)
                .Must(d => d == null || d > 0 && d < 32)
                .WithMessage("Period2CashDiscount2Day must be null or 1-31!");
            RuleFor(top => top.Period2DueDay)
                .Must(d => d == null || d > 0 && d < 32)
                .WithMessage("Period2DueDay must be null or 1-31!");

            RuleFor(top => top.Period3BillingDay)
                .Must(d => d == null || d > 0 && d < 32)
                .WithMessage("Period3BillingDay must be null or 1-31!");
            RuleFor(top => top.Period3CashDiscount1Day)
                .Must(d => d == null || d > 0 && d < 32)
                .WithMessage("Period3CashDiscount1Day must be null or 1-31!");
            RuleFor(top => top.Period3CashDiscount2Day)
                .Must(d => d == null || d > 0 && d < 32)
                .WithMessage("Period3CashDiscount2Day must be null or 1-31!");
            RuleFor(top => top.Period3DueDay)
                .Must(d => d == null || d > 0 && d < 32)
                .WithMessage("Period3DueDay must be null or 1-31!");
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