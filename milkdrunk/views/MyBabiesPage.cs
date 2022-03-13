using milkdrunk.models;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class MyBabiesPage
    {
        void Build()
        {
            Content = DefaultStackLayout();
        }

        ToolbarItem NewBabyToolbarItem()
        {
            return new ToolbarItem()
            {
                Text = "new baby"
            }
            .Bind(ToolbarItem.CommandProperty, nameof(_vm.NewBabyCommand));
        }

        StackLayout DefaultStackLayout()
        {
            return new StackLayout()
            {
                Children =
                {
                    new CollectionView()
                    {
                        ItemTemplate = new DataTemplate(() =>
                            new StackLayout()
                            {
                                Children =
                                {
                                    new Label()
                                    .Bind(Label.TextProperty, nameof(Baby.Name)),
                                    new Label()
                                    .Bind(Label.TextProperty, nameof(Baby.BirthDate))
                                }
                            })
                    }
                    .Bind(CollectionView.ItemsSourceProperty, nameof(_vm.Babies))
                }
            };
        }
    }
}
