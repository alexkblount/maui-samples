using SearchBarDemos.Services;
using System;
using System.Windows.Input;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace SearchBarDemos
{
    public partial class SearchBarXamlPage : ContentPage
    {
        public SearchBarXamlPage()
        {
            InitializeComponent();
            searchResults.ItemsSource = DataService.Fruits;
        }

        void OnSearchButtonPressed(object sender, EventArgs e)
        {
            searchResults.ItemsSource = DataService.GetSearchResults(searchBar.Text);
        }
    }
}