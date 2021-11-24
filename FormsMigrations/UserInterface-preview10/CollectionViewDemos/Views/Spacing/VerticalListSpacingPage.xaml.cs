using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListSpacingPage : ContentPage
    {
        public VerticalListSpacingPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
