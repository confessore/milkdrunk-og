using milkdrunk.pagemodels;
using Xamarin.Forms;

namespace milkdrunk.pages
{
    partial class MyPumpingsPage : ContentPage
    {
        MyPumpingsPageModel _pm;

        public MyPumpingsPage()
        {
            BindingContext = _pm = new MyPumpingsPageModel();
            ToolbarItems.Add(NewPumpingToolbarItem());
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
