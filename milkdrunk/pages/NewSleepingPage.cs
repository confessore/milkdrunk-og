using milkdrunk.resources;
using milkdrunk.views;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class NewSleepingPage
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
                            new Label() { Text = "new sleeping" }
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
                            new Label() { Text = "start" }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5),
                            new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    new DatePicker()
                                        .Margins(5, 5, 5, 5)
                                        .Bind(DatePicker.DateProperty, nameof(_pm.StartDate)),
                                    new TimePicker()
                                        .Margins(5, 5, 5, 5)
                                        .Bind(TimePicker.TimeProperty, nameof(_pm.StartTime))
                                }
                            },
                            new Label() { Text = "log end now?"}
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5),
                            new CheckBox()
                                .Margins(5, 5, 5, 5)
                                .Bind(CheckBox.IsCheckedProperty, nameof(_pm.IsChecked)),
                            new Label() { Text = "end" }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .Bind(Label.IsVisibleProperty, nameof(_pm.IsChecked)),
                            new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    new DatePicker()
                                        .Margins(5, 5, 5, 5)
                                        .Bind(DatePicker.DateProperty, nameof(_pm.EndDate))
                                        .Bind(DatePicker.IsVisibleProperty, nameof(_pm.IsChecked)),
                                    new TimePicker()
                                        .Margins(5, 5, 5, 5)
                                        .Bind(TimePicker.TimeProperty, nameof(_pm.EndTime))
                                        .Bind(TimePicker.IsVisibleProperty, nameof(_pm.IsChecked))
                                }
                            },
                            new Button() { Text = AppResources.button_confirm }
                                .Margins(5, 5, 5, 5)
                                .Paddings(5, 5, 5, 5)
                                .Bind(Button.CommandProperty, nameof(_pm.AddNewSleepingCommand))
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
