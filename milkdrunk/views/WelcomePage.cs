using milkdrunk.resources;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class WelcomePage
    {
        void Build()
        {
            Content = new StackLayout
            {
                Children = {
                    new Image() { Source = "milkdrunk120.png" }
                        .Margins(5, 5, 5, 5)
                        .CenterHorizontal(),
                    new Label() { Text = AppResources.welcome }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .CenterHorizontal(),
                    new Label() { Text = "some additional information is required to proceed"}
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .CenterHorizontal(),
                    new Label() { Text = "we do not sell your private information" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .CenterHorizontal(),
                    new Label() { Text = "caregiver name" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new Entry()
                        .Margins(5, 5, 5, 5),
                        //.Bind(Entry.TextProperty, nameof(_vm.Name)),
                    new Label() { Text = "birthday" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new DatePicker()
                        .Margins(5, 5, 5, 5),
                        //.Bind(DatePicker.DateProperty, nameof(_vm.Baby.BirthDate)),
                    new Button() { Text = "confirm" }
                        .Margins(5, 1, 5, 1)
                        .Paddings(5, 1, 5, 1)
                        //.Bind(Button.CommandProperty, nameof(_vm.ConfirmCommand))
                }
            };
        }
    }
}
