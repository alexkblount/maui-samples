﻿using System;

using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace WebViewSample
{
	public class LoadingLabelCode : ContentPage
	{
		//these need to be defined at class level for use in methods.
		Microsoft.Maui.Controls.WebView webView;
		Label labelLoading;

		public LoadingLabelCode ()
		{
			this.Title = "Loading Demo";

			var layout = new StackLayout ();

			//Loading label should not render by default.
			labelLoading = new Label () { Text = "Loading...", IsVisible = false};

			webView = new Microsoft.Maui.Controls.WebView () { HeightRequest = 1000, WidthRequest = 1000, Source = "https://dotnet.microsoft.com/apps/xamarin" };

			webView.Navigated += webviewNavigated;
			webView.Navigating += webviewNavigating;

			layout.Children.Add (labelLoading);
			layout.Children.Add (webView);
			Content = layout;
		}

		/// <summary>
		/// Called when the webview starts navigating. Displays the loading label.
		/// </summary>
		void webviewNavigating (object sender, WebNavigatingEventArgs e)
		{
			this.labelLoading.IsVisible = true;
		}

		/// <summary>
		/// Called when the webview finished navigating. Hides the loading label.
		/// </summary>
		void webviewNavigated (object sender, WebNavigatedEventArgs e)
		{
			this.labelLoading.IsVisible = false;
		}
	}
}


