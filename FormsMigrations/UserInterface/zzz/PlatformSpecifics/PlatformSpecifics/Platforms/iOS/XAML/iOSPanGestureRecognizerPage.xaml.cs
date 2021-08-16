using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public partial class iOSPanGestureRecognizerPage : ContentPage
    {
        public iOSPanGestureRecognizerPage()
        {
            InitializeComponent();
            BindingContext = new ListViewViewModel();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.On<iOS>().SetPanGestureRecognizerShouldRecognizeSimultaneously(
                !Xamarin.Forms.Application.Current.On<iOS>().GetPanGestureRecognizerShouldRecognizeSimultaneously());
        }

        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            _messageLabel.Text = $"panned x:{e.TotalX} y:{e.TotalY}";
        }
    }
}
