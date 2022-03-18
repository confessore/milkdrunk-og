using milkdrunk.views;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class PumpingViewModel : BaseViewModel
    {
        public PumpingViewModel()
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
