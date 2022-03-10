using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class WelcomePage : ContentPage
    {
        WelcomeViewModel _vm;

        public WelcomePage()
        {
            BindingContext = _vm = new WelcomeViewModel();
            Build();
        }
    }
}
