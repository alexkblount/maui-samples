using SearchBarDemos.Services;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace SearchBarDemos
{
    public partial class SearchBarRealtimeXamlPage : ContentPage
    {
        public SearchBarRealtimeXamlPage()
        {
            InitializeComponent();

            searchResults.ItemsSource = DataService.GetSearchResults(searchBar.Text);
        }

        void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            searchResults.ItemsSource = DataService.GetSearchResults(e.NewTextValue);
        }
    }
}