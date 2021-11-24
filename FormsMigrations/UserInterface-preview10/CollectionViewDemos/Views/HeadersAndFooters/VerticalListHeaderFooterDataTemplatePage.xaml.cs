using CollectionViewDemos.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListHeaderFooterDataTemplatePage : ContentPage
    {
        public VerticalListHeaderFooterDataTemplatePage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
