using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListVariableSizeItemsPage : ContentPage
    {
        public VerticalListVariableSizeItemsPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
