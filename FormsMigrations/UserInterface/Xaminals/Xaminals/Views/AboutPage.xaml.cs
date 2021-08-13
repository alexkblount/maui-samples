using System.Windows.Input;
using Microsoft.Maui.Essentials;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Xaminals.Views
{
    public partial class AboutPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public AboutPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
