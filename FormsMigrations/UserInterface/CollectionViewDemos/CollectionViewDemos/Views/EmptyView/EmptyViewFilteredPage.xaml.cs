using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class EmptyViewFilteredPage : ContentPage
    {
        public EmptyViewFilteredPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
