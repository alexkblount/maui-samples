﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace PlatformSpecifics
{
    public partial class iOSTitleViewNavigationPage : NavigationPage
    {
        public iOSTitleViewNavigationPage(Page page)
        {
            InitializeComponent();
            PushAsync(page);
        }
    }
}
