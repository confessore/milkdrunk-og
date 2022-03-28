using milkdrunk.models;
using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class BabyDetailPage : ContentPage
    {
        BabyDetailPageModel _pm;

        public BabyDetailPage(
            Baby baby)
        {
            BindingContext = _pm = new BabyDetailPageModel(baby);
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
