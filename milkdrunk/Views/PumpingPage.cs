using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class PumpingPage
    {
        void Build()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label() { Text = "pumping" },
                    new TimePicker(),
                    new Label() { Text = "comments" },
                    new Entry()

                }
            };
        }
    }
}