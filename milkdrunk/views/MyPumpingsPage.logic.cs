using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class MyPumpingsPage : ContentPage
    {
        MyPumpingsViewModel _vm;

        public MyPumpingsPage()
        {
            BindingContext = _vm = new MyPumpingsViewModel();
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
