using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class HomePage
    {
        void Build()
        {
            if (_vm.Caregroup == null)
                Content = CaregroupStackLayout();
            else
                Content = DefaultStackLayout();
        }

        StackLayout DefaultStackLayout()
        {
            return new StackLayout()
            {
                Children = {
                    new Label() { Text = "home" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .CenterHorizontal(),
                    new Label()
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .CenterHorizontal()
                        .Bind(Label.TextProperty, nameof(_vm.Greeting)),
                    new Button() { Text = "my babies" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .Bind(Button.CommandProperty, nameof(_vm.MyBabiesCommand)),
                    new Button() { Text = "my caregroup", IsEnabled = false}
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new Button() { Text = "caregiver settings" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                }
            };
        }

        StackLayout CaregroupStackLayout()
        {
            return new StackLayout()
            {
                Children = {
                    new Label()
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .CenterHorizontal()
                        .Bind(Label.TextProperty, nameof(_vm.Greeting)),
                    new Button() { Text = "my babies" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .Bind(Button.CommandProperty, nameof(_vm.MyBabiesCommand)),
                    new Button() { Text = "create a caregroup", IsEnabled = false }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .Bind(Button.CommandProperty, nameof(_vm.CreateCaregroupCommand)),
                    new Button() { Text = "join a caregroup", IsEnabled = false }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new Button() { Text = "caregiver settings" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                }
            };
        }
    }
}
