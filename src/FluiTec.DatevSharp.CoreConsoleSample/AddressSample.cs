using System;
using System.IO;
using System.Text;
using FluiTec.DatevSharp.Rows.AddressRow;
using FluiTec.DatevSharp.Rows.Enums;

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
            var datev = CreateAddressFile();
            var targetFile =
                Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop, Environment.SpecialFolderOption.None),
                    datev.GetName());

            using (var sw = new StreamWriter(targetFile, false, Encoding.GetEncoding(1252)))
            {
                sw.Write(datev.ToDatev());
            }

            Console.WriteLine($"Wrote to file '{targetFile}'");
        }

        // create our datev-"file" (in memory) defining it's basic properties
        private static DatevFile CreateAddressFile()
        {
            var file = new DatevFile
            {
                Header = new DatevHeader
                {
                    DataCategory = DataCategories.Instance.AddressCategory, // <-- this defines we are going to export addresses
                    DataVersion = DataCategories.Instance.AddressCategory.DefaultVersion, // <-- this defines the version we're going to use (optional as setting Category sets the version)
                    StartOfBusinessYear = StartOfBusinessYear, // <-- optional, by omitting this you set the current year
                    Source = "RE", // <-- defines we're using an erp-system
                    ConsultantNumber = 1001, // <-- unique number of the consultant within the datev-organization
                    ClientNumber = 1001 // <-- your unique number of your enterprise within the consultant
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
                AccountNumber = 10001,
                Name_Enterprise = "Möbel Mustermann",
                Name_Enterprise_Extension = "Schreinerei",
                AddressType = AddressType.Enterprise,
                ShortName = "mustermann möb",
                Salutation = "Firma",
                PostalAddressType = PostalAddressType.Street,
                Street = "Teststraße 1",
                ZipCode = "11111",
                City = "Teststadt"
            });
        }
    }
}