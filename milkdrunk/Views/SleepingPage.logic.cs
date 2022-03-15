using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class SleepingPage : ContentPage
    {
        SleepingViewModel _vm;

        public SleepingPage()
        {
            BindingContext = _vm = new SleepingViewModel();
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

