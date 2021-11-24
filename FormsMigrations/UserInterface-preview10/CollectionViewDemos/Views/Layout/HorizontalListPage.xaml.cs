using Microsoft.Maui;
using Microsoft.Maui.Controls;
using CollectionViewDemos.ViewModels;

namespace CollectionViewDemos.Views
{
    public partial class HorizontalListPage : ContentPage
    {
        public HorizontalListPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
