using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListPullToRefreshPage : ContentPage
    {
        public VerticalListPullToRefreshPage()
        {
            InitializeComponent();
            BindingContext = new AnimalsViewModel();
        }
    }
}
