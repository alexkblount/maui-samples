using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListGroupingVariableSizeItemsPage : ContentPage
    {
        public VerticalListGroupingVariableSizeItemsPage()
        {
            InitializeComponent();
            BindingContext = new GroupedAnimalsViewModel();
        }
    }
}
