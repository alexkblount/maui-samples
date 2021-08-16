using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace PlatformSpecifics
{
    public partial class iOSListViewWithCellPage : ContentPage
    {
        public iOSListViewWithCellPage()
        {
            InitializeComponent();
            BindingContext = new ListViewViewModel(20);
        }
    }
}
