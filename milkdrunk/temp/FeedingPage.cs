using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
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
