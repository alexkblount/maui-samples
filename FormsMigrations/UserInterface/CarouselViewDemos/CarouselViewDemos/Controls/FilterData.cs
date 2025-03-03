﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CarouselViewDemos.Controls
{
    public class FilterData : BindableObject
    {
        public static readonly BindableProperty FilterProperty = BindableProperty.Create(nameof(Filter), typeof(string), typeof(FilterData), null);

        public string Filter
        {
            get { return (string)GetValue(FilterProperty); }
            set { SetValue(FilterProperty, value); }
        }
    }
}
