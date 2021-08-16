using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public partial class iOSSliderUpdateOnTapPage : ContentPage
    {
        public iOSSliderUpdateOnTapPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            _slider.On<iOS>().SetUpdateOnTap(!_slider.On<iOS>().GetUpdateOnTap());
        }
    }
}
