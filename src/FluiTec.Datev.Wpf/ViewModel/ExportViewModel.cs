using System;
using System.Globalization;
using System.Windows.Input;
using FluiTec.Datev.Models;
using FluiTec.Datev.Wpf.Models;
using FluiTec.Datev.Wpf.Services;
using FluiTec.Datev.Wpf.Wizard;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Practices.ServiceLocation;

namespace FluiTec.Datev.Wpf.ViewModel
{
	/// <summary>	A ViewModel for the export. </summary>
	public class ExportViewModel : ViewModelBase
	{
		#region Constructors

		/// <summary>	Default constructor. </summary>
		public ExportViewModel()
		{
			Title = "DATEV - Export-Assistent";
			BaseDataPageViewModel = new BaseDataModel();
			DateRangeSelectionViewModel = new DateRangeSelectionModel();
			DifferentialExportModel = new DifferentialExportModel();
			DataSelectionModel = new DataSelectionModel();

			BaseDataPageViewModel.Next = DateRangeSelectionViewModel;
			DateRangeSelectionViewModel.Previous = BaseDataPageViewModel;
			DateRangeSelectionViewModel.Next = DifferentialExportModel;
			DifferentialExportModel.Previous = DateRangeSelectionViewModel;
			DifferentialExportModel.Next = DataSelectionModel;
			DataSelectionModel.Previous = DifferentialExportModel;

			FinishCommand = new RelayCommand(ExportDatev);
		}

		#endregion

		#region Commands

		/// <summary>	Gets or sets the finish command. </summary>
		/// <value>	The finish command. </value>
		public ICommand FinishCommand { get; set; }

		#endregion

		#region Properties

		/// <summary>	Gets or sets the title. </summary>
		/// <value>	The title. </value>
		public string Title { get; set; }

		/// <summary>	Gets or sets the base data page view model. </summary>
		/// <value>	The base data page view model. </value>
		public WizardPageViewModel BaseDataPageViewModel { get; set; }

		/// <summary>	Gets or sets the date range selection view model. </summary>
		/// <value>	The date range selection view model. </value>
		public WizardPageViewModel DateRangeSelectionViewModel { get; set; }

		/// <summary>	Gets or sets the differential export model. </summary>
		/// <value>	The differential export model. </value>
		public WizardPageViewModel DifferentialExportModel { get; set; }

		/// <summary>	Gets or sets the data selection model. </summary>
		/// <value>	The data selection model. </value>
		public WizardPageViewModel DataSelectionModel { get; set; }

		#endregion

		#region Methods

		/// <summary>	Export datev-files. </summary>
		private void ExportDatev()
		{
			var consultant = ServiceLocator.Current.GetInstance<IConsultantService>().Get();

			var dataSelection = DataSelectionModel as DataSelectionModel;
			if (dataSelection == null) return;

			if (dataSelection.ExportAddresses)
				ExportAddresses(consultant);

			if (dataSelection.ExportPaymentConditions)
				ExportPaymentConditions(consultant);

			if (dataSelection.ExportBookings)
				ExportBookings(consultant);
		}

		/// <summary>	Export addresses. </summary>
		/// <param name="consultant">	The consultant. </param>
		private void ExportAddresses(ConsultantModel consultant)
		{
			var file = new DatevFile
			{
				Header = new DatevHeader(Environment.UserName)
				{
					DataCategory = DataCategories.Addresses,
					Source = "RE",
					ConsultantNumber = consultant.ConsultantNumber,
					ClientNumber = consultant.ClientNumber,
					BookingType = null,
					BillingIntention = null
				}
			};
		}

		/// <summary>	Export payment conditions. </summary>
		/// <param name="consultant">	The consultant. </param>
		private void ExportPaymentConditions(ConsultantModel consultant)
		{
			var file = new DatevFile
			{
				Header = new DatevHeader(Environment.UserName)
				{
					DataCategory = DataCategories.TermsOfPayment,
					Source = "RE",
					ConsultantNumber = consultant.ConsultantNumber,
					ClientNumber = consultant.ClientNumber,
					BookingType = null,
					BillingIntention = null
				}
			};
		}

		/// <summary>	Export bookings. </summary>
		/// <param name="consultant">	The consultant. </param>
		private void ExportBookings(ConsultantModel consultant)
		{
			var dateRange = DateRangeSelectionViewModel as DateRangeSelectionModel;
			var file = new DatevFile
			{
				Header = new DatevHeader(Environment.UserName, new RegionInfo(System.Threading.Thread.CurrentThread.CurrentUICulture.LCID).ISOCurrencySymbol)
				{
					DataCategory = DataCategories.Bookings,
					Source = "RE",
					ConsultantNumber = consultant.ConsultantNumber,
					ClientNumber = consultant.ClientNumber,
					BookingsFrom = dateRange?.From,
					BookingsTill = dateRange?.Till
				}
			};
		}

		#endregion
	}
}