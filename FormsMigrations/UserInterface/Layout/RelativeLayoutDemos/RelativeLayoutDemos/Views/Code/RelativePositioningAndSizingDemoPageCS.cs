using Microsoft.Maui;
using Microsoft.Maui.Controls;
using CMP = Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Graphics;

namespace RelativeLayoutDemos.Views
{
    public class RelativePositioningAndSizingDemoPageCS : ContentPage
    {
        public RelativePositioningAndSizingDemoPageCS()
        {
            CMP.RelativeLayout relativeLayout = new CMP.RelativeLayout();

            // Four BoxView's
            relativeLayout.Children.Add(
                new BoxView { Color = Colors.Red },
                CMP.Constraint.Constant(0),
                CMP.Constraint.Constant(0));

            relativeLayout.Children.Add(
                new BoxView { Color = Colors.Green },
                CMP.Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width - 40;
                }), CMP.Constraint.Constant(0));

            relativeLayout.Children.Add(
                new BoxView { Color = Colors.Blue },
                CMP.Constraint.Constant(0),
                CMP.Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height - 40;
                }));

            relativeLayout.Children.Add(
                new BoxView { Color = Colors.Yellow },
                CMP.Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width - 40;
                }),
                CMP.Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height - 40;
                }));

            // Centered and 1/3 width and height of parent
            BoxView silverBoxView = new BoxView { Color = Colors.Silver };
            relativeLayout.Children.Add(
                silverBoxView,
                CMP.Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.33;
                }),
                CMP.Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.33;
                }),
                CMP.Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.33;
                }),
                CMP.Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.33;
                }));

            // 1/3 width and height of previous
            relativeLayout.Children.Add(
                new BoxView { Color = Colors.Black },
                CMP.Constraint.RelativeToView(silverBoxView, (parent, sibling) =>
                {
                    return sibling.X;
                }),
                CMP.Constraint.RelativeToView(silverBoxView, (parent, sibling) =>
                {
                    return sibling.Y;
                }),
                CMP.Constraint.RelativeToView(silverBoxView, (parent, sibling) =>
                {
                    return sibling.Width * 0.33;
                }),
                CMP.Constraint.RelativeToView(silverBoxView, (parent, sibling) =>
                {
                    return sibling.Height * 0.33;
                }));

            Title = "RelativeLayout demo";
            Content = relativeLayout;
        }
    }
}
