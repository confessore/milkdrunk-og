using milkdrunk.ViewModels;
using Xamarin.Forms;

namespace milkdrunk.Views
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
            base.OnAppearing();
            await _vm.OnAppearingAsync();
        }
    }
}

