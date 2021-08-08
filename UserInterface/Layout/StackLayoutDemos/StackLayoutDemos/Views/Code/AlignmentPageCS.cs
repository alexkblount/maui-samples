using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace StackLayoutDemos.Views
{
    public class AlignmentPageCS : ContentPage
    {
        public AlignmentPageCS()
        {
			Title = "Alignment demo";
			Content = new StackLayout
			{
				Margin = new Thickness(20),
				Children =
                {
					new Label { Text = "Start", BackgroundColor = Colors.Gray, HorizontalOptions = LayoutOptions.Start },
					new Label { Text = "Center", BackgroundColor = Colors.Gray, HorizontalOptions = LayoutOptions.Center },
					new Label { Text = "End", BackgroundColor = Colors.Gray, HorizontalOptions = LayoutOptions.End },
					new Label { Text = "Fill", BackgroundColor = Colors.Gray, HorizontalOptions = LayoutOptions.Fill }
				}
			};
		}
    }
}
