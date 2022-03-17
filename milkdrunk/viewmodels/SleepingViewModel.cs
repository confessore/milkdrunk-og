using milkdrunk.views;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class SleepingViewModel : BaseViewModel
    {
        public SleepingViewModel()
        {
            MySleepingsCommand = new Command(MySleepings);
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
