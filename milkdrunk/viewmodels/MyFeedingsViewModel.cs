using milkdrunk.extensions;
using milkdrunk.models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class MyFeedingsViewModel : BaseViewModel
    {
        public MyFeedingsViewModel()
        {
            NewFeedingCommand = new Command(NewFeeding);
        }

        ObservableCollection<Feeding>? feedings;
        public ObservableCollection<Feeding>? Feedings
        {
            get => feedings;
            set
            {
                feedings = value;
                OnPropertyChanged();
            }
        }

        public async void OnFeedingSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            IsBusy = true;
            //new FeedingDetailPage(SelectedFeeding ?? new Feeding())
            //await Shell.Current.Navigation.PushAsync();
            IsBusy = false;
        }

        public Command? NewFeedingCommand { get; }

        async void NewFeeding()
        {
            IsBusy = true;
            //await Shell.Current.Navigation.PushAsync(new NewFeedingPage());
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
                    if (baby.Feedings == null)
                        Feedings = new ObservableCollection<Feeding>();
                    else
                        Feedings = baby.Feedings.ToObservableCollection();
                }
            }
            IsBusy = false;
        }
    }
}
