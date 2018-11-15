using System;
using Xamarin.Forms;
using static Xamarin.Forms.PlatformConfiguration.iOSSpecific.VisualElement;

namespace XamlStandardDemo.Helpers
{
    public class ShadowEffect
    {
        public static readonly BindableProperty HasShadowProperty = BindableProperty.CreateAttached("HasShadow", typeof(bool), typeof(ShadowEffect), false);


        public static bool GetHasShadow(BindableObject view)
        {
            return (bool)view.GetValue(HasShadowProperty);
        }

        public static void SetHasShadow(BindableObject view, bool value)
        {
            view.SetValue(HasShadowProperty, value);
        }



    }
}
