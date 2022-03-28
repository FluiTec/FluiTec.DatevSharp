using System.Text;

namespace FluiTec.DatevSharp.CoreConsoleSample
{
    /// <summary>
    /// A program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry-point for this application.
        /// </summary>
        private static void Main()
        {
            // make sure we can use CodePage 1252
            // only necessary using NetCore (real .NET already has cp 1252 loaded)
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // run the booking sample
            new BookingSample().RunSample();

            // run the address sample
            new AddressSample().RunSample();
            
            // run the terms of payment sample
            new TermsOfPaymentSample().RunSample();
        }
    }
}
