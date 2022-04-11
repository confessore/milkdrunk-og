using milkdrunk.models;
using milkdrunk.resources;
using milkdrunk.views;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class MyFeedingsPage
    {
        void Build()
        {
            Content = DefaultStackLayout();
        }

        ToolbarItem NewFeedingToolbarItem()
        {
            return new ToolbarItem()
            {
                Text = AppResources.add_new
            }
            .Bind(ToolbarItem.CommandProperty, nameof(_pm.NewFeedingCommand));
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
                            new Label() { Text = "feedings" }
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
                                //.Bind(CollectionView.SelectedItemProperty, nameof(_vm.SelectedFeeding))
                                .Bind(CollectionView.ItemsSourceProperty, nameof(_pm.Feedings))
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
            //collectionView.SelectionChanged += _vm.OnFeedingSelectionChanged;
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
                            .Bind(Label.TextProperty, nameof(Feeding.Time)),
                        new Label()
                            .Bind(Label.TextProperty, nameof(Feeding.FeedingType))
                    }
                });
        }
    }
}
