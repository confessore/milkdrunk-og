using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class HomePage
    {
        void Build()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label() { Text = $"welcome, {_vm.Caregiver!.Name}" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .CenterHorizontal(),
                    new Button() { Text = "view caregroups" }
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
