using milkdrunk.views;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class SleepingViewModel : BaseViewModel
    {
        public SleepingViewModel()
        {
            NewSleepingCommand = new Command(NewSleeping);
            MySleepingsCommand = new Command(MySleepings);
        }

        public Command? NewSleepingCommand { get; }

        async void NewSleeping()
        {
            IsBusy = true;
            await Shell.Current.Navigation.PushAsync(new NewSleepingPage());
            IsBusy = false;
        }

        public Command? MySleepingsCommand { get; }

        async void MySleepings()
        {
            IsBusy = true;
            await Shell.Current.Navigation.PushAsync(new MySleepingsPage());
            IsBusy = false;
        }
    }
}
