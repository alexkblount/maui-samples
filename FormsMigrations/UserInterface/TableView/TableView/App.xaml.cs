using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;
using TableViewSamples;

namespace TableView
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			bool useXaml = true; //set to your desired preference
			var tabs = new Microsoft.Maui.Controls.TabbedPage();

			if (useXaml)
			{
				tabs.Children.Add(new DataIntentXaml());
				tabs.Children.Add(new FormIntentXaml());
				tabs.Children.Add(new MenuIntentXaml());
				tabs.Children.Add(new SettingsIntentXaml());
				tabs.Children.Add(new SwitchCellDemoXaml());
				tabs.Children.Add(new EntryCellDemoXaml());
			}
            else
            {
				tabs.Children.Add(new DataIntentCode());
				tabs.Children.Add(new FormIntentCode());
				tabs.Children.Add(new MenuIntentCode());
				tabs.Children.Add(new SettingsIntentCode());
				tabs.Children.Add(new SwitchCellDemoCode());
				tabs.Children.Add(new EntryCellDemoCode());
			}
				
			MainPage = tabs;
		}
	}
}
