﻿using System;
using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListDynamicSizeItemsPage : ContentPage
    {
        public VerticalListDynamicSizeItemsPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }

        void OnImageTapped(object sender, EventArgs e)
        {
            Image image = sender as Image;
            image.HeightRequest = image.WidthRequest = image.HeightRequest.Equals(60) ? 100 : 60;
        }
    }
}
