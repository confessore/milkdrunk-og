using milkdrunk.resources;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
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
                    new Label() { Text = "new sleeping" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .CenterHorizontal(),
                    new Button() { Text = "start stopwatch" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new Button() { Text = "end stopwatch" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new Label() { Text = "hours" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new Entry()
                        .Margins(5, 5, 5, 5),
                    new Label() { Text = "minutes" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new Entry()
                        .Margins(5, 5, 5, 5),
                    new Label() { Text = "seconds" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new Entry()
                        .Margins(5, 5, 5, 5),
                    new Button() { Text = AppResources.button_confirm }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                        //.Bind(Button.CommandProperty, nameof(_vm.MyBabiesCommand)),
                }
            };
        }
    }
}
