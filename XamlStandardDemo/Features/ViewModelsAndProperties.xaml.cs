using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamlStandardDemo.ViewModels;

namespace XamlStandardDemo.Features
{
    public partial class ViewModelsAndProperties : ContentPage
    {
        public ViewModelsAndProperties()
        {
            InitializeComponent();
            BindingContext = new TestViewModel();
        }
    }
}
