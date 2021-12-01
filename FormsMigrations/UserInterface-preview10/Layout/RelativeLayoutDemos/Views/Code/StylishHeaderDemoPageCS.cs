using Microsoft.Maui;
using Microsoft.Maui.Controls;
using CMP = Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Graphics;

namespace RelativeLayoutDemos.Views
{
    public class StylishHeaderDemoPageCS : ContentPage
    {
        public StylishHeaderDemoPageCS()
        {
            CMP.RelativeLayout relativeLayout = new CMP.RelativeLayout
            {
                Margin = new Thickness(20)
            };

            relativeLayout.Children.Add(new BoxView
            {
                Color = Colors.Silver
            }, () => new Rectangle(0, 10, 200, 5));

            relativeLayout.Children.Add(new BoxView
            {
                Color = Colors.Silver
            }, () => new Rectangle(0, 20, 200, 5));

            relativeLayout.Children.Add(new BoxView
            {
                Color = Colors.Silver
            }, () => new Rectangle(10, 0, 5, 65));

            relativeLayout.Children.Add(new BoxView
            {
                Color = Colors.Silver
            }, () => new Rectangle(20, 0, 5, 65));

            relativeLayout.Children.Add(new Label
            {
                Text = "Stylish Header",
                FontSize = 24
            }, CMP.Constraint.Constant(30), CMP.Constraint.Constant(25));

            relativeLayout.Children.Add(new Label
            {
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span { Text = "Although "},
                        new Span { Text = "RelativeLayout", FontAttributes = FontAttributes.Italic },
                        new Span { Text = " is usually employed for purposes other than the display of text using a " },
                        new Span { Text = "Label", FontAttributes = FontAttributes.Italic },
                        new Span { Text = ", obviously it can be used in that way. The text continues to wrap nicely within the bounds of the container and any margin that might be applied." }
                    }
                }
            }, CMP.Constraint.Constant(0), CMP.Constraint.Constant(80));

            Title = "Stylish header demo";
            Content = relativeLayout;
        }
    }
}

