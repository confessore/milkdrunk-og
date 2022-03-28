﻿using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class MyChangingsPage : ContentPage
    {
        MyChangingsPageModel _vm;

        public MyChangingsPage()
        {
            BindingContext = _vm = new MyChangingsPageModel();
            ToolbarItems.Add(NewChangingToolbarItem());
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
