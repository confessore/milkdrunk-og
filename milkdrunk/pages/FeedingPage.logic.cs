using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class FeedingPage : ContentPage
    {
        FeedingPageModel _pm;

        public FeedingPage()
        {
            BindingContext = _pm = new FeedingPageModel();
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