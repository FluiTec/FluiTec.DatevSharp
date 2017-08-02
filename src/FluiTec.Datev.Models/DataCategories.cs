using System;
using FluiTec.Datev.Models.Rows;

namespace FluiTec.Datev.Models
{
	/// <summary>   A data categories. </summary>
	public static class DataCategories
	{
		/// <summary>   The bookings. </summary>
		public static DataCategory Bookings => new DataCategory(number: 21, name: "Buchungsstapel", version: 7);

		/// <summary>   The recurring bookings. </summary>
		public static DataCategory RecurringBookings => new DataCategory(number: 65, name: "Wiederkehrende Buchungen",
			version: 2);

		/// <summary>   The booking text constants. </summary>
		public static DataCategory BookingTextConstants => new DataCategory(number: 67, name: "Buchungstextkonstanten",
			version: 1);

		/// <summary>   List of names of the nominal accounts. </summary>
		public static DataCategory NominalAccountNames => new DataCategory(number: 20, name: "Kontenbeschriftungen",
			version: 2);

		/// <summary>   The account notes. </summary>
		public static DataCategory AccountNotes => new DataCategory(number: 47, name: "Konto-Notizen", version: 1);

		/// <summary>   The addresses. </summary>
		public static DataCategory Addresses => new DataCategory(number: 16, name: "Debitoren/Kreditoren", version: 4);

		/// <summary>   The text keys. </summary>
		public static DataCategory TextKeys => new DataCategory(number: 44, name: "Textschlüssel", version: 2);

		/// <summary>   The terms of payment. </summary>
		public static DataCategory TermsOfPayment => new DataCategory(number: 46, name: "Zahlungsbedingungen", version: 2);

		/// <summary>   The misc addresses. </summary>
		public static DataCategory MiscAddresses => new DataCategory(number: 48, name: " Diverse Adressen", version: 2);

		/// <summary>   The system bookings. </summary>
		public static DataCategory SystemBookings => new DataCategory(number: 63,
			name: "Anlagenbuchführung – Buchungssatzvorlagen", version: 1);

		/// <summary>   The system branches. </summary>
		public static DataCategory SystemBranches => new DataCategory(number: 62, name: "Anlagenbuchführung – Filialen",
			version: 1);

		/// <summary>   Gets header row. </summary>
		/// <param name="category"> The category. </param>
		/// <returns>   The header row. </returns>
		public static IDatevRow GetHeaderRow(DataCategory category)
		{
			switch (category.Number)
			{
				case 16: // Debitoren/Kreditoren
					switch (category.Version)
					{
						case 4:
							return new AddressHeaderRow();
						default:
							throw new NotImplementedException();
					}
				case 21: // Buchungsstapel
					switch (category.Version)
					{
						case 7:
							return new BookingHeaderRow();
						default:
							throw new NotImplementedException();
					}
				case 46: // Zahlungsbedingungen
					switch (category.Version)
					{
						case 2:
							return new TermsOfPaymentHeaderRow();
						default:
							throw new NotImplementedException();
					}
				default:
					throw new NotImplementedException();
			}
		}
	}
}