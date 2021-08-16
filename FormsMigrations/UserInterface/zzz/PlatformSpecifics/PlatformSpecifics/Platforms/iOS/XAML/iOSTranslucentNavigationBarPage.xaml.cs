using System;
using System.Windows.Input;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public partial class iOSTranslucentNavigationBarPage : ContentPage
    {
        ICommand _returnToPlatformSpecificsPage;

        public iOSTranslucentNavigationBarPage(ICommand restore)
        {
            InitializeComponent();
            _returnToPlatformSpecificsPage = restore;
        }

        void OnTranslucentNavigationBarButtonClicked(object sender, EventArgs e)
        {
            (Xamarin.Forms.Application.Current.MainPage as Xamarin.Forms.NavigationPage).On<iOS>().SetIsNavigationBarTranslucent(!(Xamarin.Forms.Application.Current.MainPage as Xamarin.Forms.NavigationPage).On<iOS>().IsNavigationBarTranslucent());
        }

        void OnReturnButtonClicked(object sender, EventArgs e)
        {
            _returnToPlatformSpecificsPage.Execute(null);
        }
    }
}
