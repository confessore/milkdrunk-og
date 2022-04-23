using milkdrunk.models;
using milkdrunk.resources;
using milkdrunk.views;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class MyBabiesPage
    {
        void Build()
        {
            Content = DefaultStackLayout();
        }

        ToolbarItem NewBabyToolbarItem()
        {
            return new ToolbarItem()
            {
                Text = AppResources.add_new
            }
            .Bind(ToolbarItem.CommandProperty, nameof(_pm.NewBabyCommand));
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
                            new Label() { Text = "babies" }
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
                                .Bind(CollectionView.SelectedItemProperty, nameof(_pm.SelectedBaby))
                                .Bind(CollectionView.ItemsSourceProperty, nameof(_pm.Babies))
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
            collectionView.SelectionChanged += _pm.OnBabySelectionChanged;
            return collectionView;
        }

        DataTemplate DefaultDataTemplate()
        {
            return new DataTemplate(() =>
                new Frame()
                {
                    BorderColor = (Color)(App.Current.Resources["Primary"] ?? Color.Red),
                    Content =
                        new StackLayout()
                        {
                            Children =
                            {
                                new Label()
                                    .Margins(5, 5, 5, 5)
                                    .Paddings(5, 5, 5, 5)
                                    .Bind(Label.TextProperty, nameof(Baby.Name)),
                                new Label()
                                    .Margins(5, 5, 5, 5)
                                    .Paddings(5, 5, 5, 5)
                                    .Bind(Label.TextProperty, nameof(Baby.BirthDate))
                            }
                        }
                });
        }
    }
}
