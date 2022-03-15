using System;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class NewSleepingPage
    {
        void Build()
        {
            Content = DefaultStackLayout();
        }

        StackLayout DefaultStackLayout()
        {
            return new StackLayout()
            {
                Children = {
                    new Button() { Text = "add new sleep" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                        //.Bind(Button.CommandProperty, nameof(_vm.MyBabiesCommand)),
                }
            };
        }
    }
}
