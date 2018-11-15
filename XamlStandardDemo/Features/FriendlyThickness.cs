using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlStandardDemo.Features
{

    [ContentProperty("FriendlyName")]
    public class FriendlyThickness : IMarkupExtension
    {
        public string FriendlyName { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            switch (FriendlyName?.ToLower())
            {
                case "fatleft":
                    return new Thickness(50, 0, 0, 0);
                case "fatright":
                    return new Thickness(0, 0, 50, 0);
                case "skinnytop":
                    return new Thickness(0, 10, 0, 0);
                case "skinnybottom":
                    return new Thickness(0, 0, 0, 10);
                default:
                    return new Thickness();
            }
        }
    }
}
