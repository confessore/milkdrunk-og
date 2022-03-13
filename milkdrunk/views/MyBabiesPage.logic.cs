using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class MyBabiesPage : ContentPage
    {
        MyBabiesViewModel _vm;

        public MyBabiesPage()
        {
            BindingContext = _vm = new MyBabiesViewModel();
            ToolbarItems.Add(NewBabyToolbarItem());
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _vm.OnAppearingAsync();
            Build();
        }
    }
}
