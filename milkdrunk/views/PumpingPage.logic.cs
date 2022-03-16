using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
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
            base.OnAppearing();
            await _vm.OnAppearingAsync();
            Title = _vm.Title;
        }
    }
}
