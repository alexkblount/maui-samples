using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;
using WebViewSample;

namespace WebView
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var tabs = new Microsoft.Maui.Controls.TabbedPage ();
			var navPage = new NavigationPage { Title="App Content" };
			tabs.Children.Add (navPage);

			bool useXaml = true; //change this to use the code implementation

			if (useXaml) 
            {				
				navPage.PushAsync (new LinkToInAppXaml ());
				tabs.Children.Add (new LoadingLabelXaml ());
                tabs.Children.Add (new EvaluateJavaScriptPage ());
			} 
            else 
            {
				navPage.PushAsync (new LinkToInAppCode ());
				tabs.Children.Add (new LoadingLabelCode ());
			}

			MainPage = tabs;
		}
	}
}
