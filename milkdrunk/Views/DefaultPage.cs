using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class DefaultPage
    {
        Task BuildAsync()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label() { Text = "loading..." }
                }
            };
            return Task.CompletedTask;
        }
    }
}
