using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
    public partial class MonkeyDetailPage : ContentPage
    {
        public MonkeyDetailPage()
        {
            InitializeComponent();
            BindingContext = new MonkeyDetailViewModel();
        }
    }
}