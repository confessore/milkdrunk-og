using milkdrunk.views;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class NewBabyPage
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
                            new Label() { Text = "new baby" }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .CenterHorizontal()
                        }
                    },
                    new StackLayout()
                    {
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        Children =
                        {
                            new Entry() { Placeholder = "name" }
                                .Margins(5, 5, 5, 5)
                                .Bind(Entry.TextProperty, nameof(_pm.Name)),
                            new Label() { Text = "birthday" },
                            new DatePicker()
                                .Margins(5, 5, 5, 5)
                                .Bind(DatePicker.DateProperty, nameof(_pm.BirthDate)),
                            new Button() { Text = "confirm" }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .Bind(Button.CommandProperty, nameof(_pm.ConfirmCommand))
                        }
                    },
                    new StackLayout()
                    {
                        VerticalOptions = LayoutOptions.End,
                        Children =
                        {
                            new AdView()
                                .Height(60)
                        }
                    }
                }
            };
        }
    }
}
