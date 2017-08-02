using System.Linq;
using FluentValidation;

namespace FluiTec.Datev.Models.Validators
{
	public class DatevHeaderValidator : AbstractValidator<DatevHeader>
	{
		public DatevHeaderValidator()
		{
			// basic properties
			RuleFor(header => header.DataCategory).NotNull();
			RuleFor(header => header.Source).Length(min: 0, max: 2);
			RuleFor(header => header.ExportedBy).Length(min: 0, max: 25);
			RuleFor(header => header.ImportedBy).Length(min: 0, max: 25);
			RuleFor(header => header.ConsultantNumber).GreaterThan(valueToCompare: 0);
			RuleFor(header => header.ClientNumber).GreaterThan(valueToCompare: 0);
			RuleFor(header => header.StartOfBusinessYear).LessThanOrEqualTo(header => header.Created);
			RuleFor(header => header.ImpersonalAccountsLength)
				.GreaterThan(valueToCompare: 0)
				.LessThanOrEqualTo(valueToCompare: 9);

			var bookingNumber = DataCategories.Bookings.Number;
			// booking only properties
			When(header => header.DataCategory.Number == bookingNumber, () => RuleFor(header => header.BookingsFrom).NotNull());
			When(header => header.DataCategory.Number == bookingNumber, () => RuleFor(header => header.BookingsTill).NotNull());
			RuleFor(header => header.Description).Length(min: 0, max: 30);
			RuleFor(header => header.DictationShortName).Length(min: 0, max: 2);
			When(header => header.DataCategory.Number == bookingNumber,
				() => RuleFor(header => header.BookingType).InclusiveBetween(from: 1, to: 2));
			var validIntentions = new[] {0, 50, 30, 64, 40, 11, 12};
			When(header => header.DataCategory.Number == bookingNumber, () =>
				RuleFor(header => header.BillingIntention)
					.NotNull()
					// ReSharper disable once PossibleInvalidOperationException
					.Must(intention => validIntentions.Contains(intention.Value))
					.WithMessage(
						$"BillingIntention must be one of the following values: {string.Join(separator: ",", values: validIntentions.Select(i => i.ToString()))}."));
			RuleFor(header => header.CurrencySymbol).Length(min: 0, max: 3);
		}
	}
}