using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListSwipeContextItemsPage : ContentPage
    {
        public VerticalListSwipeContextItemsPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();            
        }
    }
}
