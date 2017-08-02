using System;
using System.Linq;
using FluiTec.Datev.Wpf.Services;
using FluiTec.Datev.Wpf.ViewModel;
using Microsoft.Practices.ServiceLocation;

namespace FluiTec.Datev.Wpf.Wizard
{
	public class DateRangeSelectionModel : WizardPageViewModel
	{
		#region Constructors

		public DateRangeSelectionModel()
		{
			Title = "Datumswahl";
			Description = "Dient dem Eingrenzen der Exporte des Buchungsstapels";
			Content = new DateRangeSelectionPage();

			Till = DateTime.Today.Add(new TimeSpan(days: 0, hours: 23, minutes: 59, seconds: 59));

			var lastExport =
				ServiceLocator.Current.GetInstance<IExportService>()
					.GetExports()
					.OrderByDescending(e => e.Till)
					.FirstOrDefault();
			From = lastExport?.Till.AddSeconds(value: 1) ?? DateTime.Today.Subtract(new TimeSpan(DateTime.Today.Day,hours: 0,minutes: 0,seconds: 0));
		}

		#endregion

		#region Methods

		/// <summary>	Validates the model. </summary>
		/// <returns>	True if it succeeds, false if it fails. </returns>
		protected override bool ValidateModel()
		{
			return From < Till;
		}

		#endregion

		#region Fields

		private DateTime _from;
		private DateTime _till;

		#endregion

		#region Properties

		/// <summary>	Gets or sets the Date/Time of from. </summary>
		/// <value>	from. </value>
		public DateTime From
		{
			get { return _from; }
			set
			{
				_from = value;
				OnPropertyChanged();
				Validate();
			}
		}

		/// <summary>	Gets or sets the Date/Time of the till. </summary>
		/// <value>	The till. </value>
		public DateTime Till
		{
			get { return _till; }
			set
			{
				_till = value;
				OnPropertyChanged();
				Validate();
			}
		}

		#endregion
	}
}