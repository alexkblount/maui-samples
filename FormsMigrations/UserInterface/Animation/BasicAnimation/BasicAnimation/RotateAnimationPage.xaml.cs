﻿using System;
using Microsoft.Maui; using Microsoft.Maui.Controls;

namespace BasicAnimation
{
	public partial class RotateAnimationPage : ContentPage
	{
		public RotateAnimationPage ()
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

			await image.RotateTo (360, 2000);
			image.Rotation = 0;

			SetIsEnabledButtonState (true, false);
		}

		void OnCancelAnimationButtonClicked (object sender, EventArgs e)
		{
			Microsoft.Maui.Controls.ViewExtensions.CancelAnimations (image);
			SetIsEnabledButtonState (true, false);
		}
	}
}

