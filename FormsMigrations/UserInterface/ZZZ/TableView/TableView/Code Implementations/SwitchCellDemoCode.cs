using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace TableViewSamples
{
	public class SwitchCellDemoCode : ContentPage
	{
		public SwitchCellDemoCode ()
		{
			this.Title = "SwitchCell";
			var table = new Microsoft.Maui.Controls.TableView ();
			var root = new TableRoot ();
			var section1 = new TableSection ();

			var switchOn = new SwitchCell { Text = "On", On = true };
			var switchOff = new SwitchCell { Text = "Off", On = false };

			section1.Add (switchOn); 
			section1.Add (switchOff);

			Content = table;
		}
	}
}


