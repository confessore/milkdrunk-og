using milkdrunk.ViewModels;

namespace milkdrunk.Views
{
    public partial class FeedingPage
    {
        FeedingViewModel _vm;

        public FeedingPage()
        {
            BindingContext = _vm = new FeedingViewModel();
            Build();
        }

        protected override async void OnAppearing()
        {
            await _vm.OnAppearingAsync();
            base.OnAppearing();
        }
    }
}