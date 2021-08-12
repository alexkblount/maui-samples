using System;

using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace ToolbarItemDemos
{
    public partial class ToolbarItemXaml : ContentPage
    {
        public ToolbarItemXaml()
        {
            InitializeComponent();
        }

        void OnItemClicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            messageLabel.Text = $"You clicked the \"{item.Text}\" toolbar item.";
        }
    }
}