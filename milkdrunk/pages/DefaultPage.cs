using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class DefaultPage
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
