using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListRTLPage : ContentPage
    {
        public VerticalListRTLPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
