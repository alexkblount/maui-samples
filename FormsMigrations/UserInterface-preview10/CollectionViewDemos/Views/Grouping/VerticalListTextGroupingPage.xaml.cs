using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListTextGroupingPage : ContentPage
    {
        public VerticalListTextGroupingPage()
        {
            InitializeComponent();
            BindingContext = new GroupedAnimalsViewModel();
        }
    }
}
