using FluiTec.Datev.Wpf.Models;

namespace FluiTec.Datev.Wpf.Services
{
	/// <summary>	Interface for consultant service. </summary>
	public interface IConsultantService
	{
		/// <summary>	Gets the get. </summary>
		/// <returns>	A ConsultantModel. </returns>
		ConsultantModel Get();
	}
}