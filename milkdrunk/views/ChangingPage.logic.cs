﻿using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class ChangingPage : ContentPage
    {
        ChangingViewModel _vm;

        public ChangingPage()
        {
            BindingContext = _vm = new ChangingViewModel();
            Build();
        }

        protected override async void OnAppearing()
        {
            await _vm.OnAppearingAsync();
            base.OnAppearing();
            Title = _vm.Title;
        }
    }
}
