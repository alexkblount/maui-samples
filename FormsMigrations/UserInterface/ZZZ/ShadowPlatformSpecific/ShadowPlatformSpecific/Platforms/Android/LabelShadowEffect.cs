using MyCompany.Forms.PlatformConfiguration.Android;
using ShadowPlatformSpecific.Droid;
using System;
using System.ComponentModel;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Controls.Internals;
using AndroidX.AppCompat.Widget;
using Microsoft.Maui.Controls.Compatibility.Platform.Android.FastRenderers;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using AColor = Android.Graphics.Color;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(LabelShadowEffect), "LabelShadowEffect")]
namespace ShadowPlatformSpecific.Droid
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
					float radius = 5;
					float distanceX = 5;
					float distanceY = 5;
					AColor color = AColor.Black;
					(Control as Android.Widget.TextView).SetShadowLayer(radius, distanceX, distanceY, color);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
			}
		}
	}
}
