using System;
using System.IO;
using System.Text;
using FluiTec.DatevSharp.Rows.TermsOfPaymentRow;

namespace FluiTec.DatevSharp.CoreConsoleSample
{
    /// <summary>
    /// The terms of payment sample.
    /// </summary>
    public class TermsOfPaymentSample
    {
        private static readonly DateTime StartOfBusinessYear = new DateTime(2017, 1, 1);
        private static readonly DateTime ExportStartDate = new DateTime(2017, 2, 15);
        private static readonly DateTime ExportEndDate = new DateTime(2017, 2, 28);

        /// <summary>
        /// Executes the 'sample' operation.
        /// </summary>
        public void RunSample()
        {
            var datev = CreateToPFile();
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

        /// <summary>
        /// Creates to p file.
        /// </summary>
        ///
        /// <returns>
        /// The new to p file.
        /// </returns>
        private DatevFile CreateToPFile()
        {
            var file = new DatevFile
            {
                Header = new DatevHeader
                {
                    DataCategory = DataCategories.Instance.TermsOfPaymentCategory, // <-- this defines we are going to export terms of payment
                    DataVersion = DataCategories.Instance.TermsOfPaymentCategory.DefaultVersion, // <-- this defines the version we're going to use (optional as setting Category sets the version)
                    StartOfBusinessYear = StartOfBusinessYear, // <-- optional, by omitting this you set the current year
                    Source = "RE", // <-- defines we're using an erp-system
                    ConsultantNumber = 1001, // <-- unique number of the consultant within the datev-organization
                    ClientNumber = 1001, // <-- your unique number of your enterprise within the consultant
                    BookingsFrom = ExportStartDate, // <-- Defines the StartDate/Time of your export
                    BookingsTill = ExportEndDate // <-- Defines the EndDate/Time of your export
                }
            };

            AddSampleToPData(file);

            return file;
        }

        private void AddSampleToPData(DatevFile file)
        {
            file.Rows.Add(new TermsOfPaymentRow
            {
                Number = 20,
                Name = "YourName",
                CashDiscount1Days = 10,
                CashDiscount1Percent = 2,
                DueType = 1,
                Days = 30
            });
        }
    }
}