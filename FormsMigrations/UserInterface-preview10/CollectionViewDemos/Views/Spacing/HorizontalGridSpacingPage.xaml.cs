using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class HorizontalGridSpacingPage : ContentPage
    {
        public HorizontalGridSpacingPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
