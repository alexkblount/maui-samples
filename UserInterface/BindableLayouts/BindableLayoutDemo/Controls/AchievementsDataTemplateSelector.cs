using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace BindableLayoutDemo.Controls
{
    public class AchievementsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate OtherTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            bool result = (bool)item;
            return result ? OtherTemplate : DefaultTemplate;            
        }
    }
}
