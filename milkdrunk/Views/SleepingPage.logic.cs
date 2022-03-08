using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class SleepingPage : ContentPage
    {
        void Build()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "sleeping" }
                }
            };
        }
    }
}
