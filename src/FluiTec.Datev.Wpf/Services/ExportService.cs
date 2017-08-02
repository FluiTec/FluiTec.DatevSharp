using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using FluiTec.Datev.Wpf.Models;
using FluiTec.Datev.Wpf.Properties;

namespace FluiTec.Datev.Wpf.Services
{
	/// <summary>	An export service. </summary>
	public class ExportService : IExportService
	{
		/// <summary>	The serializer. </summary>
		private readonly ISerializer _serializer;

		/// <summary>	Constructor. </summary>
		/// <param name="serializer">	The serializer. </param>
		public ExportService(ISerializer serializer)
		{
			_serializer = serializer;
		}

		/// <summary>	Gets the exports. </summary>
		/// <returns>	The exports. </returns>
		public ObservableCollection<ExportModel> GetExports()
		{
			// auto create directory
			if (!Directory.Exists(Settings.Default.BaseDir))
				Directory.CreateDirectory(Settings.Default.BaseDir);

			var fileName = Path.Combine(Settings.Default.BaseDir, Settings.Default.ExportsFileName);
			if (!File.Exists(fileName))
			{
				// auto create empty file
				_serializer.Serialize(new ObservableCollection<ExportModel>(), fileName);
			}
			var deserialized = _serializer.Deserialize<ObservableCollection<ExportModel>>(fileName)
				.OrderByDescending(m => m.Exported);
			return new ObservableCollection<ExportModel>(deserialized);
		}
	}
}