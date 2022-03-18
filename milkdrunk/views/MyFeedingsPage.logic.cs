using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class MyFeedingsPage : ContentPage
    {
        MyFeedingsViewModel _vm;

        public MyFeedingsPage()
        {
            BindingContext = _vm = new MyFeedingsViewModel();
            ToolbarItems.Add(NewFeedingToolbarItem());
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
