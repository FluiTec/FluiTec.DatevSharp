using FluiTec.DatevSharp.Helpers;
using FluiTec.DatevSharp.Rows.Maps.Base;

namespace FluiTec.DatevSharp.Rows.Maps
{
    /// <summary>
    ///     Map of address.
    /// </summary>
    public class AddressMap : ClassMap<AddressRow.AddressRow>
    {
        /// <summary>
        ///     Default constructor.
        /// </summary>
        public AddressMap()
        {
            // base
            Map(row => row.AccountNumber, row => row.AccountNumber.ToDatev());
            Map(row => row.Name_Enterprise, row => row.Name_Enterprise.ToDatev());
            Map(row => row.Name_Enterprise_Extension, row => row.Name_Enterprise_Extension.ToDatev());
            Map(row => row.Name_Person, row => row.Name_Person.ToDatev());
            Map(row => row.FirstName_Person, row => row.FirstName_Person.ToDatev());
            Map(row => row.Name, row => row.Name.ToDatev());
            Map(row => row.AddressType, row => row.AddressType.ValueToDatev());
            Map(row => row.ShortName, row => row.ShortName.ToDatev());
            Map(row => row.EuCountry, row => row.EuCountry.ToDatev());
            Map(row => row.Country, row => row.Country.ToDatev());
            Map(row => row.TaxIdNumber, row => row.TaxIdNumber.ToDatev());
            Map(row => row.Salutation, row => row.Salutation.ToDatev());
            Map(row => row.DivergentSalutation, row => row.DivergentSalutation.ToDatev());
            Map(row => row.Title, row => row.Title.ToDatev());
            Map(row => row.NobilityTitle, row => row.NobilityTitle.ToDatev());
            Map(row => row.NamePrefix, row => row.NamePrefix.ToDatev());
            Map(row => row.PostalAddressType, row => row.PostalAddressType.ToDatev());
            Map(row => row.Street, row => row.Street.ToDatev());
            Map(row => row.PostBox, row => row.PostBox.ToDatev());
            Map(row => row.ZipCode, row => row.ZipCode.ToDatev());
            Map(row => row.City, row => row.City.ToDatev());
            Map(row => row.TransportAddition, row => row.TransportAddition.ToDatev());
            Map(row => row.AddressAddition, row => row.AddressAddition.ToDatev());
            Map(row => row.DeliveryDirective1, row => row.DeliveryDirective1.ToDatev());
            Map(row => row.DeliveryDirective2, row => row.DeliveryDirective2.ToDatev());
            Map(row => row.MarkerCorrespondenceAddress, row => row.MarkerCorrespondenceAddress.ToDatev());
            Map(row => row.ValidFrom, row => row.ValidFrom.ToDatevDateReverse());
            Map(row => row.ValidTill, row => row.ValidTill.ToDatevDateReverse());
            Map(row => row.Phone, row => row.Phone.ToDatev());
            Map(row => row.PhoneNote, row => row.PhoneNote.ToDatev());
            Map(row => row.ManagementPhone, row => row.ManagementPhone.ToDatev());
            Map(row => row.ManagementPhoneNote, row => row.ManagementPhoneNote.ToDatev());
            Map(row => row.Mail, row => row.Mail.ToDatev());
            Map(row => row.MailNote, row => row.MailNote.ToDatev());
            Map(row => row.Website, row => row.Website.ToDatev());
            Map(row => row.WebsiteNote, row => row.WebsiteNote.ToDatev());
            Map(row => row.Fax, row => row.Fax.ToDatev());
            Map(row => row.FaxNote, row => row.FaxNote.ToDatev());
            Map(row => row.Other, row => row.Other.ToDatev());
            Map(row => row.OtherNote, row => row.OtherNote.ToDatev());
            Map(row => row.LetterSalutation, row => row.LetterSalutation.ToDatev());
            Map(row => row.ComplimentaryClose, row => row.ComplimentaryClose.ToDatev());
            Map(row => row.CustomerNumber, row => row.CustomerNumber.ToDatev());
            Map(row => row.TaxNumber, row => row.TaxNumber.ToDatev());
            Map(row => row.Language, row => row.Language?.ValueToDatev());
            Map(row => row.ContactPerson, row => row.ContactPerson.ToDatev());
            Map(row => row.Representative, row => row.Representative.ToDatev());
            Map(row => row.Referee, row => row.Referee.ToDatev());
            Map(row => row.IsDiverse, row => row.IsDiverse.ToDatev());
            Map(row => row.OutputTarget, row => row.OutputTarget?.ValueToDatev());
            Map(row => row.CurrencyHandling, row => row.CurrencyHandling?.ValueToDatev());
            Map(row => row.CreditLimit, row => row.CreditLimit.ToDatev());
            Map(row => row.TermsOfPaymentNumber, row => row.TermsOfPaymentNumber.ToDatev());
            Map(row => row.DebitorDueDays, row => row.DebitorDueDays.ToDatev());
            Map(row => row.DebitorCashDiscount, row => row.DebitorCashDiscount.ToDatev());
            Map(row => row.CreditorDueDays1, row => row.CreditorDueDays1.ToDatev());
            Map(row => row.CreditorCashDiscount1, row => row.CreditorCashDiscount1.ToDatev());
            Map(row => row.CreditorDueDays2, row => row.CreditorDueDays2.ToDatev());
            Map(row => row.CreditorCashDiscount2, row => row.CreditorCashDiscount2.ToDatev());
            Map(row => row.CreditorDueDays3, row => row.CreditorDueDays3.ToDatev());
            Map(row => row.CreditorDueDays4, row => row.CreditorDueDays4.ToDatev());
            Map(row => row.CreditorCashDiscount4, row => row.CreditorCashDiscount4.ToDatev());
            Map(row => row.CreditorDueDays5, row => row.CreditorDueDays5.ToDatev());
            Map(row => row.CreditorCashDiscount5, row => row.CreditorCashDiscount5.ToDatev());
            Map(row => row.Admonition, row => row.Admonition?.ValueToDatev());

            // bank
            Map(row => row.BankCode1, row => row.BankCode1.ToDatev());
            Map(row => row.BankName1, row => row.BankName1.ToDatev());
            Map(row => row.BankAccountNumber1, row => row.BankAccountNumber1.ToDatev());
            Map(row => row.BankCountry1, row => row.BankCountry1.ToDatev());
            Map(row => row.Iban1, row => row.Iban1.ToDatev());
            Map(row => row.Iban1Correct, row => row.Iban1Correct.ToDatevWrapped());
            Map(row => row.Swift1, row => row.Swift1.ToDatev());
            Map(row => row.DivergentAccountHolder1, row => row.DivergentAccountHolder1.ToDatev());
            Map(row => row.MarkerMainBankingAccount1, row => row.MarkerMainBankingAccount1.ToDatevWrapped());
            Map(row => row.BankValidFrom1, row => row.BankValidFrom1.ToDatevDateReverse());
            Map(row => row.BankValidTill1, row => row.BankValidTill1.ToDatevDateReverse());
            Map(row => row.BankCode2, row => row.BankCode2.ToDatev());
            Map(row => row.BankName2, row => row.BankName2.ToDatev());
            Map(row => row.BankAccountNumber2, row => row.BankAccountNumber2.ToDatev());
            Map(row => row.BankCountry2, row => row.BankCountry2.ToDatev());
            Map(row => row.Iban2, row => row.Iban2.ToDatev());
            Map(row => row.Iban2Correct, row => row.Iban2Correct.ToDatevWrapped());
            Map(row => row.Swift2, row => row.Swift2.ToDatev());
            Map(row => row.DivergentAccountHolder2, row => row.DivergentAccountHolder2.ToDatev());
            Map(row => row.MarkerMainBankingAccount2, row => row.MarkerMainBankingAccount2.ToDatevWrapped());
            Map(row => row.BankValidFrom2, row => row.BankValidFrom2.ToDatevDateReverse());
            Map(row => row.BankValidTill2, row => row.BankValidTill2.ToDatevDateReverse());
            Map(row => row.BankCode3, row => row.BankCode3.ToDatev());
            Map(row => row.BankName3, row => row.BankName3.ToDatev());
            Map(row => row.BankAccountNumber3, row => row.BankAccountNumber3.ToDatev());
            Map(row => row.BankCountry3, row => row.BankCountry3.ToDatev());
            Map(row => row.Iban3, row => row.Iban3.ToDatev());
            Map(row => row.Iban3Correct, row => row.Iban3Correct.ToDatevWrapped());
            Map(row => row.Swift3, row => row.Swift3.ToDatev());
            Map(row => row.DivergentAccountHolder3, row => row.DivergentAccountHolder3.ToDatev());
            Map(row => row.MarkerMainBankingAccount3, row => row.MarkerMainBankingAccount3.ToDatevWrapped());
            Map(row => row.BankValidFrom3, row => row.BankValidFrom3.ToDatevDateReverse());
            Map(row => row.BankValidTill3, row => row.BankValidTill3.ToDatevDateReverse());
            Map(row => row.BankCode4, row => row.BankCode4.ToDatev());
            Map(row => row.BankName4, row => row.BankName4.ToDatev());
            Map(row => row.BankAccountNumber4, row => row.BankAccountNumber4.ToDatev());
            Map(row => row.BankCountry4, row => row.BankCountry4.ToDatev());
            Map(row => row.Iban4, row => row.Iban4.ToDatev());
            Map(row => row.Iban4Correct, row => row.Iban4Correct.ToDatevWrapped());
            Map(row => row.Swift4, row => row.Swift4.ToDatev());
            Map(row => row.DivergentAccountHolder4, row => row.DivergentAccountHolder4.ToDatev());
            Map(row => row.MarkerMainBankingAccount4, row => row.MarkerMainBankingAccount4.ToDatevWrapped());
            Map(row => row.BankValidFrom4, row => row.BankValidFrom4.ToDatevDateReverse());
            Map(row => row.BankValidTill4, row => row.BankValidTill4.ToDatevDateReverse());
            Map(row => row.BankCode5, row => row.BankCode5.ToDatev());
            Map(row => row.BankName5, row => row.BankName5.ToDatev());
            Map(row => row.BankAccountNumber5, row => row.BankAccountNumber5.ToDatev());
            Map(row => row.BankCountry5, row => row.BankCountry5.ToDatev());
            Map(row => row.Iban5, row => row.Iban5.ToDatev());
            Map(row => row.Iban5Correct, row => row.Iban5Correct.ToDatevWrapped());
            Map(row => row.Swift5, row => row.Swift5.ToDatev());
            Map(row => row.DivergentAccountHolder5, row => row.DivergentAccountHolder5.ToDatev());
            Map(row => row.MarkerMainBankingAccount5, row => row.MarkerMainBankingAccount5.ToDatevWrapped());
            Map(row => row.BankValidFrom5, row => row.BankValidFrom5.ToDatevDateReverse());
            Map(row => row.BankValidTill5, row => row.BankValidTill5.ToDatevDateReverse());
            Map(row => row.BusinessPartnerBank, row => row.BusinessPartnerBank.ToDatev());
        }
    }
}