using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class EmptyViewTemplatePage : ContentPage
    {
        public EmptyViewTemplatePage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
