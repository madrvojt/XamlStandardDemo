using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamlStandardDemo.Features
{
    public partial class XamlStandard : ContentPage
    {
        public XamlStandard()
        {
            InitializeComponent();


        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            UITextBlock.Text = "XAML STANDARD 1.0";
        }
    }
}
