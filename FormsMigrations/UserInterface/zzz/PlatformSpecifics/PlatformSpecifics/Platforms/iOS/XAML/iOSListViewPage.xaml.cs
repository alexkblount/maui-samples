using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace PlatformSpecifics
{
    public partial class iOSListViewPage : ContentPage
    {
        public iOSListViewPage()
        {
            InitializeComponent();
			BindingContext = new ListViewViewModel();
        }
    }
}
