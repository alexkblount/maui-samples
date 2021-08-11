﻿using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace ButtonDemos
{
	public partial class BasicButtonClickPage : ContentPage
	{
		public BasicButtonClickPage ()
		{
			InitializeComponent ();
		}

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await label.RelRotateTo(360, 1000);
        }
    }
}