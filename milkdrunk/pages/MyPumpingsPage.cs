using milkdrunk.models;
using milkdrunk.views;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class MyPumpingsPage
    {
        void Build()
        {
            Content = DefaultStackLayout();
        }

        ToolbarItem NewPumpingToolbarItem()
        {
            return new ToolbarItem()
            {
                Text = "new pumping"
            }
            .Bind(ToolbarItem.CommandProperty, nameof(_pm.NewPumpingCommand));
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
                            new Label() { Text = "my pumpings" }
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
                            DefaultCollectionView()
                                //.Bind(CollectionView.SelectedItemProperty, nameof(_vm.SelectedPumping))
                                .Bind(CollectionView.ItemsSourceProperty, nameof(_pm.Pumpings))
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

        CollectionView DefaultCollectionView()
        {
            var collectionView = new CollectionView()
            {
                SelectionMode = SelectionMode.Single,
                ItemTemplate = DefaultDataTemplate()
            };
            //collectionView.SelectionChanged += _vm.OnPumpingSelectionChanged;
            return collectionView;
        }

        DataTemplate DefaultDataTemplate()
        {
            return new DataTemplate(() =>
                new StackLayout()
                {
                    Children =
                    {
                        new Label()
                            .Bind(Label.TextProperty, nameof(Pumping.Time)),
                        new Label()
                            .Bind(Label.TextProperty, nameof(Pumping.FluidOunces))
                    }
                });
        }
    }
}
