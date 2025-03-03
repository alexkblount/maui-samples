﻿using System;
using System.Windows.Input;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace ButtonDemos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });

            BindingContext = this;
        }

        public ICommand NavigateCommand { private set; get; }
    }
}
