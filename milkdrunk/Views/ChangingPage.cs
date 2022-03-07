using System;

using Xamarin.Forms;

namespace milkdrunk.Views
{
    public class ChangingPage : ContentPage
    {
        public ChangingPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

