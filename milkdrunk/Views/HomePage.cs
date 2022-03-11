using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class HomePage
    {
        void Build()
        {
            if (_vm.Caregroup == null)
                Content = CaregroupStackLayout();
            else
                Content = DefaultStackLayout();
        }

        StackLayout DefaultStackLayout()
        {
            return new StackLayout()
            {
                Children = {
                    new Label() { Text = $"welcome, {_vm.Caregiver!.Name}" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .CenterHorizontal(),
                    new Button() { Text = "caregroup" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5),
                    new Button() { Text = "caregiver settings" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                }
            };
        }

        StackLayout CaregroupStackLayout()
        {
            return new StackLayout()
            {
                Children = {
                    new Label() { Text = $"welcome, {_vm.Caregiver!.Name}" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .CenterHorizontal(),
                    new Button() { Text = "create a caregroup" }
                        .Margins(5, 5, 5, 5)
                        .Paddings(5, 5, 5, 5)
                        .Bind(Button.CommandProperty, nameof(_vm.CreateCaregroupCommand)),
                    new Button() { Text = "join a caregroup" }
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
