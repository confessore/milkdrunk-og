using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class HomePage : ContentPage
    {
        HomePageModel _pm;

        public HomePage()
        {
            BindingContext = _pm = new HomePageModel();
            Build();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _pm.OnAppearingAsync();
            Title = _pm.Title;
        }
    }
}
