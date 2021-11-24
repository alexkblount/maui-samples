using Microsoft.Maui;
using System;
using CarouselViewDemos.Controls;
using Microsoft.Maui.Controls;

namespace CarouselViewDemos.Views
{
    public partial class ItemsUpdatingScrollModePage : ContentPage
    {
        public ItemsUpdatingScrollModePage()
        {
            InitializeComponent();
        }

        void OnItemsUpdatingScrollModeChanged(object sender, EventArgs e)
        {
            carouselView.ItemsUpdatingScrollMode = (ItemsUpdatingScrollMode)(sender as EnumPicker).SelectedItem;
        }
    }
}
