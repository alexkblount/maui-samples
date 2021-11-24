using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class HorizontalListSpacingPage : ContentPage
    {
        public HorizontalListSpacingPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
