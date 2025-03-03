﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Styles
{
	public class ApplicationStylesPageCS : ContentPage
	{
		public ApplicationStylesPageCS ()
		{
			Title = "Application";
			IconImageSource = "csharp.png";
			Padding = new Thickness (0, 20, 0, 0);

			Content = new StackLayout {
				Children = {
					new Button { Text = "These buttons", Style = (Style)Application.Current.Resources ["buttonStyle"] },
					new Button { Text = "are demonstrating", Style = (Style)Application.Current.Resources ["buttonStyle"] },
					new Button { Text = "application styles", Style = (Style)Application.Current.Resources ["buttonStyle"]
					}
				}
			};
		}
	}
}
