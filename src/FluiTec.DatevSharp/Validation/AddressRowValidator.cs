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
        /// <param name="accountLength">    Length of the account. </param>
        public AddressRowValidator(int accountLength)
        {
            // base
            RuleFor(address => address.AccountNumber.ToString()).NotNull().Length(accountLength).NotEmpty();
            RuleFor(address => address.Salutation).Length(0, 30);
            RuleFor(address => address.DivergentSalutation).Length(0, 30);
            RuleFor(address => address.Title).Length(0, 25);
            RuleFor(address => address.NobilityTitle).Length(0, 15);
            RuleFor(address => address.NamePrefix).Length(0, 14);
            RuleFor(address => address.Name).Length(0, 50);
            RuleFor(address => address.ShortName).Length(0, 15);
            RuleFor(address => address.TaxIdNumber).Length(0, 13);
            RuleFor(address => address.Name_Enterprise).Length(0, 50);
            RuleFor(address => address.Name_Person).Length(0, 30);
            RuleFor(address => address.FirstName_Person).Length(0, 30);
            RuleFor(address => address.Name_Enterprise_Extension).Length(0, 50);
            RuleFor(address => address.TransportAddition).Length(0, 50);
            RuleFor(address => address.AddressAddition).Length(0, 36);
            RuleFor(address => address.Street).Length(0, 36);
            RuleFor(address => address.PostBox).Length(0, 10);
            RuleFor(address => address.DeliveryDirective1).Length(0, 50);
            RuleFor(address => address.DeliveryDirective1).Length(0, 36);
            RuleFor(address => address.Phone).Length(0, 60);
            RuleFor(address => address.PhoneNote).Length(0, 40);
            RuleFor(address => address.ManagementPhone).Length(0, 60);
            RuleFor(address => address.ManagementPhoneNote).Length(0, 40);
            RuleFor(address => address.Mail).Length(0, 60);
            RuleFor(address => address.MailNote).Length(0, 40);
            RuleFor(address => address.Website).Length(0, 60);
            RuleFor(address => address.WebsiteNote).Length(0, 40);
            RuleFor(address => address.Fax).Length(0, 60);
            RuleFor(address => address.FaxNote).Length(0, 40);
            RuleFor(address => address.Other).Length(0, 60);
            RuleFor(address => address.OtherNote).Length(0, 40);
            RuleFor(address => address.LetterSalutation).Length(0, 100);
            RuleFor(address => address.ComplimentaryClose).Length(0, 50);
            RuleFor(address => address.CustomerNumber).Length(0, 15);
            RuleFor(address => address.TaxNumber).Length(0, 20);
            RuleFor(address => address.ContactPerson).Length(0, 40);
            RuleFor(address => address.Representative).Length(0, 40);
            RuleFor(address => address.Referee).Length(0, 40);

            // bank
            RuleFor(address => address.BankCode1).Length(0, 8);
            RuleFor(address => address.BankName1).Length(0, 30);
            RuleFor(address => address.BankAccountNumber1).Length(0, 10);
            RuleFor(address => address.Iban1).Length(0, 34);
            RuleFor(address => address.Swift1).Length(0, 11);
            RuleFor(address => address.DivergentAccountHolder1).Length(0, 70);
            RuleFor(address => address.BankCode2).Length(0, 8);
            RuleFor(address => address.BankName2).Length(0, 30);
            RuleFor(address => address.BankAccountNumber2).Length(0, 10);
            RuleFor(address => address.Iban2).Length(0, 34);
            RuleFor(address => address.Swift2).Length(0, 11);
            RuleFor(address => address.DivergentAccountHolder2).Length(0, 70);
            RuleFor(address => address.BankCode3).Length(0, 8);
            RuleFor(address => address.BankName3).Length(0, 30);
            RuleFor(address => address.BankAccountNumber3).Length(0, 10);
            RuleFor(address => address.Iban3).Length(0, 34);
            RuleFor(address => address.Swift3).Length(0, 11);
            RuleFor(address => address.DivergentAccountHolder3).Length(0, 70);
            RuleFor(address => address.BankCode4).Length(0, 8);
            RuleFor(address => address.BankName4).Length(0, 30);
            RuleFor(address => address.BankAccountNumber4).Length(0, 10);
            RuleFor(address => address.Iban4).Length(0, 34);
            RuleFor(address => address.Swift4).Length(0, 11);
            RuleFor(address => address.DivergentAccountHolder4).Length(0, 70);
            RuleFor(address => address.BankCode5).Length(0, 8);
            RuleFor(address => address.BankName5).Length(0, 30);
            RuleFor(address => address.BankAccountNumber5).Length(0, 10);
            RuleFor(address => address.Iban5).Length(0, 34);
            RuleFor(address => address.Swift5).Length(0, 11);
            RuleFor(address => address.DivergentAccountHolder5).Length(0, 70);
            RuleFor(address => address.BusinessPartnerBank).Length(0, 3);
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