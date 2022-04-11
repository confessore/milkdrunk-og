using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class MyFeedingsPage : ContentPage
    {
        MyFeedingsPageModel _pm;

        public MyFeedingsPage()
        {
            BindingContext = _pm = new MyFeedingsPageModel();
            ToolbarItems.Add(NewFeedingToolbarItem());
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
