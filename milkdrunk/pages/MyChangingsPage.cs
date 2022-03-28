using milkdrunk.models;
using milkdrunk.views;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class MyChangingsPage
    {
        void Build()
        {
            Content = DefaultStackLayout();
        }

        ToolbarItem NewChangingToolbarItem()
        {
            return new ToolbarItem()
            {
                Text = "new changing"
            }
            .Bind(ToolbarItem.CommandProperty, nameof(_pm.NewChangingCommand));
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
                            new Label() { Text = "my changings" }
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
                                //.Bind(CollectionView.SelectedItemProperty, nameof(_vm.SelectedChanging))
                                .Bind(CollectionView.ItemsSourceProperty, nameof(_pm.Changings))
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
            //collectionView.SelectionChanged += _vm.OnChangingSelectionChanged;
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
                        .Bind(Label.TextProperty, nameof(Changing.Time)),
                        new Label()
                        .Bind(Label.TextProperty, nameof(Changing.ChangingType))
                    }
                });
        }
    }
}
