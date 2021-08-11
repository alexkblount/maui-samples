using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListHeaderFooterViewPage : ContentPage
    {
        public VerticalListHeaderFooterViewPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
