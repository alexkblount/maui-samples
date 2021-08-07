using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Controls;

namespace GridDemos.Views
{
    public partial class ColorSlidersGridPage : ContentPage
    {
        public ColorSlidersGridPage()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
		{
            boxView.Color = new Color((float)redSlider.Value, (float)greenSlider.Value, (float)blueSlider.Value);
		}
    }
}
