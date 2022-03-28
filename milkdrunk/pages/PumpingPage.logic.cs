using milkdrunk.pagemodel;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class PumpingPage : ContentPage
    {
        PumpingPageModel _vm;

        public PumpingPage()
        {
            BindingContext = _vm = new PumpingPageModel();
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
