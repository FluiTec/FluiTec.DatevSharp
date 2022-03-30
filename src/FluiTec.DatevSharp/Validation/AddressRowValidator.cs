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
            RuleFor(address => address.Method).Length(0, 1);
            RuleFor(address => address.IndividualField1).Length(0, 40);
            RuleFor(address => address.IndividualField2).Length(0, 40);
            RuleFor(address => address.IndividualField3).Length(0, 40);
            RuleFor(address => address.IndividualField4).Length(0, 40);
            RuleFor(address => address.IndividualField5).Length(0, 40);
            RuleFor(address => address.IndividualField6).Length(0, 40);
            RuleFor(address => address.IndividualField7).Length(0, 40);
            RuleFor(address => address.IndividualField8).Length(0, 40);
            RuleFor(address => address.IndividualField9).Length(0, 40);
            RuleFor(address => address.IndividualField10).Length(0, 40);
            RuleFor(address => address.IndividualField11).Length(0, 40);
            RuleFor(address => address.IndividualField12).Length(0, 40);
            RuleFor(address => address.IndividualField13).Length(0, 40);
            RuleFor(address => address.IndividualField14).Length(0, 40);
            RuleFor(address => address.IndividualField15).Length(0, 40);
            RuleFor(address => address.BillingDivergentSalutation).Length(0, 30);
            RuleFor(address => address.BillingStreet).Length(0, 36);
            RuleFor(address => address.BillingPostBox).Length(0, 10);
            RuleFor(address => address.BillingZipCode).Length(0, 10);
            RuleFor(address => address.BillingCity).Length(0, 30);
            RuleFor(address => address.BillingTransportAddition).Length(0, 50);
            RuleFor(address => address.BillingAddressAddition).Length(0, 36);
            RuleFor(address => address.BillingDeliveryDirective1).Length(0, 50);
            RuleFor(address => address.BillingDeliveryDirective1).Length(0, 36);
            RuleFor(address => address.ExternalAccountNumber).Length(0, 15);
            RuleFor(address => address.SepaMandateReference1).Length(0, 35);
            RuleFor(address => address.SepaMandateReference2).Length(0, 35);
            RuleFor(address => address.SepaMandateReference3).Length(0, 35);
            RuleFor(address => address.SepaMandateReference4).Length(0, 35);
            RuleFor(address => address.SepaMandateReference5).Length(0, 35);
            RuleFor(address => address.SepaMandateReference6).Length(0, 35);
            RuleFor(address => address.SepaMandateReference7).Length(0, 35);
            RuleFor(address => address.SepaMandateReference8).Length(0, 35);
            RuleFor(address => address.SepaMandateReference9).Length(0, 35);
            RuleFor(address => address.SepaMandateReference10).Length(0, 35);
            RuleFor(address => address.DivergentSearchName).Length(0, 50);
            RuleFor(address => address.IndividualCorrespondenceAddress).Length(0, 306);
            RuleFor(address => address.IndividualBillingAddress).Length(0, 306);

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
            RuleFor(address => address.BankCode6).Length(0, 8);
            RuleFor(address => address.BankName6).Length(0, 30);
            RuleFor(address => address.BankAccountNumber6).Length(0, 10);
            RuleFor(address => address.Iban6).Length(0, 34);
            RuleFor(address => address.Swift6).Length(0, 11);
            RuleFor(address => address.DivergentAccountHolder6).Length(0, 70);
            RuleFor(address => address.BankCode7).Length(0, 8);
            RuleFor(address => address.BankName7).Length(0, 30);
            RuleFor(address => address.BankAccountNumber7).Length(0, 10);
            RuleFor(address => address.Iban7).Length(0, 34);
            RuleFor(address => address.Swift7).Length(0, 11);
            RuleFor(address => address.DivergentAccountHolder7).Length(0, 70);
            RuleFor(address => address.BankCode8).Length(0, 8);
            RuleFor(address => address.BankName8).Length(0, 30);
            RuleFor(address => address.BankAccountNumber8).Length(0, 10);
            RuleFor(address => address.Iban8).Length(0, 34);
            RuleFor(address => address.Swift8).Length(0, 11);
            RuleFor(address => address.DivergentAccountHolder8).Length(0, 80);
            RuleFor(address => address.BankCode9).Length(0, 9);
            RuleFor(address => address.BankName9).Length(0, 30);
            RuleFor(address => address.BankAccountNumber9).Length(0, 10);
            RuleFor(address => address.Iban9).Length(0, 34);
            RuleFor(address => address.Swift9).Length(0, 11);
            RuleFor(address => address.DivergentAccountHolder9).Length(0, 90);
            RuleFor(address => address.BankCode10).Length(0, 10);
            RuleFor(address => address.BankName10).Length(0, 30);
            RuleFor(address => address.BankAccountNumber10).Length(0, 10);
            RuleFor(address => address.Iban10).Length(0, 34);
            RuleFor(address => address.Swift10).Length(0, 11);
            RuleFor(address => address.DivergentAccountHolder10).Length(0, 100);
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