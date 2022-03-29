using FluiTec.DatevSharp.Helpers;
using FluiTec.DatevSharp.Rows.Maps.Base;

namespace FluiTec.DatevSharp.Rows.Maps
{
    /// <summary>
    /// Map of address.
    /// </summary>
    public class AddressMap : ClassMap<AddressRow.AddressRow>
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public AddressMap()
        {
            Map(row => row.AccountNumber, row => row.AccountNumber.ToDatev());
            Map(row => row.Name_Enterprise, row => row.Name_Enterprise.ToDatev());
            Map(row => row.Name_Enterprise_Extension, row => row.Name_Enterprise_Extension.ToDatev());
            Map(row => row.Name_Person, row => row.Name_Person.ToDatev());
            Map(row => row.FirstName_Person, row => row.FirstName_Person.ToDatev());
            Map(row => row.Name, row => row.Name.ToDatev());
            Map(row => row.AddressType, row => row.AddressType.ValueToDatev());
            Map(row => row.ShortName, row => row.ShortName.ToDatev());
            Map(row => row.Country, row => row.Country.ToDatev());
            Map(row => row.Salutation, row => row.Salutation.ToDatev());
            Map(row => row.PostalAddressType, row => row.PostalAddressType.ToDatev());
            Map(row => row.Street, row => row.Street.ToDatev());
            Map(row => row.PostBox, row => row.PostBox.ToDatev());
            Map(row => row.ZipCode, row => row.ZipCode.ToDatev());
            Map(row => row.City, row => row.City.ToDatev());
            Map(row => row.TransportAddition, row => row.TransportAddition.ToDatev());
            Map(row => row.AddressAddition, row => row.AddressAddition.ToDatev());
            Map(row => row.MarkerCorrespondenceAddress, row => row.MarkerCorrespondenceAddress.ToDatev());
            Map(row => row.MarkerMainBankingAccount1, row => row.MarkerMainBankingAccount1.ToDatev());
        }
    }
}