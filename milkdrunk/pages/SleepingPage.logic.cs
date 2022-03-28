using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class SleepingPage : ContentPage
    {
        SleepingViewModel _pm;

        public SleepingPage()
        {
            BindingContext = _pm = new SleepingViewModel();
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

