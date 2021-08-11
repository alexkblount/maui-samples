using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class HorizontalGridPullToRefreshPage : ContentPage
    {
        public HorizontalGridPullToRefreshPage()
        {
            InitializeComponent();
            BindingContext = new AnimalsViewModel();
        }
    }
}
