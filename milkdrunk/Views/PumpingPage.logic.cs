using milkdrunk.ViewModels;
using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class PumpingPage : ContentPage
    {
        PumpingViewModel _vm;

        public PumpingPage()
        {
            BindingContext = _vm = new PumpingViewModel();
            Build();
        }

        protected override async void OnAppearing()
        {
            await _vm.OnAppearingAsync();
            base.OnAppearing();
        }
    }
}
