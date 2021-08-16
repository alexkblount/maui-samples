﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace PlatformSpecifics
{
    public partial class AndroidNavigationPage : NavigationPage
    {
        public AndroidNavigationPage(Page page)
        {
            InitializeComponent();
            PushAsync(page);
        }
    }
}