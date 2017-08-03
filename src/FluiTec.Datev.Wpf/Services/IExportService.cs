using System;
using System.Collections.ObjectModel;
using FluiTec.Datev.Wpf.Models;

namespace FluiTec.Datev.Wpf.Services
{
	/// <summary>	Interface for export service. </summary>
	public interface IExportService
	{
		event EventHandler<EventArgs> ExportsUpdated;
		ObservableCollection<ExportModel> GetExports();
		void SetExports(ObservableCollection<ExportModel> models);
	}
}