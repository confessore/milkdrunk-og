using milkdrunk.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace milkdrunk.Views
{
    public partial class NewBabyPage : ContentPage
    {
        NewBabyViewModel _vm;

        public NewBabyPage()
        {
            On<iOS>().SetUseSafeArea(true);
            BindingContext = _vm = new NewBabyViewModel();
            Build();
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await _vm.OnAppearingAsync();
        //}
    }
}

