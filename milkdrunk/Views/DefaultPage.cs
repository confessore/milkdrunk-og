using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class DefaultPage
    {
        void Build()
        {
            Content = new StackLayout
            {
                Children = {
                    new Button() { Text = "add a new baby" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new Button() { Text = "switch babies" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new Label() { Text = "name" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new Entry()
                        .Margins(5, 5, 5, 5)
                        .Bind(Entry.TextProperty, nameof(_vm.Name)),
                    new Label() { Text = "birthday" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new DatePicker()
                        .Margins(5, 5, 5, 5)
                        .Bind(DatePicker.DateProperty, nameof(_vm.Baby.BirthDate)),
                    new Button() { Text = "confirm" }
                        .Margins(5, 1, 5, 1)
                        .Paddings(5, 1, 5, 1)
                        //.Bind(Button.CommandProperty, nameof(_vm.ConfirmCommand))
                }
            };
        }
    }
}
