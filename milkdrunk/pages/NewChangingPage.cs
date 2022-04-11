using milkdrunk.models.enums;
using milkdrunk.resources;
using milkdrunk.views;
using System;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class NewChangingPage
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
                            new Label() { Text = "new changing" }
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
                            new Label() { Text = "diaper status" }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5),
                            new Picker()
                                .Bind(Picker.ItemsSourceProperty, nameof(_pm.ChangingTypes)),
                            new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    new DatePicker()
                                        .Margins(5, 5, 5, 5)
                                        .Bind(DatePicker.DateProperty, nameof(_pm.Date)),
                                    new TimePicker()
                                        .Margins(5, 5, 5, 5)
                                        .Bind(TimePicker.TimeProperty, nameof(_pm.Time))
                                }
                            },
                            new Button() { Text = AppResources.button_confirm }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .Bind(Button.CommandProperty, nameof(_pm.AddNewChangingCommand))
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
