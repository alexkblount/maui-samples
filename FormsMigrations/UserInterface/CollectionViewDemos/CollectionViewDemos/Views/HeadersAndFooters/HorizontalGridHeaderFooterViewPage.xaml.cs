using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class HorizontalGridHeaderFooterViewPage : ContentPage
    {
        public HorizontalGridHeaderFooterViewPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
