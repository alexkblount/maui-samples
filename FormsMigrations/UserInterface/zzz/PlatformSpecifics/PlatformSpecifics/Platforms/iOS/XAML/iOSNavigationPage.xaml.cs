using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace PlatformSpecifics
{
    public partial class iOSNavigationPage : NavigationPage
    {
        public iOSNavigationPage(Page page)
        {
            InitializeComponent();
            PushAsync(page);
        }
    }
}
