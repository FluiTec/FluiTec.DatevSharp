using System.Collections.ObjectModel;
using System.Linq;
using FluiTec.Datev.Wpf.Models;
using FluiTec.Datev.Wpf.Services;
using FluiTec.Datev.Wpf.ViewModel;
using Microsoft.Practices.ServiceLocation;

namespace FluiTec.Datev.Wpf.Wizard
{
	/// <summary>	A data Model for the differential export. </summary>
	public class DifferentialExportModel : WizardPageViewModel
	{
		#region Fields

		private ExportModel _currentExport;
		private ObservableCollection<ExportModel> _exports;

		#endregion

		#region Constructors

		/// <summary>	Default constructor. </summary>
		public DifferentialExportModel()
		{
			Title = "Differenzieller Export";
			Description = "Dient der Einschränkung der Exportdaten durch einen vorherigen Export";
			Content = new DifferentialExportPage();
			Exports = ServiceLocator.Current.GetInstance<IExportService>().GetExports();
			CurrentExport = Exports.FirstOrDefault();
			IsValid = true; // null for CurrentExport is perfectly valid
		}

		#endregion

		#region Properties

		/// <summary>	Gets or sets the exports. </summary>
		/// <value>	The exports. </value>
		public ObservableCollection<ExportModel> Exports
		{
			get => _exports;
			set
			{
				_exports = value;
				OnPropertyChanged();
			}
		}

		/// <summary>	Gets or sets the current export. </summary>
		/// <value>	The current export. </value>
		public ExportModel CurrentExport
		{
			get => _currentExport;
			set
			{
				_currentExport = value;
				OnPropertyChanged();
			}
		}

		#endregion
	}
}