using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace TextSample
{
	public class App : Application
	{
		public App ()
		{
            // The root page of your application
            MainPage = new NavigationPage(new ListPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

