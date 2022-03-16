﻿using milkdrunk.resources;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class NewSleepingPage
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
                    new Label() { Text = "new sleeping" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .CenterHorizontal(),
                    new Label() { Text = "start" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new DatePicker()
                        .Margins(5, 5, 5, 5),
                    new TimePicker()
                        .Margins(5, 5, 5, 5),
                    new Label() { Text = "log end now?"}
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new CheckBox()
                        .Margins(5, 5, 5, 5)
                        .Bind(CheckBox.IsCheckedProperty, nameof(_vm.IsChecked)),
                    new Label() { Text = "end" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new DatePicker()
                        .Margins(5, 5, 5, 5)
                        .Bind(DatePicker.IsEnabledProperty, nameof(_vm.IsChecked)),
                    new TimePicker()
                        .Margins(5, 5, 5, 5)
                        .Bind(DatePicker.IsEnabledProperty, nameof(_vm.IsChecked)),
                    new Button() { Text = AppResources.button_confirm }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                        //.Bind(Button.CommandProperty, nameof(_vm.MyBabiesCommand)),
                }
            };
        }
    }
}
