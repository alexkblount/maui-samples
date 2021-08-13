using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Styles
{
	public class HomePageCS : TabbedPage
	{
		public HomePageCS ()
		{
			Children.Add (new DynamicStylesPageCS ());
			Children.Add (new DynamicStylesInheritancePageCS ());
			Children.Add (new DeviceStylesPageCS ());
		}
	}
}


