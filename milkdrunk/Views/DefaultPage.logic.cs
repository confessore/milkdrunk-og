using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class DefaultPage : ContentPage
    {
        DefaultViewModel _vm;

        public DefaultPage()
        {
            BindingContext = _vm = new DefaultViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _vm.OnAppearingAsync();
            await BuildAsync();
        }
    }
}
