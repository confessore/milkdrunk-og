using milkdrunk.pagemodels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace milkdrunk.pages
{
    partial class WelcomePage : ContentPage
    {
        WelcomePageModel _pm;

        public WelcomePage()
        {
            On<iOS>().SetUseSafeArea(true);
            BindingContext = _pm = new();
            Build();
        }
    }
}
