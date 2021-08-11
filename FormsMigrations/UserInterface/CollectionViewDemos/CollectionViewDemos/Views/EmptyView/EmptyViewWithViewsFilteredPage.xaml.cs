using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class EmptyViewWithViewsFilteredPage : ContentPage
    {
        public EmptyViewWithViewsFilteredPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
