using System;
using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class NewSleepingPage : ContentPage
    {
        NewSleepingViewModel _vm;

        public NewSleepingPage()
        {
            BindingContext = _vm = new NewSleepingViewModel();
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
