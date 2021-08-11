using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class EmptyViewDataTemplateSelectorPage : ContentPage
    {
        public EmptyViewDataTemplateSelectorPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
