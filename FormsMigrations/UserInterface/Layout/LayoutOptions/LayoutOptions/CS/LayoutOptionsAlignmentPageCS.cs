using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;
using Microsoft.Maui.Graphics;

namespace LayoutOptionsDemo
{
	public class LayoutOptionsAlignmentPageCS : ContentPage
	{
		public LayoutOptionsAlignmentPageCS()
		{
			Title = "Alignment";
			IconImageSource = "csharp.png";

			Content = new StackLayout
			{
				Margin = new Thickness(0, 20, 0, 0),
				Children = {
					new Label { Text = "LayoutOptions - Alignment", FontAttributes = FontAttributes.Bold, HorizontalOptions = Microsoft.Maui.Controls.LayoutOptions.Center },
					new Label { Text = "Start", BackgroundColor = Colors.Gray, HorizontalOptions = Microsoft.Maui.Controls.LayoutOptions.Start },
					new Label { Text = "Center", BackgroundColor = Colors.Gray, HorizontalOptions = Microsoft.Maui.Controls.LayoutOptions.Center },
					new Label { Text = "End", BackgroundColor = Colors.Gray, HorizontalOptions = Microsoft.Maui.Controls.LayoutOptions.End },
					new Label { Text = "Fill", BackgroundColor = Colors.Gray, HorizontalOptions = Microsoft.Maui.Controls.LayoutOptions.Fill }
				}
			};
		}
	}
}
