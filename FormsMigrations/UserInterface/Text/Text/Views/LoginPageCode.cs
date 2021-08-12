﻿using System;

using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace TextSample
{
	public class LoginPageCode : ContentPage
	{
		public LoginPageCode ()
		{
			Title = "Login Page - Code";
			var grid = new Grid { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand };
			grid.RowDefinitions.Add (new RowDefinition { Height = new GridLength (50) });
			grid.RowDefinitions.Add (new RowDefinition { Height = new GridLength (50) });
			grid.RowDefinitions.Add (new RowDefinition { Height = new GridLength (50) });
			grid.ColumnDefinitions.Add (new ColumnDefinition { Width = new GridLength (80) });
			grid.ColumnDefinitions.Add (new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) });
			grid.Children.Add (new Label {
				Text = "Username",
				FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
				FontAttributes = FontAttributes.Bold,
				VerticalOptions = LayoutOptions.Center
			});//, 0, 0);
			grid.Children.Add (new Label {
				Text = "Password",
				FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
				FontAttributes = FontAttributes.Bold,
				VerticalOptions = LayoutOptions.Center
			});//, 0, 1);
			grid.Children.Add (new Entry ());//, 1, 0);
			grid.Children.Add (new Entry { IsPassword = true });//, 1, 1);
			grid.Children.Add (new Button { Text = "Log In", TextColor = Colors.White, BackgroundColor = Colors.Gray });//, 1, 2);
			var layout = new StackLayout{ Padding = new Thickness (10, 0) };
			layout.Children.Add (new Label {
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center,
				Text = "Traditional Login Form"
			});
			layout.Children.Add(new Frame { Content = grid });
			layout.Children.Add (new Label {
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center,
				Text = "Modern Login Form"
			});

			var modernLayout = new StackLayout ();
			modernLayout.Children.Add (new Entry { Placeholder = "Username", HorizontalOptions = LayoutOptions.Fill });
			modernLayout.Children.Add (new Entry { IsPassword = true, Placeholder = "Password", HorizontalOptions = LayoutOptions.Fill });
			modernLayout.Children.Add (new Button {
				Text = "Log In",
				TextColor = Colors.White,
				BackgroundColor = Colors.Gray,
				HorizontalOptions = LayoutOptions.Fill
			});
			layout.Children.Add (new Frame { Content = modernLayout });
			this.Content = layout;
		}
	}
}


