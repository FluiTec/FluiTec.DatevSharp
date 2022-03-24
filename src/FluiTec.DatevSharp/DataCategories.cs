using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace FluiTec.DatevSharp
{
	/// <summary>   A data categories. </summary>
	public sealed class DataCategories
    {
        private const string BookingsName = "Bookings";
        private const string AddressName = "Addresses";
        private const string TermsOfPaymentName = "TermsOfPayment";

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static DataCategories() { }

		/// <summary>
		/// Constructor that prevents a default instance of this class from being created.
		/// </summary>
		private DataCategories()
        {
            var asm = typeof(DataCategories).Assembly;
            using (var mapResource = asm.GetManifestResourceStream("FluiTec.DatevSharp.Formats.format_map.json"))
            using (var sr = new StreamReader(mapResource ?? throw new InvalidOperationException()))
            using (var jr = new JsonTextReader(sr))
            {
                var serializer = new JsonSerializer();
                var categories = serializer.Deserialize<DataCategory[]>(jr);

                if (categories == null) throw new InvalidOperationException("format_map.json not parsed correctly!");

                BookingCategory = categories.Single(c => c.Name == BookingsName);
                AddressCategory = categories.Single(c => c.Name == AddressName);
                TermsOfPaymentCategory = categories.Single(c => c.Name == TermsOfPaymentName);
            }
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        ///
        /// <value>
        /// The instance.
        /// </value>
        // ReSharper disable once UnusedMember.Global
        public static DataCategories Instance { get; } = new DataCategories();

        /// <summary>
        /// Gets or sets the category the booking belongs to.
        /// </summary>
        ///
        /// <value>
        /// The booking category.
        /// </value>
        public DataCategory BookingCategory { get; }

        /// <summary>
        /// Gets the category the address belongs to.
        /// </summary>
        ///
        /// <value>
        /// The address category.
        /// </value>
        public DataCategory AddressCategory { get; }

        /// <summary>
        /// Gets the category the terms of payment belongs to.
        /// </summary>
        ///
        /// <value>
        /// The terms of payment category.
        /// </value>
        public DataCategory TermsOfPaymentCategory { get; }
    }
}