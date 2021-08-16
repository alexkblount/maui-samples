using System;
using Microsoft.Maui.Controls;
using Com.Xamarin.Textcounter;

namespace NativeBindings
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			int count = TextCounter.NumConsonants("Some random text 123!!!");
			CounterLabel.Text = $"Consonants count: {count}";
		}
	}
}
