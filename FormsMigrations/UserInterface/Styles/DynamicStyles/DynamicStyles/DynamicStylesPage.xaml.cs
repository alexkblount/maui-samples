﻿using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Styles
{
	public partial class DynamicStylesPage : ContentPage
	{
		bool originalStyle = true;

		public DynamicStylesPage ()
		{
			InitializeComponent ();
			Resources ["searchBarStyle"] = Resources ["blueSearchBarStyle"];
		}

		void OnButtonClicked (object sender, EventArgs e)
		{
			if (originalStyle) {
				Resources ["searchBarStyle"] = Resources ["greenSearchBarStyle"];
				originalStyle = false;
			} else {
				Resources ["searchBarStyle"] = Resources ["blueSearchBarStyle"];
				originalStyle = true;
			}
		}
	}
}

