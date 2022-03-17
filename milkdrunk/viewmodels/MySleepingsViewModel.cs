using milkdrunk.extensions;
using milkdrunk.models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class MySleepingsViewModel : BaseViewModel
    {
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

        public async void OnBabySelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            IsBusy = true;
            //new SleepingDetailPage(SelectedSleeping ?? new Sleeping())
            //await Shell.Current.Navigation.PushAsync();
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
