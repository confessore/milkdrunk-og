using milkdrunk.viewmodels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace milkdrunk.views
{
    public partial class NewBabyPage : ContentPage
    {
        NewBabyViewModel _vm;

        public NewBabyPage()
        {
            On<iOS>().SetUseSafeArea(true);
            BindingContext = _vm = new NewBabyViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _vm.OnAppearingAsync();
            Build();
        }
    }
}

