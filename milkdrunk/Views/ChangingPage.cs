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
                    new Label
                    {
                        Text = "changing"
                    }.CenterHorizontal()
                    ,

                }
            };
        }
    }
}
