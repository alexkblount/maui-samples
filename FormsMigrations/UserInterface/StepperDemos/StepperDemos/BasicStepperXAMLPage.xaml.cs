using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace StepperDemo
{
    public partial class BasicStepperXAMLPage : ContentPage
    {
        public BasicStepperXAMLPage()
        {
            InitializeComponent();
        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            _rotatingLabel.Rotation = value;
            _displayLabel.Text = string.Format("The Stepper value is {0}", value);
        }
    }
}
