using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace MonkeyAppPicker
{
	public partial class MonkeysPage : ContentPage
	{
		public MonkeysPage()
		{
			InitializeComponent();
			BindingContext = new MonkeysPageViewModel();
		}
	}
}
