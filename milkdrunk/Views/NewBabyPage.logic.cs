using milkdrunk.ViewModels;
using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class NewBabyPage : ContentPage
    {
        NewBabyViewModel _vm;

        public NewBabyPage()
        {
            BindingContext = _vm = new NewBabyViewModel();
            Build();
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await _vm.OnAppearingAsync();
        //}
    }
}

