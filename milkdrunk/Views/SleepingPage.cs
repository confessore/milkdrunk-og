using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class SleepingPage
    {
        void Build()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label
                    {
                        Text = "sleeping"
                    }.CenterHorizontal()
                    ,

                }
            };
        }
    }
}
