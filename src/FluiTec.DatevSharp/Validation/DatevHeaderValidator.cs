using System.Linq;
using FluentValidation;

namespace FluiTec.DatevSharp.Validation
{
    public class DatevHeaderValidator : AbstractValidator<DatevHeader>
    {
        public DatevHeaderValidator()
        {
            // basic properties
            RuleFor(header => header.DataCategory).NotNull();
            RuleFor(header => header.Source).Length(0, 2);
            RuleFor(header => header.ExportedBy).Length(0, 25);
            RuleFor(header => header.ImportedBy).Length(0, 25);
            RuleFor(header => header.ConsultantNumber).GreaterThan(0);
            RuleFor(header => header.ClientNumber).GreaterThan(0);
            RuleFor(header => header.StartOfBusinessYear).LessThanOrEqualTo(header => header.Created);
            RuleFor(header => header.ImpersonalAccountsLength).GreaterThan(0).LessThanOrEqualTo(9);

            var bookingNumber = DataCategories.Instance.BookingCategory.Number;
            // booking only properties
            When(header => header.DataCategory.Number == bookingNumber,
                () => RuleFor(header => header.BookingsFrom).NotNull());
            When(header => header.DataCategory.Number == bookingNumber,
                () => RuleFor(header => header.BookingsTill).NotNull());
            RuleFor(header => header.Description).Length(0, 30);
            RuleFor(header => header.DictationShortName).Length(0, 2);
            When(header => header.DataCategory.Number == bookingNumber,
                () => RuleFor(header => header.BookingType).InclusiveBetween(1, 2));
            var validIntentions = new[] {0, 50, 30, 64, 40, 11, 12};
            When(header => header.DataCategory.Number == bookingNumber, () =>
                RuleFor(header => header.BillingIntention)
                    .NotNull()
                    // ReSharper disable once PossibleInvalidOperationException
                    .Must(intention => validIntentions.Contains(intention.Value))
                    .WithMessage(
                        $"BillingIntention must be one of the following values: {string.Join(",", validIntentions.Select(i => i.ToString()))}."));
            RuleFor(header => header.CurrencySymbol).Length(0, 3);
        }
    }
}