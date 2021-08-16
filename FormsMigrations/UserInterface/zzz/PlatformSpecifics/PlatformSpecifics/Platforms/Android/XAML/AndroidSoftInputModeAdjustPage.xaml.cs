using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
	public partial class AndroidSoftInputModeAdjustPage : ContentPage
	{
		public AndroidSoftInputModeAdjustPage()
		{
			InitializeComponent();
		}

		void OnPanButtonClicked(object sender, EventArgs e)
		{
			App.Current.On<Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Pan);
		}

		void OnResizeButtonClicked(object sender, EventArgs e)
		{
			App.Current.On<Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
		}
	}
}
