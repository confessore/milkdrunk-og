using milkdrunk.models;
using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class EditChangingPage : ContentPage
    {
        EditChangingPageModel _pm;

        public EditChangingPage(
            Changing changing)
        {
            BindingContext = _pm = new EditChangingPageModel(changing);
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
