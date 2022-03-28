using milkdrunk.views;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class BabyDetailPage
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
                            new Label() { Text = "baby detail" }
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
                            new Label()
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .CenterHorizontal()
                                .Bind(Label.TextProperty, nameof(_pm.Name)),
                           new Label()
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .CenterHorizontal()
                                .Bind(Label.TextProperty, nameof(_pm.BirthDate)),
                            new Button() { Text = "edit baby" }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .Bind(Button.CommandProperty, nameof(_pm.EditBabyCommand)),
                            new Button() { Text = "set default baby" }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .Bind(Button.CommandProperty, nameof(_pm.SetDefaultBabyCommand))
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
