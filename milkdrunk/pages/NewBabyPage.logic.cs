using milkdrunk.pagemodels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace milkdrunk.pages
{
    partial class NewBabyPage : ContentPage
    {
        NewBabyPageModel _pm;

        public NewBabyPage()
        {
            On<iOS>().SetUseSafeArea(true);
            BindingContext = _pm = new NewBabyPageModel();
            Build();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _pm.OnAppearingAsync();
            Title = _pm.Title;
        }
    }
}

