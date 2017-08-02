using System.Linq;
using FluiTec.Datev.Wpf.ViewModel;

namespace FluiTec.Datev.Wpf.Wizard
{
	/// <summary>	A data Model for the data selection. </summary>
	public class DataSelectionModel : WizardPageViewModel
	{
		#region Constructors

		public DataSelectionModel()
		{
			Title = "Daten-Auswahl";
			Description = "Dient der Einschränkung der Export-Daten nach Typ";
			Content = new DataSelectionPage();
			ExportAddresses = true;
			ExportPaymentConditions = true;
			ExportBookings = true;
		}

		#endregion

		#region Methods

		/// <summary>	Validates the model. </summary>
		/// <returns>	True if it succeeds, false if it fails. </returns>
		protected override bool ValidateModel()
		{
			return new[] {ExportAddresses, ExportPaymentConditions, ExportBookings}.Any(b => b);
		}

		#endregion

		#region Fields

		private bool _exportAddresses;
		private bool _exportPaymentConditions;
		private bool _exportBookings;

		#endregion

		#region Properties

		/// <summary>	Gets or sets a value indicating whether the addresses should be exported. </summary>
		/// <value>	True if export addresses, false if not. </value>
		public bool ExportAddresses
		{
			get { return _exportAddresses; }
			set
			{
				_exportAddresses = value;
				OnPropertyChanged();
				Validate();
			}
		}

		/// <summary>
		///     Gets or sets a value indicating whether the payment conditions should be exported.
		/// </summary>
		/// <value>	True if export payment conditions, false if not. </value>
		public bool ExportPaymentConditions
		{
			get { return _exportPaymentConditions; }
			set
			{
				_exportPaymentConditions = value;
				OnPropertyChanged();
				Validate();
			}
		}

		/// <summary>
		///     Gets or sets a value indicating whether the bookings should be exported.
		/// </summary>
		/// <value>	True if export bookings, false if not. </value>
		public bool ExportBookings
		{
			get { return _exportBookings; }
			set
			{
				_exportBookings = value;
				OnPropertyChanged();
				Validate();
			}
		}

		#endregion
	}
}