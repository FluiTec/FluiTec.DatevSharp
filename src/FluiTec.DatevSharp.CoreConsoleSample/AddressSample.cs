using System;
using FluiTec.DatevSharp.Rows.AddressRow;

namespace FluiTec.DatevSharp.CoreConsoleSample
{
    /// <summary>
    /// The address sample.
    /// </summary>
    public class AddressSample
    {
        private static readonly DateTime StartOfBusinessYear = new DateTime(2017, 1, 1);
        private static readonly DateTime ExportStartDate = new DateTime(2017, 2, 15);
        private static readonly DateTime ExportEndDate = new DateTime(2017, 2, 28);

        /// <summary>
        /// Executes the address sample.
        /// </summary>
        public void RunSample()
        {

        }

        // create our datev-"file" (in memory) defining it's basic properties
        private static DatevFile CreateAddressFile()
        {
            var file = new DatevFile
            {
                Header = new DatevHeader
                {
                    DataCategory = DataCategories.Instance.AddressCategory, // <-- this defines we are going to export bookings (bills you got or wrote)
                    DataVersion = DataCategories.Instance.AddressCategory.DefaultVersion, // <-- this defines the version we're going to use (optional as setting Category sets the version)
                    StartOfBusinessYear = StartOfBusinessYear, // <-- optional, by omitting this you set the current year
                    Source = "RE", // <-- defines we're using an erp-system
                    ConsultantNumber = 1001, // <-- unique number of the consultant within the datev-organization
                    ClientNumber = 1001, // <-- your unique number of your enterprise within the consultant
                    BookingsFrom = ExportStartDate, // <-- Defines the StartDate/Time of your export
                    BookingsTill = ExportEndDate // <-- Defines the EndDate/Time of your export
                }
            };

            AddSampleAddressData(file);

            return file;
        }

        // add sample booking data to our file
        private static void AddSampleAddressData(DatevFile file)
        {
            file.Rows.Add(new AddressRow
            {
                AccountNumber = 100001,
                Name_Enterprise = "Möbel Mustermann",
                Name_Enterprise_Extension = "Schreinerei",
                AddressType = AddressType.Enterprise,
                ShortName = "mustermann möbel"
            });
        }
    }
}