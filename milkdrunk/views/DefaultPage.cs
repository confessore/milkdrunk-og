using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class DefaultPage
    {
        void Build()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label() { Text = "loading..." }
                }
            };
        }
    }
}
