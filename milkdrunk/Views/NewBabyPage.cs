using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class NewBabyPage
    {
        void Build()
        {
            Title = "new baby";
            Content = new StackLayout
            {
                Children = {
                    new Label() { Text = "let's add a new baby!" },
                    new Entry() { Placeholder = "name" }
                        .Margins(5, 5, 5, 5)
                        .Bind(Entry.TextProperty, nameof(_vm.Name)),
                    new Label() { Text = "birthday" },
                    new DatePicker()
                        .Margins(5, 5, 5, 5)
                        .Bind(DatePicker.DateProperty, nameof(_vm.BirthDate)),
                    new Button() { Text = "confirm" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .Bind(Button.CommandProperty, nameof(_vm.ConfirmCommand))
                }
            };
        }
    }
}
