using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListMultiplePreSelectionPage : ContentPage
    {
        public VerticalListMultiplePreSelectionPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
