﻿using System;
using Microsoft.Maui; using Microsoft.Maui.Controls;

namespace BasicAnimation
{
	public partial class FadeAnimationPage : ContentPage
	{
		public FadeAnimationPage ()
		{
			InitializeComponent ();
		}

		void SetIsEnabledButtonState (bool startButtonState, bool cancelButtonState)
		{
			startButton.IsEnabled = startButtonState;
			cancelButton.IsEnabled = cancelButtonState;
		}

		async void OnStartAnimationButtonClicked (object sender, EventArgs e)
		{
			SetIsEnabledButtonState (false, true);

			image.Opacity = 0;
			await image.FadeTo (1, 4000);

			SetIsEnabledButtonState (true, false);
		}

		void OnCancelAnimationButtonClicked (object sender, EventArgs e)
		{
			Microsoft.Maui.Controls.ViewExtensions.CancelAnimations (image);
			SetIsEnabledButtonState (true, false);
		}
	}
}

