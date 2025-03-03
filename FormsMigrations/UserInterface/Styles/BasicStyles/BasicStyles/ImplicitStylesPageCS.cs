﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace Styles
{
	public class ImplicitStylesPageCS : ContentPage
	{
		public ImplicitStylesPageCS ()
		{
			var entryStyle = new Style (typeof(Entry)) {
				Setters = {
					new Setter {
						Property = View.HorizontalOptionsProperty,
						Value = LayoutOptions.Fill
					},
					new Setter {
						Property = View.VerticalOptionsProperty,
						Value = LayoutOptions.CenterAndExpand
					},
					new Setter {
						Property = VisualElement.BackgroundColorProperty,
						Value = Colors.Yellow
					},
					new Setter {
						Property = Entry.FontAttributesProperty,
						Value = FontAttributes.Italic
					},
					new Setter {
						Property = Entry.TextColorProperty,
						Value = Colors.Blue
					}
				}
			};

			Title = "Implicit";
			IconImageSource = "csharp.png";
			Padding = new Thickness (0, 20, 0, 0);
			Resources = new ResourceDictionary ();
			Resources.Add (entryStyle);

			Content = new StackLayout {
				Children = {
					new Entry { Text = "These entries" },
					new Entry { Text = "are demonstrating" },
					new Entry { Text = "implicit styles," },
					new Entry { Text = "and an implicit style override", BackgroundColor = Colors.Lime, TextColor = Colors.Red },
					new CustomEntry  { Text = "Subclassed Entry is not receiving the style" }
				}
			};
		}
	}
}
