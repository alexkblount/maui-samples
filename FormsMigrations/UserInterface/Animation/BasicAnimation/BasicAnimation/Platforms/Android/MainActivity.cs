﻿		using Android.App;
		using Android.Content.PM;
		using Android.OS;
		using Microsoft.Maui;
		using Microsoft.Maui.Graphics;
		
		namespace BasicAnimation.Droid
		{
		    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
			public class MainActivity : MauiAppCompatActivity
			{
			}
}