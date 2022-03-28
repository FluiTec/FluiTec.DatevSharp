using FluentValidation;

namespace FluiTec.DatevSharp.Validation
{
	public class DatevFileValidator : AbstractValidator<DatevFile>
	{
		public DatevFileValidator()
		{
			RuleFor(file => file.Header).NotNull();
			RuleFor(file => file.Header).SetValidator(new DatevHeaderValidator());
			RuleFor(file => file.Rows).Must(rows => rows != null && rows.Count > 0).WithMessage("Exported rows must be > 0!");
			RuleFor(file => file.Rows).SetCollectionValidator(file => file.GetValidator());
		}
	}
}
