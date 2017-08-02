namespace FluiTec.Datev.Models.Rows
{
	/// <summary>   The terms of payment header row. </summary>
	public class TermsOfPaymentHeaderRow : IDatevRow
	{
		/// <summary>   Converts this object to a row. </summary>
		/// <returns>   This object as a string. </returns>
		public string ToRow()
		{
			return
				"Nummer;Bezeichnung;Fälligkeitstyp;Skonto 1%;Skonto 1 Tage;Skonto 2 %;Skonto 2 Tage;Fällig Tage;Rechnung bis / Zeitraum 1;Skonto1 Datum / Zeitraum 1;Skonto 1 Monat / Zeitraum 1;Skonto 2 Datum / Zeitraum 1;Skonto 2 Monat / Zeitraum 1;Fällig Datum / Zeitraum 1;Fällig Monat / Zeitraum 1;Rechnung bis / Zeitraum 2;Skonto1 Datum / Zeitraum 2;Skonto 1 Monat / Zeitraum 2;Skonto 2 Datum / Zeitraum 2;Skonto 2 Monat / Zeitraum 2;Fällig Datum / Zeitraum 2;Fällig Monat / Zeitraum 2;Rechnung bis / Zeitraum 3;Skonto1 Datum / Zeitraum 3;Skonto1 Monat / Zeitraum 3;Skonto 2 Datum / Zeitraum 3;Skonto 2 Monat / Zeitraum 3;Fällig Datum / Zeitraum 3;Fällig Monat / Zeitraum 3;Leerfeld;Verwendung";
		}
	}
}