﻿using milkdrunk.ViewModels;
using Xamarin.Forms;

namespace milkdrunk.Views
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
            await _vm.OnAppearingAsync();
            base.OnAppearing();
        }
    }
}

