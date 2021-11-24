using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalGridSpacingPage : ContentPage
    {
        public VerticalGridSpacingPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
