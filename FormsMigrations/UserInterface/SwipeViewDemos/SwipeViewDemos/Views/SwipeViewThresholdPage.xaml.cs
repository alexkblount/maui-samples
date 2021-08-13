using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace SwipeViewDemos
{
    public partial class SwipeViewThresholdPage : ContentPage
    {
        public SwipeViewThresholdPage()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            swipeView.Close();
        }
    }
}
