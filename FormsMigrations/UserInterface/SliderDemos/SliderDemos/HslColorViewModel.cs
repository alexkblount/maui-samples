using System;
using System.ComponentModel;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace SliderDemos
{
    public class HslColorViewModel : INotifyPropertyChanged
    {
        Color color;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Hue
        {
            set
            {
                if (color.GetHue() != value)
                {
                    Color = Color.FromHsla(value, color.GetSaturation(), color.GetLuminosity());
                }
            }
            get 
            {
                return color.GetHue();
            }
        }

        public double Saturation
        {
            set
            {
                if (color.GetSaturation() != value)
                {
                    Color = Color.FromHsla(color.GetHue(), value, color.GetLuminosity());
                }
            }
            get
            {
                return color.GetSaturation();
            }
        }

        public double Luminosity
        {
            set
            {
                if (color.GetLuminosity() != value)
                {
                    Color = Color.FromHsla(color.GetHue(), color.GetSaturation(), value);
                }
            }
            get
            {
                return color.GetLuminosity();
            }
        }

        public Color Color
        {
            set
            {
                if (color != value)
                {
                    color = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Saturation"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Luminosity"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Color"));
                }
            }
            get
            {
                return color;
            }
        }
    }
}
