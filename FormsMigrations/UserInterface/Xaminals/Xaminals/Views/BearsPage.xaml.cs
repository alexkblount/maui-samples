﻿using System.Linq;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Xaminals.Models;

namespace Xaminals.Views
{
    public partial class BearsPage : ContentPage
    {
        public BearsPage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string bearName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;
            // The following route works because route names are unique in this application.
            await Shell.Current.GoToAsync($"beardetails?name={bearName}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/bears/beardetails?name={bearName}");
        }
    }
}
