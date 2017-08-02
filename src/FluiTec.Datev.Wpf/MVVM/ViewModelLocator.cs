using FluiTec.Datev.Wpf.Services;
using FluiTec.Datev.Wpf.ViewModel;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace FluiTec.Datev.Wpf.MVVM
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
			SimpleIoc.Default.Register<ISerializer>(() => new XmlSerializer());

			SimpleIoc.Default.Register<IExportService>(() => new ExportService(SimpleIoc.Default.GetInstance<ISerializer>()));
			SimpleIoc.Default.Register<IConsultantService>(() => new ConsultantService(SimpleIoc.Default.GetInstance<ISerializer>()));

			SimpleIoc.Default.Register<MainViewModel>();
			SimpleIoc.Default.Register<ExportViewModel>();
		}

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

		public ExportViewModel Export => ServiceLocator.Current.GetInstance<ExportViewModel>();

		public static void Cleanup()
        {
            
        }
    }
}