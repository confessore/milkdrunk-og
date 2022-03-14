using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class BabyDetailPage : ContentPage
    {
        BabyDetailViewModel _vm;

        public BabyDetailPage()
        {
            BindingContext = _vm = new BabyDetailViewModel();
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
