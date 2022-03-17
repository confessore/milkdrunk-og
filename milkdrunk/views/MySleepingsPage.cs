using milkdrunk.models;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class MySleepingsPage
    {
        void Build()
        {
            Content = DefaultStackLayout();
        }

        ToolbarItem NewBabyToolbarItem()
        {
            return new ToolbarItem()
            {
                Text = "new sleeping"
            };
            //.Bind(ToolbarItem.CommandProperty, nameof(_vm.NewSleepingCommand));
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
                            new Label() { Text = "my sleepings" }
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
                                //.Bind(CollectionView.SelectedItemProperty, nameof(_vm.SelectedSleeping))
                                //.Bind(CollectionView.ItemsSourceProperty, nameof(_vm.Sleepings))
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
            //collectionView.SelectionChanged += _vm.OnSleepingSelectionChanged;
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
                        .Bind(Label.TextProperty, nameof(Sleeping.Start)),
                        new Label()
                        .Bind(Label.TextProperty, nameof(Sleeping.End))
                    }
                });
        }
    }
}
