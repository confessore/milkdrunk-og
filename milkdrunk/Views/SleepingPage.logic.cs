using milkdrunk.ViewModels;
using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class SleepingPage : ContentPage
    {
        SleepingViewModel _vm;

        public SleepingPage()
        {
            BindingContext = _vm = new SleepingViewModel();
            Build();
        }
    }
}

