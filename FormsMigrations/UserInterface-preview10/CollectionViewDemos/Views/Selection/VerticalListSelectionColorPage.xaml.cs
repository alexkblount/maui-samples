using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListSelectionColorPage : ContentPage
    {
        public VerticalListSelectionColorPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
