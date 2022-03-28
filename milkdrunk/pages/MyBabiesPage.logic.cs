using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class MyBabiesPage : ContentPage
    {
        MyBabiesPageModel _pm;

        public MyBabiesPage()
        {
            BindingContext = _pm = new MyBabiesPageModel();
            ToolbarItems.Add(NewBabyToolbarItem());
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
