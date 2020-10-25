using System.Diagnostics;
using System.Reflection;
using System.Windows;

namespace EverythingToolbar
{
	public partial class About : Window
	{
		public About()
		{
			InitializeComponent();
			Namebar.Text ="EverythingToolbar   " + Assembly.GetExecutingAssembly().GetName().Version;
			Namebar.FontSize = 22;
			
			
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
		{
			Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
			e.Handled = true;
		}
	}
}
