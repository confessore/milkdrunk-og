using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class MySleepingsPage : ContentPage
    {
        MySleepingsPageModel _pm;

        public MySleepingsPage()
        {
            BindingContext = _pm = new MySleepingsPageModel();
            ToolbarItems.Add(NewSleepingToolbarItem());
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
