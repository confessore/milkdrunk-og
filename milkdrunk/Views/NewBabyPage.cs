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
                        .Margins(5, 1, 5, 1),
                    new Label() { Text = "birthday" },
                    new DatePicker()
                        .Margins(5, 1, 5, 1),
                    new Button() { Text = "confirm" }
                        .Margins(5, 1, 5, 1)
                        .Paddings(5, 1, 5, 1)
                        .BindTapGesture(nameof(_vm.ConfirmCommand))
                }
            };
        }
    }
}
