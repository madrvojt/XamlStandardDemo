using System;
using System.Collections.Generic;
using System.Text;

namespace XamlStandardDemo.Models
{
    public enum MenuItemType
    {
        Invitation,
        XAMLStandard,
        MarkupExtensions,   
        TriggersAndBehaviors,
        VisualStateManager,
        ViewModelAndProperties,
        ResourceDictionaries,
        CompileBinding

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
