using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using FluiTec.Datev.Models;
using FluiTec.Datev.Models.Rows;
using FluiTec.Datev.Wpf.Data;
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

			FinishCommand = new RelayCommand(async () =>
			{
				await ExportDatev();
				MessageBox.Show(Application.Current.MainWindow, messageBoxText: "Export abgeschlossen", caption: "Export", button: MessageBoxButton.OK);
			});
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
		private Task ExportDatev()
		{
			return Task.Factory.StartNew(() =>
			{
				var consultant = ServiceLocator.Current.GetInstance<IConsultantService>().Get();
				var dateRange = DateRangeSelectionViewModel as DateRangeSelectionModel;
				if (dateRange == null) throw new NullReferenceException();

				var dataSelection = DataSelectionModel as DataSelectionModel;
				if (dataSelection == null) return;
				var files = new List<DatevFile>();

				if (dataSelection.ExportAddresses)
				{
					var file = ExportAddresses(consultant);
					if (file.Rows.Count > 0)
						files.Add(file);
				}

				if (dataSelection.ExportPaymentConditions)
					files.Add(ExportPaymentConditions(consultant));

				if (dataSelection.ExportBookings)
					files.Add(ExportBookings(consultant));

				var exportModel = new ExportModel
				{
					Name = DateTime.Today.ToShortDateString(),
					Exported = DateTime.Now,
					From = dateRange.From,
					Till = dateRange.Till
				};

				foreach (var file in files)
				{
					// construct filePath
					var baseFolder = Properties.Settings.Default.BaseDir;
					var exportFolder = Properties.Settings.Default.ExportsFolder;
					var fileName = file.GetExportFileName();
					var filePath = Path.Combine(baseFolder, exportFolder, fileName);

					// save file
					using (var sw = new StreamWriter(filePath, append: false, encoding: System.Text.Encoding.Default))
					{
						sw.Write(file.ToDatev());
					}

					// add to list
					exportModel.SavedFiles.Add(filePath);
				}

				var exportService = ServiceLocator.Current.GetInstance<IExportService>();
				var collection = new ObservableCollection<ExportModel>(exportService.GetExports()) { exportModel};
				exportService.SetExports(collection);
			});
		}

		/// <summary>	Export addresses. </summary>
		/// <param name="consultant">	The consultant. </param>
		private DatevFile ExportAddresses(ConsultantModel consultant)
		{
			var differential = DifferentialExportModel as DifferentialExportModel;
			IEnumerable<AddressRow> rows;
			// collect data
			using (var db = new wtsEntities())
			{
				rows = db.Adressens.Where(a => a.Konto != null)
					.ToList()
					.Select(a => new AddressRow
					{
						// ReSharper disable once PossibleInvalidOperationException
						AccountNumber = a.Konto.Value,
						Salutation = new StringModel(new[] { 30, 50, 50, 36 }, a.Name1, a.Name2, a.Name3).TargetStrings[index: 0],
						Name_Enterprise = new StringModel(new[] { 30, 50, 50, 36 }, a.Name1, a.Name2, a.Name3).TargetStrings[index: 1],
						NameExtension1 = new StringModel(new[] { 30, 50, 50, 36 }, a.Name1, a.Name2, a.Name3).TargetStrings[index: 2],
						NameExtension2 = new StringModel(new[] { 30, 50, 50, 36 }, a.Name1, a.Name2, a.Name3).TargetStrings[index: 3],
						Street = a.Straße == null || a.Straße.Length <= 36 ? a.Straße : a.Straße.Substring(startIndex: 0, length: 36),
						PostBox = a.Postfach != null ? new string(a.Postfach.Select(c => c).Where(char.IsDigit).ToArray()) : null,
						ZipCode = a.Postanschrift == 0 ? a.PLZ : a.PPZ,
						City = a.Postanschrift == 0 ? a.Ort : a.Postfachort,
						ShortName = a.Kurzname.Length <= 15 ? a.Kurzname : a.Kurzname.Substring(startIndex: 0, length: 15),
						AddressType = 2,
						PostalAddressType = a.Postanschrift == 0 ? "STR" : "PF"
					});
			}

			if (differential?.CurrentExport != null)
			{
				var oldRecords = ParseAddressExport(differential.CurrentExport);
				rows = RemoveByDifferential(rows, oldRecords);
			}

			// create datev-file
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

			foreach(var row in rows)
				file.Rows.Add(row);

			return file;
		}

		private IEnumerable<AddressRow> ParseAddressExport(ExportModel model)
		{
			return new List<AddressRow>();
		}

		/// <summary>	Enumerates remove by differential in this collection. </summary>
		///
		/// <param name="newAddresses">	The new addresses. </param>
		/// <param name="oldAddresses">	The old addresses. </param>
		///
		/// <returns>
		/// An enumerator that allows foreach to be used to process remove by differential in this
		/// collection.
		/// </returns>
		private IEnumerable<AddressRow> RemoveByDifferential(IEnumerable<AddressRow> newAddresses,
			IEnumerable<AddressRow> oldAddresses)
		{
			return newAddresses;
		}

		/// <summary>	Export payment conditions. </summary>
		/// <param name="consultant">	The consultant. </param>
		private static DatevFile ExportPaymentConditions(ConsultantModel consultant)
		{
			IEnumerable<TermsOfPaymentRow> rows;
			// collect data
			using (var db = new wtsEntities())
			{
				rows = db.Zahlungsartens.Where(z => z.Externname != null)
					.ToList()
					.Select(z => new TermsOfPaymentRow
					{
						Number = int.Parse(z.Externname),
						Name = z.Name,
						DueType = 1,
						CashDiscount1Percent = z.Skontosatz1.HasValue ? (int?)(z.Skontosatz1.Value * 10000) : null,
						CashDiscount1Days = z.Skontotage1,
						CashDiscount2Percent = z.Skontosatz2.HasValue ? (int?)(z.Skontosatz2.Value * 10000) : null,
						CashDiscount2Days = z.Skontotage2,
						Days = z.Zieltage
					});
			}

			// create datev-file
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

			foreach(var row in rows)
				file.Rows.Add(row);

			return file;
		}

		/// <summary>	Export bookings. </summary>
		/// <param name="consultant">	The consultant. </param>
		private DatevFile ExportBookings(ConsultantModel consultant)
		{
			var currencySymbol = new RegionInfo(System.Threading.Thread.CurrentThread.CurrentUICulture.LCID).ISOCurrencySymbol;
			var dateRange = DateRangeSelectionViewModel as DateRangeSelectionModel;

			IEnumerable<BookingRow> rows;
			// collect data
			using (var db = new wtsEntities())
			{
				rows = db.Buchungens
					.Where(b => b.Buchhaltungsdatum != null && 
						b.Buchhaltungsdatum.Value >= dateRange.From && b.Buchhaltungsdatum.Value <= dateRange.Till && b.Betrag > 0)
					.Join(db.Adressens, fk => fk.Kurzname, pk => pk.Kurzname, (fk, pk) => 
						new { Address = pk, Booking = fk})
					.Join(db.Buchungsartens, fk => fk.Booking.Buchungsart, pk => pk.Name, (fk, pk) => 
						new { fk.Address, fk.Booking, BookingType = pk })
					.Join(db.Zahlungsartens, fk => fk.Booking.Zahlungsart, pk => pk.Name, (fk, pk) => 
						new { fk.Address, fk.Booking, fk.BookingType, PaymentCondition = pk})
					.Join(db.Projektzweiges, fk => fk.Booking.Belegnummer, pk => pk.Belegnummer, (fk, pk) =>
						new { fk.Address, fk.Booking, fk.BookingType, fk.PaymentCondition, Invoice = pk })
					.Join(db.Projektmerkmales, fk => fk.Invoice.Nummer, pk => pk.Nummer, (fk, pk) => 
						new { fk.Address, fk.Booking, fk.BookingType, fk.PaymentCondition, fk.Invoice, Specification = pk })
					.GroupBy(e => e.Invoice.Belegnummer)
					.Select(g => new
						{
						g.FirstOrDefault().Address,
						g.FirstOrDefault().Booking,
						g.FirstOrDefault().BookingType,
						g.FirstOrDefault().Invoice,
						g.FirstOrDefault().PaymentCondition,
						SpecificationElement = g.FirstOrDefault(e => e.Specification.Merkmal == "Lieferdatum") })
					.ToList()
					.Select(b => new BookingRow(currencySymbol)
					{
						// ReSharper disable PossibleInvalidOperationException
						Volume = Math.Round(Math.Abs(b.Booking.Betrag.Value), decimals: 2),
						AccountNumber = b.Booking.Betrag.Value > 0m ? b.Address.Konto.Value.ToString() : "8400",
						ContraAccountNumber = b.Booking.Betrag.Value > 0m ? "8400" : b.Address.Konto.Value.ToString(),
						TaxKey = b.BookingType.Buchungscode.ToString(),
						Date = b.Booking.Valutadatum.Value,
						BookingText = b.Booking.Buchungstext == null || b.Booking.Buchungstext.Length <= 60 ? b.Booking.Buchungstext : b.Booking.Buchungstext.Substring(startIndex: 0, length: 60),
						DocumentField1 = b.Booking.Belegnummer,
						DocumentField2 = b.PaymentCondition.Externname,
						CountryCodeAndTaxId = b.Booking.UStID,
						//ActivityDate = DateTime.TryParse()
						// ReSharper enable PossibleInvalidOperationException
					});
			}

			// create datev-file
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

			foreach (var row in rows)
				file.Rows.Add(row);

			return file;
		}

		#endregion
	}
}