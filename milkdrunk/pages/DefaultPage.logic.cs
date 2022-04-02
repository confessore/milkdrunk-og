using milkdrunk.pagemodels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace milkdrunk.pages
{
    partial class DefaultPage : ContentPage
    {
        DefaultPageModel _pm;

        public DefaultPage()
        {
            On<iOS>().SetUseSafeArea(true);
            BindingContext = _pm = new DefaultPageModel();
            Build();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _pm.OnAppearingAsync();
        }
    }
}
