using milkdrunk.viewmodels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace milkdrunk.views
{
    public partial class WelcomePage : ContentPage
    {
        WelcomeViewModel _vm;

        public WelcomePage()
        {
            On<iOS>().SetUseSafeArea(true);
            BindingContext = _vm = new WelcomeViewModel();
            Build();
        }
    }
}
