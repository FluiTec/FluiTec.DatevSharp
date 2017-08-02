using System.Collections.ObjectModel;
using FluiTec.Datev.Wpf.Models;

namespace FluiTec.Datev.Wpf.Services
{
	/// <summary>	Interface for export service. </summary>
	public interface IExportService
	{
		/// <summary>	Gets the exports. </summary>
		/// <returns>	The exports. </returns>
		ObservableCollection<ExportModel> GetExports();
	}
}