using System.IO;
using FluiTec.Datev.Wpf.Models;
using FluiTec.Datev.Wpf.Properties;

namespace FluiTec.Datev.Wpf.Services
{
	/// <summary>	A consultant service. </summary>
	public class ConsultantService : IConsultantService
	{
		/// <summary>	The serializer. </summary>
		private readonly ISerializer _serializer;

		/// <summary>	Constructor. </summary>
		/// <param name="serializer">	The serializer. </param>
		public ConsultantService(ISerializer serializer)
		{
			_serializer = serializer;
		}

		/// <summary>	Gets the get. </summary>
		/// <returns>	A ConsultantModel. </returns>
		public ConsultantModel Get()
		{
			// auto create directory
			if (!Directory.Exists(Settings.Default.BaseDir))
				Directory.CreateDirectory(Settings.Default.BaseDir);

			var fileName = Path.Combine(Settings.Default.BaseDir, Settings.Default.ConsultantFileName);
			if (!File.Exists(fileName))
			{
				// auto create empty file
				_serializer.Serialize(new ConsultantModel {ConsultantNumber = 0, ClientNumber = 0}, fileName);
			}
			return _serializer.Deserialize<ConsultantModel>(fileName);
		}
	}
}