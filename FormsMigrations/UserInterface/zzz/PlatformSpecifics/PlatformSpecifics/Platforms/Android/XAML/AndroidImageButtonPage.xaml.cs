using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace PlatformSpecifics
{
    public partial class AndroidImageButtonPage : ContentPage
    {
        public AndroidImageButtonPage()
        {
            InitializeComponent();
        }

        void OnImageButtonClicked(object sender, EventArgs e)
        {
            var imageButton = sender as Xamarin.Forms.ImageButton;
            imageButton.On<Android>().SetIsShadowEnabled(!imageButton.On<Android>().GetIsShadowEnabled());
        }
    }
}

