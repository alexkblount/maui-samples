using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;
using Microsoft.Maui.Graphics;

namespace LayoutOptionsDemo
{
	public class LayoutOptionsExpansionPageCS : ContentPage
	{
		public LayoutOptionsExpansionPageCS()
		{
			Title = "Expansion";
			IconImageSource = "csharp.png";

			Content = new StackLayout
			{
				Margin = new Thickness(0, 20, 0, 0),
				Children = {
					new Label { Text = "LayoutOptions - Expansion", FontAttributes = FontAttributes.Bold, HorizontalOptions = Microsoft.Maui.Controls.LayoutOptions.Center },
					new BoxView { BackgroundColor = Colors.Red, HeightRequest = 1 },
					new Label { Text = "StartAndExpand", BackgroundColor = Colors.Gray, VerticalOptions = Microsoft.Maui.Controls.LayoutOptions.StartAndExpand },
					new BoxView { BackgroundColor = Colors.Red, HeightRequest = 1 },
					new Label { Text = "CenterAndExpand", BackgroundColor = Colors.Gray, VerticalOptions = Microsoft.Maui.Controls.LayoutOptions.CenterAndExpand },
					new BoxView { BackgroundColor = Colors.Red, HeightRequest = 1 },
					new Label { Text = "EndAndExpand", BackgroundColor = Colors.Gray, VerticalOptions = Microsoft.Maui.Controls.LayoutOptions.EndAndExpand },
					new BoxView { BackgroundColor = Colors.Red, HeightRequest = 1 },
					new Label { Text = "FillAndExpand", BackgroundColor = Colors.Gray, VerticalOptions = Microsoft.Maui.Controls.LayoutOptions.FillAndExpand },
					new BoxView { BackgroundColor = Colors.Red, HeightRequest = 1 }
				}
			};
		}
	}
}
