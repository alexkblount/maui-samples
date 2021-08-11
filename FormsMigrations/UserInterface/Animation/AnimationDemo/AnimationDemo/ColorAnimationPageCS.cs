using System;
using System.Threading.Tasks;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace AnimationDemo
{
	public class ColorAnimationPageCS : ContentPage
	{
		Label label;
		BoxView boxView;
		Button cancelButton;

		public ColorAnimationPageCS()
		{
			Title = "Color Animations";
			IconImageSource = "csharp.png";

			boxView = new BoxView { Color = Colors.Blue, HeightRequest = 100, HorizontalOptions = LayoutOptions.FillAndExpand };
			label = new Label
			{
				Text = "Loreom ipsum dolar sit amet",
				FontSize = 24,
				FontAttributes = FontAttributes.Bold,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			var animateBoxViewButton = new Button
			{
				Text = "Animate BoxView",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			animateBoxViewButton.Clicked += OnAnimateBoxViewButtonClicked;

			var animateLabelButton = new Button
			{
				Text = "Animate Label",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			animateLabelButton.Clicked += OnAnimateLabelButtonClicked;

			var animatePageBackgroundButton = new Button
			{
				Text = "Animate Page Background",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			animatePageBackgroundButton.Clicked += OnAnimatePageBackgroundButtonClicked;

			cancelButton = new Button { Text = "Cancel Animation", IsEnabled = false };
			cancelButton.Clicked += OnCancelAnimationButtonClicked;

			Content = new StackLayout
			{
				Margin = new Thickness(10, 20, 10, 20),
				Children = {
					boxView,
					animateBoxViewButton,
					label,
					animateLabelButton,
					animatePageBackgroundButton,
					cancelButton
				}
			};
		}

		void SetIsEnabledCancelButtonState(bool cancelButtonState)
		{
			cancelButton.IsEnabled = cancelButtonState;
		}

		async void OnAnimateLabelButtonClicked(object sender, EventArgs e)
		{
			SetIsEnabledCancelButtonState(true);

			await Task.WhenAll(
				label.ColorTo(Colors.Red, Colors.Blue, c => label.TextColor = c, 5000),
				label.ColorTo(Colors.Blue, Colors.Red, c => label.BackgroundColor = c, 5000));

			label.BackgroundColor = Colors.Transparent;
			label.TextColor = Colors.Black;
		}

		async void OnAnimatePageBackgroundButtonClicked(object sender, EventArgs e)
		{
			SetIsEnabledCancelButtonState(true);

			await this.ColorTo(Color.FromRgb(0, 0, 0), Color.FromRgb(255, 255, 255), c => BackgroundColor = c, 5000);
			BackgroundColor = Colors.Transparent;
		}

		async void OnAnimateBoxViewButtonClicked(object sender, EventArgs e)
		{
			SetIsEnabledCancelButtonState(true);

			await boxView.ColorTo(Colors.Blue, Colors.Red, c => boxView.Color = c, 4000);
		}

		void OnCancelAnimationButtonClicked(object sender, EventArgs e)
		{
			boxView.CancelAnimation();
			label.CancelAnimation();
			this.CancelAnimation();

			SetIsEnabledCancelButtonState(false);
		}
	}
}
