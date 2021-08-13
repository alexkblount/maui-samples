using CoreGraphics;
using MyCompany.Forms.PlatformConfiguration.iOS;
using ShadowPlatformSpecific.iOS;
using System;
using System.ComponentModel;
using UIKit;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Platform.iOS;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(LabelShadowEffect), "LabelShadowEffect")]
namespace ShadowPlatformSpecific.iOS
{
	public class LabelShadowEffect : PlatformEffect
	{
		protected override void OnAttached()
		{
			UpdateShadow();
		}

		protected override void OnDetached()
		{
		}

		protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
		{
			base.OnElementPropertyChanged(args);

			if (args.PropertyName == Shadow.IsShadowedProperty.PropertyName)
			{
				UpdateShadow();
			}
		}

		void UpdateShadow()
		{
			try
			{
				if (((Label)Element).OnThisPlatform().IsShadowed())
				{
					Control.Layer.CornerRadius = 5;
					Control.Layer.ShadowColor = UIColor.Black.CGColor;
					Control.Layer.ShadowOffset = new CGSize(5, 5);
					Control.Layer.ShadowOpacity = 1.0f;
				}
				else if (!((Label)Element).OnThisPlatform().IsShadowed())
				{
					Control.Layer.ShadowOpacity = 0;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
			}
		}
	}
}
