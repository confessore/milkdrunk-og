using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class ChangingDetailPage : ContentPage
    {
        ChangingDetailPageModel _pm;

        public ChangingDetailPage()
        {
            BindingContext = _pm = new ChangingDetailPageModel();
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
