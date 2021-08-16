using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace PlatformSpecifics
{
    public partial class AndroidViewCellPage : ContentPage
    {
        public AndroidViewCellPage()
        {
            InitializeComponent();
            BindingContext = new AndroidViewCellPageViewModel();
        }
    }
}
