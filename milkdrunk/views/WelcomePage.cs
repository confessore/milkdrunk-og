using milkdrunk.resources;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class WelcomePage
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
                    new StackLayout()
                    {
                        VerticalOptions = LayoutOptions.Start,
                        Children =
                        {
                            new Label() { Text = AppResources.welcome }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .CenterHorizontal(),
                        }
                    },
                    new StackLayout()
                    {
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        Children =
                        {
                            new Label() { Text = AppResources.information }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .CenterHorizontal(),
                            new Label() { Text = AppResources.caregiver_name }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5),
                            new Entry()
                                .Margins(5, 5, 5, 5)
                                .Bind(Entry.TextProperty, nameof(_vm.Name)),
                            new Button() { Text = AppResources.button_confirm }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .Bind(Button.CommandProperty, nameof(_vm.ConfirmCommand))
                        }
                    },
                    new StackLayout()
                    {
                        VerticalOptions = LayoutOptions.End,
                        Children =
                        {

                        }
                    }
                }
            };
        }
    }
}
