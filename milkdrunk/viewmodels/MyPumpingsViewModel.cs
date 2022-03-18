using milkdrunk.models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class MyPumpingsViewModel : BaseViewModel
    {
        public MyPumpingsViewModel()
        {
            NewPumpingCommand = new Command(NewPumping);
        }

        ObservableCollection<Pumping>? sleepings;
        public ObservableCollection<Pumping>? Pumpings
        {
            get => sleepings;
            set
            {
                sleepings = value;
                OnPropertyChanged();
            }
        }

        public async void OnPumpingSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            IsBusy = true;
            //new PumpingDetailPage(SelectedPumping ?? new Pumping())
            //await Shell.Current.Navigation.PushAsync();
            IsBusy = false;
        }

        public Command? NewPumpingCommand { get; }

        async void NewPumping()
        {
            IsBusy = true;
            //await Shell.Current.Navigation.PushAsync(new NewPumpingPage());
            IsBusy = false;
        }

        public override async Task OnAppearingAsync()
        {
            await base.OnAppearingAsync();
            IsBusy = true;

            IsBusy = false;
        }
    }
}
