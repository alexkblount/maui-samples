using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace LayoutOptionsDemo
{
	public class LayoutOptionsPageCS : TabbedPage
	{
		public LayoutOptionsPageCS()
		{
			Children.Add(new LayoutOptionsAlignmentPageCS());
			Children.Add(new LayoutOptionsExpansionPageCS());
		}
	}
}

