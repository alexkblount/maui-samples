using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformSpecifics
{
    public partial class iOSShadowEffectPage : ContentPage
    {
        public iOSShadowEffectPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            _boxView.On<iOS>().SetIsShadowEnabled(!_boxView.On<iOS>().GetIsShadowEnabled());
        }
    }
}
