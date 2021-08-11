using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListHeaderFooterStringPage : ContentPage
    {
        public VerticalListHeaderFooterStringPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
