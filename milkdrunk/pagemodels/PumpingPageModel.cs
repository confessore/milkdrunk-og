using milkdrunk.pagemodels;
using milkdrunk.views;
using Xamarin.Forms;

namespace milkdrunk.pagemodel
{
    class PumpingPageModel : BasePageModel
    {
        public PumpingPageModel()
        {
            MyPumpingsCommand = new Command(MyPumpings);
        }

        public Command? MyPumpingsCommand { get; }

        async void MyPumpings()
        {
            IsBusy = true;
            await Shell.Current.Navigation.PushAsync(new MyPumpingsPage());
            IsBusy = false;
        }
    }
}
