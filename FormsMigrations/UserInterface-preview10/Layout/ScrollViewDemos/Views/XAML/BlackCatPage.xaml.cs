using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace ScrollViewDemos.Views
{
    public partial class BlackCatPage : ContentPage
    {
        public BlackCatPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            await scrollView.ScrollToAsync(finalLabel, ScrollToPosition.End, true);
        }

        void OnScrollViewScrolled(object sender, ScrolledEventArgs e)
        {
            Console.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");
        }
    }
}
