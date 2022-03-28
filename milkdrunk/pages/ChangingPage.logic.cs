using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class ChangingPage : ContentPage
    {
        ChangingPageModel _pm;

        public ChangingPage()
        {
            BindingContext = _pm = new ChangingPageModel();
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

