﻿using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace PlatformSpecifics
{
    public partial class iOSModalPagePresentationStyle : ContentPage
    {
        public iOSModalPagePresentationStyle()
        {
            InitializeComponent();
        }

        async void OnReturnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
