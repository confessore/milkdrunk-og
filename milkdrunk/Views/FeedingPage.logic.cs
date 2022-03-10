using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class FeedingPage : ContentPage
    {
        FeedingViewModel _vm;

        public FeedingPage()
        {
            BindingContext = _vm = new FeedingViewModel();
            Build();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _vm.OnAppearingAsync();
        }
    }
}