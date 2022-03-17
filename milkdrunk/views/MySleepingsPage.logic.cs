using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class MySleepingsPage : ContentPage
    {
        MySleepingsViewModel _vm;

        public MySleepingsPage()
        {
            BindingContext = _vm = new MySleepingsViewModel();
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
