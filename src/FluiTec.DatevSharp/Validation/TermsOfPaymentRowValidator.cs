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