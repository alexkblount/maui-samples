using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListEmptyGroupsPage : ContentPage
    {
        public VerticalListEmptyGroupsPage()
        {
            InitializeComponent();
            BindingContext = new GroupedAnimalsViewModel(true);
        }
    }
}
