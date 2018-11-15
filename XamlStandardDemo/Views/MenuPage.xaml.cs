using XamlStandardDemo.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlStandardDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Invitation, Title="Home Page" },
                new HomeMenuItem {Id = MenuItemType.XAMLStandard, Title="XAML Standard" },
                new HomeMenuItem {Id = MenuItemType.MarkupExtensions, Title="Markup Extensions" },
                new HomeMenuItem {Id = MenuItemType.TriggersAndBehaviors, Title="Triggers and Behaviors" },
                new HomeMenuItem {Id = MenuItemType.VisualStateManager, Title="VisualStateManager" },
                new HomeMenuItem {Id = MenuItemType.ViewModelAndProperties, Title="ViewModelAndProperties" },
                new HomeMenuItem {Id = MenuItemType.ResourceDictionaries, Title="Resource Dictionary" },
                new HomeMenuItem {Id = MenuItemType.CompileBinding, Title="Compile Bindings" },
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}