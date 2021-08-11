using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace CheckBoxDemos
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}
	}
}

namespace Microsoft.Maui.Controls
{
	public static class GridExtension
	{
		public static void Add(this Grid grid, View view, int column = 0, int row = 0, int columnspan = 1, int rowspan = 1)
		{
			if (row < 0)
			{
				throw new ArgumentOutOfRangeException("row");
			}
			if (column < 0)
			{
				throw new ArgumentOutOfRangeException("column");
			}
			if (rowspan <= 0)
			{
				throw new ArgumentOutOfRangeException("rowspan");
			}
			if (columnspan <= 0)
			{
				throw new ArgumentOutOfRangeException("columnspan");
			}
			if (view == null)
			{
				throw new ArgumentNullException("view");
			}

			Grid.SetRow(view, row);
			Grid.SetRowSpan(view, rowspan);
			Grid.SetColumn(view, column);
			Grid.SetColumnSpan(view, columnspan);
			grid.Add(view);
		}
	}
}
