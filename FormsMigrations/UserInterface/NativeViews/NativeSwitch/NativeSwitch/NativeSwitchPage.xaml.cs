using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace NativeSwitch
{
	public partial class NativeSwitchPage : ContentPage
	{
		public NativeSwitchPage()
		{
			InitializeComponent();
			BindingContext = new NativeSwitchPageViewModel();
		}
	}
}
