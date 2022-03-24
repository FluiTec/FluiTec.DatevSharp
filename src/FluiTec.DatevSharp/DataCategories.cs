using System;
using System.IO;
using System.Linq;
using FluiTec.DatevSharp.Interfaces;
using FluiTec.DatevSharp.Rows.AddressRow;
using FluiTec.DatevSharp.Rows.BookingRow;
using FluiTec.DatevSharp.Rows.TermsOfPaymentRow;
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
        static DataCategories()
        {
            var asm = typeof(DataCategories).Assembly;
			using (var mapResource = asm.GetManifestResourceStream("FluiTec.DatevSharp.Formats.format_map.json"))
            using (var sr = new StreamReader(mapResource ?? throw new InvalidOperationException()))
            using (var jr = new JsonTextReader(sr))
            {
                var serializer = new JsonSerializer();
                var categories = serializer.Deserialize<DataCategory[]>(jr);
                BookingCategory = (categories ?? throw new InvalidOperationException()).Single(c => c.Name == BookingsName);
                AddressCategory = (categories ?? throw new InvalidOperationException()).Single(c => c.Name == AddressName);
                TermsOfPaymentCategory = (categories ?? throw new InvalidOperationException()).Single(c => c.Name == TermsOfPaymentName);
            }
        }

		/// <summary>
		/// Constructor that prevents a default instance of this class from being created.
		/// </summary>
		private DataCategories()
        {
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
        public static DataCategory BookingCategory { get; }

        /// <summary>
        /// Gets the category the address belongs to.
        /// </summary>
        ///
        /// <value>
        /// The address category.
        /// </value>
        public static DataCategory AddressCategory { get; }

        /// <summary>
        /// Gets the category the terms of payment belongs to.
        /// </summary>
        ///
        /// <value>
        /// The terms of payment category.
        /// </value>
        public static DataCategory TermsOfPaymentCategory { get; }
    }
}