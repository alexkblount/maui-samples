﻿using System;
using Microsoft.Maui; using Microsoft.Maui.Controls;

namespace BasicAnimation
{
	public class RelativeRotationPageCS : ContentPage
	{
		Image image;
		Button startButton, cancelButton;

		public RelativeRotationPageCS ()
		{
			Title = "Relative Rotate Animation";

			image = new Image { Source = ImageSource.FromFile ("monkey.png"), VerticalOptions = LayoutOptions.CenterAndExpand };
			startButton = new Button { Text = "Start Animation", VerticalOptions = LayoutOptions.End };
			cancelButton = new Button { Text = "Cancel Animation", IsEnabled = false };

			startButton.Clicked += OnStartAnimationButtonClicked;
			cancelButton.Clicked += OnCancelAnimationButtonClicked;

			Content = new StackLayout { 
				Margin = new Thickness (0, 20, 0, 0),
				Children = {
					image,
					startButton,
					cancelButton
				}
			};
		}

		void SetIsEnabledButtonState (bool startButtonState, bool cancelButtonState)
		{
			startButton.IsEnabled = startButtonState;
			cancelButton.IsEnabled = cancelButtonState;
		}

		async void OnStartAnimationButtonClicked (object sender, EventArgs e)
		{
			SetIsEnabledButtonState (false, true);
			await image.RelRotateTo (360, 2000);
			SetIsEnabledButtonState (true, false);
		}

		void OnCancelAnimationButtonClicked (object sender, EventArgs e)
		{
			Microsoft.Maui.Controls.ViewExtensions.CancelAnimations (image);
			SetIsEnabledButtonState (true, false);
		}
	}
}


