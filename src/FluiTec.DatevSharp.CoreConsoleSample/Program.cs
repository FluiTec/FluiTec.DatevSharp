using System;
using System.IO;
using System.Text;
using FluiTec.DatevSharp.Rows.BookingRow;

namespace FluiTec.DatevSharp.CoreConsoleSample
{
    class Program
    {
        private static readonly DateTime ExportStartDate = new DateTime(2021, 4, 2);

        private static readonly DateTime ExportEndDate = new DateTime(2021, 4, 7);

        static void Main(string[] args)
        {
            // make sure we can use CodePage 1252
            // only necessary using NetCore (real .NET already has cp 1252 loaded)
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var datev = CreateBookingFile();
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
        static DatevFile CreateBookingFile()
        {
            var file = new DatevFile
            {
                Header = new DatevHeader
                {
                    DataCategory = DataCategories.Bookings, // <-- this defines we are going to export bookings (bills you got or wrote)
                    StartOfBusinessYear = new DateTime(2021, 1, 1),
                    Source = "JR", // <-- defines we're using an erp-system
                    ConsultantNumber = 128609, // <-- unique number of the consultant within the datev-organization
                    ClientNumber = 500, // <-- your unique number of your enterprise within the consultant
                    BookingsFrom = ExportStartDate, // <-- Defines the StartDate/Time of your export
                    BookingsTill = ExportEndDate // <-- Defines the EndDate/Time of your export
                }
            };

            AddSampleBookingData(file);

            return file;
        }

        // add sample booking data to our file
        static void AddSampleBookingData(DatevFile file)
        {
            file.Rows.Add(new BookingRow
            {
                Claim = "H",
                Volume = Math.Round(Math.Abs(3468.75m), 2),
                AccountNumber = "70075",
                ContraAccountNumber = "5400",
                Date = new DateTime(2021, 1, 14),
                BookingText = "Eingangsrechnung zu TP 3.1",
                DocumentField1 = "48405",
                DocumentField2 = "",
                CountryCodeAndTaxId = null
            });

            file.Rows.Add(new BookingRow
            {
                Claim = "H",
                Volume = Math.Round(Math.Abs(4111.78m), 2),
                AccountNumber = "70075",
                ContraAccountNumber = "5200",
                TaxKey = "90",
                Date = new DateTime(2021, 2, 28),
                BookingText = "Eingangsrechnung zu TP 3.2",
                DocumentField1 = "33254",
                DocumentField2 = "",
                CountryCodeAndTaxId = null
            });

            file.Rows.Add(new BookingRow
            {
                Claim = "H",
                Volume = Math.Round(Math.Abs(120m), 2),
                AccountNumber = "70186",
                ContraAccountNumber = "6660",
                Date = new DateTime(2021, 2, 15),
                BookingText = "Eingangsrechnung zu TP 3.3 Pos 1",
                DocumentField1 = "RE4711",
                DocumentField2 = "",
                CountryCodeAndTaxId = null
            });

            file.Rows.Add(new BookingRow
            {
                Claim = "H",
                Volume = Math.Round(Math.Abs(30m), 2),
                AccountNumber = "70186",
                ContraAccountNumber = "5400",
                Date = new DateTime(2021, 2, 15),
                BookingText = "Eingangsrechnung zu TP 3.3 Pos 2",
                DocumentField1 = "RE4711",
                DocumentField2 = "",
                CountryCodeAndTaxId = null
            });

            file.Rows.Add(new BookingRow
            {
                Claim = "H",
                Volume = Math.Round(Math.Abs(773.50m), 2),
                AccountNumber = "70200",
                ContraAccountNumber = "5400",
                Date = new DateTime(2021, 3, 1),
                ActivityDate = new DateTime(2021, 2, 28),
                BookingText = "Eingangsrechnung zu TP 3.4",
                DocumentField1 = "2020ME114",
                DocumentField2 = "",
                CountryCodeAndTaxId = null
            });

            file.Rows.Add(new BookingRow
            {
                Claim = "S",
                Volume = Math.Round(Math.Abs(3468.75m), 2),
                AccountNumber = "70075",
                ContraAccountNumber = "5400",
                Date = new DateTime(2021, 1, 14),
                BookingText = "Eingangsrechnung zu TP 3.5 - GU zu 3.1",
                DocumentField1 = "48405",
                DocumentField2 = "",
                CountryCodeAndTaxId = null,
                GeneralInversion = "1"
            });

            file.Rows.Add(new BookingRow
            {
                Claim = "S",
                Volume = Math.Round(Math.Abs(4111.78m), 2),
                AccountNumber = "70075",
                ContraAccountNumber = "5200",
                TaxKey = "90",
                Date = new DateTime(2021, 2, 28),
                BookingText = "Eingangsrechnung zu TP 3.5 - GU zu 3.2",
                DocumentField1 = "33254",
                DocumentField2 = "",
                CountryCodeAndTaxId = null,
                GeneralInversion = "1"
            });
        }
    }
}
