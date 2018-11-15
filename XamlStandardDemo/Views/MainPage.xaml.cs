using XamlStandardDemo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamlStandardDemo.Features;

namespace XamlStandardDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Invitation, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Invitation:
                        MenuPages.Add(id, new NavigationPage(new InvitationPage()));
                        break;
                    case (int)MenuItemType.XAMLStandard:
                        MenuPages.Add(id, new NavigationPage(new XamlStandard()));
                        break;
                    case (int)MenuItemType.MarkupExtensions:
                        MenuPages.Add(id, new NavigationPage(new MarkupExtensions()));
                        break;
                    case (int)MenuItemType.TriggersAndBehaviors:
                        MenuPages.Add(id, new NavigationPage(new TriggersAndBehaviors()));
                        break;
                    case (int)MenuItemType.VisualStateManager:
                        MenuPages.Add(id, new NavigationPage(new VisualStateManagerPage()));
                        break;
                    case (int)MenuItemType.ViewModelAndProperties:
                        MenuPages.Add(id, new NavigationPage(new ViewModelsAndProperties()));
                        break;
                    case (int)MenuItemType.ResourceDictionaries:
                        MenuPages.Add(id, new NavigationPage(new ResourceDictionaries()));
                        break;
                    case (int)MenuItemType.CompileBinding:
                        MenuPages.Add(id, new NavigationPage(new CompileBindingPage()));
                        break;

                }

                var newPage = MenuPages[id];

                if (newPage != null && Detail != newPage)
                {
                    Detail = newPage;

                    if (Device.RuntimePlatform == Device.Android)
                        await Task.Delay(100);

                    IsPresented = false;
                }
            }
        }
    }
}