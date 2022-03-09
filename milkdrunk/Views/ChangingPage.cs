using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class ChangingPage
    {
        void Build()
        {
            Content = new StackLayout
            {
                Children = {
                    new Button() { Text = "new" }
                        .Margins(0, 0, 5, 0)
                        .Paddings(0, 0, 5, 0)
                        .End(),
                    new CollectionView() { },
                    new Editor() { Placeholder = "comments" }
                        .FillExpand()
                }
            };
        }
    }
}
