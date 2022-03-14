using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class HomePage : ContentPage
    {
        HomeViewModel _vm;

        public HomePage()
        {
            BindingContext = _vm = new HomeViewModel();
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
