﻿using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace AbsoluteLayoutDemos.Views
{
    public partial class ChessboardDemoPage : ContentPage
    {
        public ChessboardDemoPage()
        {
            InitializeComponent();
        }

        void OnContentViewSizeChanged(object sender, EventArgs e)
        {
            ContentView contentView = sender as ContentView;
            double boardSize = Math.Min(contentView.Width, contentView.Height);
            absoluteLayout.WidthRequest = boardSize;
            absoluteLayout.HeightRequest = boardSize;
        }
    }
}
