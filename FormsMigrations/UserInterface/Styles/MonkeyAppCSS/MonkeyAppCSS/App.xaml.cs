﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;
using MonkeyApp.Views;

namespace MonkeyAppCSS
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MonkeysPage();
		}
	}
}