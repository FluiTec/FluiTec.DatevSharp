using System.Collections.ObjectModel;
using FluiTec.Datev.Wpf.Models;
using FluiTec.Datev.Wpf.Services;
using FluiTec.Datev.Wpf.Views;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Practices.ServiceLocation;
using ViewModelBase = GalaSoft.MvvmLight.ViewModelBase;

namespace FluiTec.Datev.Wpf.ViewModel
{
    /// <summary>	A ViewModel for the mainwindow. </summary>
    public class MainViewModel : ViewModelBase
    {
	    /// <summary>	The export service. </summary>
	    private readonly IExportService _exportService;

		#region Constructors

		/// <summary>	Default constructor. </summary>
		public MainViewModel()
		{
			Title = "DATEV - Export";

			_exportService = ServiceLocator.Current.GetInstance<IExportService>();
			Exports = _exportService.GetExports();

			StartExportCommand = new RelayCommand(() =>
			{
				new ExportWindow().ShowDialog();
			});
		}

		#endregion

		#region Properties

		/// <summary>	Gets or sets the title. </summary>
		/// <value>	The title. </value>
		public string Title { get; set; }

		/// <summary>	Gets or sets the exports. </summary>
		/// <value>	The exports. </value>
		public ObservableCollection<ExportModel> Exports { get; set; }

		#endregion

		#region Commands

		/// <summary>	Gets or sets the start export command. </summary>
		/// <value>	The start export command. </value>
		public System.Windows.Input.ICommand StartExportCommand { get; set; }

		#endregion
	}
}