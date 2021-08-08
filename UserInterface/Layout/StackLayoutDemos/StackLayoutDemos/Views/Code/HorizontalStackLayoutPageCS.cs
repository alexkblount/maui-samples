using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace StackLayoutDemos.Views
{
    public class HorizontalStackLayoutPageCS : ContentPage
    {
        public HorizontalStackLayoutPageCS()
        {
            Title = "Horizontal StackLayout demo";
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    new BoxView { Color = Colors.Red },
                    new BoxView { Color = Colors.Yellow },
                    new BoxView { Color = Colors.Blue },
                    new BoxView { Color = Colors.Green },
                    new BoxView { Color = Colors.Orange },
                    new BoxView { Color = Colors.Purple }
                }
            };
        }
    }
}
