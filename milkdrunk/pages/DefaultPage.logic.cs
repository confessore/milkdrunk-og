using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class DefaultPage : ContentPage
    {
        DefaultPageModel _pm;

        public DefaultPage()
        {
            BindingContext = _pm = new DefaultPageModel();
            Build();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _pm.OnAppearingAsync();
        }
    }
}
