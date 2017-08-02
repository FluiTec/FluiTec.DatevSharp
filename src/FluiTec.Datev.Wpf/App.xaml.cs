using System.Globalization;
using System.Windows;

namespace FluiTec.Datev.Wpf
{
	/// <summary>
	/// Interaktionslogik für "App.xaml"
	/// </summary>
	public partial class App
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(name: "de-DE");
			System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo(name: "de-DE");
		}
	}
}
