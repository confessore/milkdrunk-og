using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class MyPumpingsPage : ContentPage
    {
        MyPumpingsPageModel _vm;

        public MyPumpingsPage()
        {
            BindingContext = _vm = new MyPumpingsPageModel();
            ToolbarItems.Add(NewPumpingToolbarItem());
            Build();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _vm.OnAppearingAsync();
            Title = _vm.Title;
        }
    }
}
