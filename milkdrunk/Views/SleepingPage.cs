using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.Views
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
