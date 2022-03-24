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
        ///
        /// <param name="args"> An array of command-line argument strings. </param>
        private static void Main(string[] args)
        {
            // make sure we can use CodePage 1252
            // only necessary using NetCore (real .NET already has cp 1252 loaded)
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // run the booking sample
            new BookingSample().RunSample();
        }
    }
}
