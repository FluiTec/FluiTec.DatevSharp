using FluiTec.Datev.Wpf.Services;
using FluiTec.Datev.Wpf.ViewModel;
using Microsoft.Practices.ServiceLocation;

namespace FluiTec.Datev.Wpf.Wizard
{
	public class BaseDataModel : WizardPageViewModel
	{
		#region Constructors

		/// <summary>	Default constructor. </summary>
		public BaseDataModel()
		{
			Title = "Steuerberater";
			Description = "Dient der Eingabe der Berater- und Klientennummer";
			Content = new BaseDataPage();

			var consultantModel = ServiceLocator.Current.GetInstance<IConsultantService>().Get();
			ConsultantNumber = consultantModel.ConsultantNumber;
			ClientNumber = consultantModel.ClientNumber;
		}

		#endregion

		#region Methods

		/// <summary>	Validates the model. </summary>
		/// <returns>	True if it succeeds, false if it fails. </returns>
		protected override bool ValidateModel()
		{
			return ConsultantNumber > 1 && ClientNumber > 1;
		}

		#endregion

		#region Fields

		private int _consultantNumber;
		private int _clientNumber;

		#endregion

		#region Properties

		/// <summary>	Gets or sets the consultant number. </summary>
		/// <value>	The consultant number. </value>
		public int ConsultantNumber
		{
			get => _consultantNumber;
			set
			{
				_consultantNumber = value;
				OnPropertyChanged();
				Validate();
			}
		}

		/// <summary>	Gets or sets the client number. </summary>
		/// <value>	The client number. </value>
		public int ClientNumber
		{
			get => _clientNumber;
			set
			{
				_clientNumber = value;
				OnPropertyChanged();
				Validate();
			}
		}

		#endregion
	}
}