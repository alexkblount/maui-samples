using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Converters;

namespace BindablePicker
{
	public class SimpleColorPickerPageViewModel : ViewModelBase
	{
		ColorTypeConverter colorTypeConverter = new ColorTypeConverter();

		public IList<string> ColorNames
		{
			get
			{
				return typeof(Color).GetRuntimeFields()
									.Where(f => f.IsPublic && f.IsStatic)
									.Select(f => f.Name).ToList();
			}
		}

		string selectedColorName;
		public string SelectedColorName
		{
			get { return selectedColorName; }
			set
			{
				if (selectedColorName != value)
				{
					selectedColorName = value;
					OnPropertyChanged();
					OnPropertyChanged("SelectedColor");
				}
			}
		}

		public Color SelectedColor
		{
			get
			{
				if (string.IsNullOrWhiteSpace(selectedColorName))
				{
					return Colors.Transparent;
				}
				return (Color)colorTypeConverter.ConvertFromInvariantString(selectedColorName);
			}
		}
	}
}
