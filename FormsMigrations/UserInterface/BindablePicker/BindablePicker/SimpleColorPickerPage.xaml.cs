using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace BindablePicker
{
	public partial class SimpleColorPickerPage : ContentPage
	{
		public SimpleColorPickerPage()
		{
			InitializeComponent();
			BindingContext = new SimpleColorPickerPageViewModel();
		}
	}
}
