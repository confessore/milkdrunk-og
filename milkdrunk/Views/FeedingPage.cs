using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class FeedingPage
    {
        void Build()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "feeding" }
                        .CenterHorizontal()
                }
            };
        }
    }
}
