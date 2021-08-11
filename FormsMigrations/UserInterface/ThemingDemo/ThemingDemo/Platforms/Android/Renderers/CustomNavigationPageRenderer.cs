using System.Linq;
using Android.Content;
using AndroidX.AppCompat.Widget;
using Android.Views;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility.Platform;
using Microsoft.Maui.Controls.Compatibility.Platform.Android.AppCompat;

namespace ThemingDemo.Droid
{
    public class CustomNavigationPageRenderer : NavigationPageRenderer
    {
        Toolbar modalToolbar;

        public CustomNavigationPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();

            if (Element.CurrentPage is IModalPage)
            {
                var activity = Context as MauiAppCompatActivity;
                var content = activity.FindViewById(Android.Resource.Id.Content) as ViewGroup;
                var toolbars = content.GetChildrenOfType<Toolbar>();

                modalToolbar = toolbars.Last();
                modalToolbar.NavigationClick += OnModalToolbarNavigationClick;
            }
        }

        protected override void OnDetachedFromWindow()
        {
            base.OnDetachedFromWindow();

            if (modalToolbar != null)
            {
                modalToolbar.NavigationClick -= OnModalToolbarNavigationClick;
            }
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);

            if (Element.CurrentPage is IModalPage)
            {
                modalToolbar?.SetNavigationIcon(Resource.Drawable.ic_mtrl_chip_close_circle);
                //                    .ic_dialog_close_dark);
            }
        }

        void OnModalToolbarNavigationClick(object sender, Toolbar.NavigationClickEventArgs e)
        {
            if (Element.CurrentPage is IModalPage modalPage)
                modalPage.Dismiss();
            else
                Element.SendBackButtonPressed();
        }
    }
}
