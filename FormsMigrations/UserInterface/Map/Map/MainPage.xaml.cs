using System;
using System.Windows.Input;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;
using Microsoft.Maui.Graphics;

namespace Map
{
	public partial class MainPage : ContentPage
	{
		public ICommand NavigateCommand { get; set; }

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
	}
}
