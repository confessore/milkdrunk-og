using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class NewSleepingPage : ContentPage
    {
        NewSleepingPageModel _pm;

        public NewSleepingPage()
        {
            BindingContext = _pm = new NewSleepingPageModel();
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
