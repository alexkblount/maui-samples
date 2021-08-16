using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace SubclassedNativeControls
{
	public partial class SubclassedNativeControlsPage : ContentPage
	{
		public SubclassedNativeControlsPage()
		{
			InitializeComponent();
			BindingContext = new SubclassedNativeControlsPageViewModel();
		}
	}
}
