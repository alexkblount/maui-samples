using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;

[assembly: XamlCompilationAttribute(XamlCompilationOptions.Compile)]

namespace ThemingDemo
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				})
				.ConfigureMauiHandlers(handlers =>
				{
					#if ANDROID
					handlers.AddCompatibilityRenderer(typeof(ThemingDemo.Droid.CustomNavigationPageRenderer),
						typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.AppCompat.NavigationPageRenderer));
					#endif
					#if IOS
					handlers.AddCompatibilityRenderer(typeof(ThemingDemo.iOS.CustomPageRenderer),
						typeof(Microsoft.Maui.Controls.Compatibility.Platform.iOS.PageRenderer));
					#endif

				});
		}
	}
}