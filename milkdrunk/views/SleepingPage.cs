using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class SleepingPage
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
                    new Label() { Text = "sleeping" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .CenterHorizontal(),
                    new Button() { Text = "new sleeping" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .Bind(Button.CommandProperty, nameof(_vm.NewSleepingCommand)),
                    new Button() { Text = "my sleepings" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                }
            };
        }
    }
}
