using System.Collections.ObjectModel;
using FluiTec.Datev.Wpf.Models;
using FluiTec.Datev.Wpf.Services;
using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;

namespace FluiTec.Datev.Wpf.ViewModel
{
	public class ExportsViewModel : ViewModelBase
	{
		private readonly IExportService _exportService;

		public ExportsViewModel()
		{
			_exportService = ServiceLocator.Current.GetInstance<IExportService>();
			_exportService.ExportsUpdated += (sender, args) => { RaisePropertyChanged(nameof(Exports)); };
		}

		/// <summary>	Gets or sets the exports. </summary>
		/// <value>	The exports. </value>
		public ObservableCollection<ExportModel> Exports {
			get => _exportService.GetExports();
			set
			{
				_exportService.SetExports(value);
				RaisePropertyChanged();
			}
		}
	}
}
