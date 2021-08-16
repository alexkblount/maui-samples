﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace PlatformSpecifics
{
    public class ItemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate OneItemTemplate { get; set; }
        public DataTemplate TwoItemsTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((ContextMenuItem)item).Type == ContextMenuItemType.OneItem ? OneItemTemplate : TwoItemsTemplate;
        }
    }
}
