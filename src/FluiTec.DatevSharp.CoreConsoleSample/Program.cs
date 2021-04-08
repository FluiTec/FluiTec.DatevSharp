﻿using System;
using System.IO;
using System.Text;
using FluiTec.DatevSharp.Rows.BookingRow;

namespace FluiTec.DatevSharp.CoreConsoleSample
{
    class Program
    {
        private static readonly DateTime ExportStartDate = new DateTime(2017, 2, 15);

        private static readonly DateTime ExportEndDate = new DateTime(2017, 2, 28);

        private static readonly DateTime SampleBookingDate = new DateTime(2017, 2, 16);

        private static readonly DateTime SampleDeliveryDate = new DateTime(2017, 2, 15);

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
                    Source = "RE", // <-- defines we're using an erp-system
                    ConsultantNumber = 00001, // <-- unique number of the consultant within the datev-organization
                    ClientNumber = 00001, // <-- your unique number of your enterprise within the consultant
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
            decimal value = 50m; // 50 €
            string accountNumber = "10001"; // customers number in your erp

            // bill we wrote
            file.Rows.Add(new BookingRow
            {
                Volume = Math.Round(Math.Abs(value), 2), // 50 €
                AccountNumber = value > 0m ? accountNumber : "8400",
                ContraAccountNumber = value > 0m ? "8400" : accountNumber,
                TaxKey = "10",
                Date = SampleBookingDate,
                BookingText = "your bookings text",
                DocumentField1 = "500000", // <-- your unique booking number
                DocumentField2 = "NETTO14", // <-- the name of the payment-condition you synchronized with your consultant
                CountryCodeAndTaxId = null, // null / your customers UstId
                ActivityDate = SampleDeliveryDate,
            });
        }
    }
}
