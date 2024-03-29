﻿using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class SleepingPage : ContentPage
    {
        SleepingPageModel _pm;

        public SleepingPage()
        {
            BindingContext = _pm = new SleepingPageModel();
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

