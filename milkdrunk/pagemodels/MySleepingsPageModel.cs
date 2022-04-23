using milkdrunk.extensions;
using milkdrunk.models;
using milkdrunk.pages;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.pagemodels
{
    class MySleepingsPageModel : BasePageModel
    {
        public MySleepingsPageModel()
        {
            NewSleepingCommand = new Command(NewSleeping);
        }

        ObservableCollection<Sleeping>? sleepings;
        public ObservableCollection<Sleeping>? Sleepings
        {
            get => sleepings;
            set
            {
                sleepings = value;
                OnPropertyChanged();
            }
        }

        public async void OnSleepingSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            IsBusy = true;
            //new SleepingDetailPage(SelectedSleeping ?? new Sleeping())
            //await Shell.Current.Navigation.PushAsync();
            IsBusy = false;
        }

        public Command? NewSleepingCommand { get; }

        async void NewSleeping()
        {
            IsBusy = true;
            await Shell.Current.Navigation.PushAsync(new NewSleepingPage());
            IsBusy = false;
        }

        public override async Task OnAppearingAsync()
        {
            await base.OnAppearingAsync();
            IsBusy = true;
            if (Caregiver != null)
            {
                var baby = Caregiver.Babies.FirstOrDefault(x => x.Id == Baby.Id);
                if (baby != null)
                {
                    if (baby.Sleepings == null)
                        Sleepings = new ObservableCollection<Sleeping>();
                    else
                        Sleepings = baby.Sleepings.ToObservableCollection();
                }
            }
            IsBusy = false;
        }
    }
}
