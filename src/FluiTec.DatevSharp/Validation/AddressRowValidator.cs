using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using FluiTec.DatevSharp.Interfaces;
using FluiTec.DatevSharp.Rows.AddressRow;

namespace FluiTec.DatevSharp.Validation
{
	/// <summary>   The address row validator. </summary>
	public class AddressRowValidator : AbstractValidator<AddressRow>, IValidator<IDatevRow>
	{
		/// <summary>   Default constructor. </summary>
		///
		/// <param name="accountLength">    Length of the account. </param>
		public AddressRowValidator(int accountLength)
		{
			RuleFor(address => address.AccountNumber.ToString()).NotNull().Length(accountLength).NotEmpty();
			RuleFor(address => address.Salutation).Length(0, 30);
			RuleFor(address => address.Name).Length(0, 50);
			RuleFor(address => address.ShortName).Length(0, 15);
			RuleFor(address => address.Name_Enterprise).Length(0, 50);
			RuleFor(address => address.Name_Person).Length(0, 30);
			RuleFor(address => address.FirstName_Person).Length(0, 30);
			RuleFor(address => address.Name_Enterprise_Extension).Length(0, 50);
            RuleFor(address => address.TransportAddition).Length(0, 50);
            RuleFor(address => address.AddressAddition).Length(0, 36);
			RuleFor(address => address.AddressType).GreaterThanOrEqualTo(0).LessThanOrEqualTo(3);

			var validPostalTypes = new[] { "STR", "PF", "GK" };
			RuleFor(address => address.PostalAddressType)
				.Must(type => type == null || validPostalTypes.Contains(type))
				.WithMessage("PostalAddressType must be NULL or one of the predefined ones.");

			RuleFor(address => address.Street).Length(0, 36);
			RuleFor(address => address.PostBox).Length(0, 10);

		}

		/// <summary>   Validates the specified instance. </summary>
		/// <param name="instance"> The instance to validate. </param>
		/// <returns>   A ValidationResult object containing any validation failures. </returns>
		public ValidationResult Validate(IDatevRow instance)
		{
			return base.Validate(instance as AddressRow);
		}

		/// <summary>   Validate the specified instance asynchronously. </summary>
		/// <param name="instance">     The instance to validate. </param>
		/// <param name="cancellation"> The cancellation. </param>
		/// <returns>   A ValidationResult object containing any validation failures. </returns>
		public Task<ValidationResult> ValidateAsync(IDatevRow instance,
			CancellationToken cancellation = new CancellationToken())
		{
			return base.ValidateAsync(instance as AddressRow, cancellation);
		}
	}
}