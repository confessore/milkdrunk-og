using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class PumpingPage : ContentPage
    {
        void Build()
        {
            Content = new StackLayout
            {
                Children = {
                    new TimePicker(),
                    new Label() { Text = "comments" },
                    new Entry()
                    
                }
            };
        }
    }
}
