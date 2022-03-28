using milkdrunk.extensions;
using milkdrunk.models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.pagemodels
{
    class MyChangingsPageModel : BasePageModel
    {
        public MyChangingsPageModel()
        {
            NewChangingCommand = new Command(NewChanging);
        }

        ObservableCollection<Changing>? changings;
        public ObservableCollection<Changing>? Changings
        {
            get => changings;
            set
            {
                changings = value;
                OnPropertyChanged();
            }
        }

        public async void OnChangingSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            IsBusy = true;
            //new ChangingDetailPage(SelectedChanging ?? new Changing())
            //await Shell.Current.Navigation.PushAsync();
            IsBusy = false;
        }

        public Command? NewChangingCommand { get; }

        async void NewChanging()
        {
            IsBusy = true;
            //await Shell.Current.Navigation.PushAsync(new NewChangingPage());
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
                    if (baby.Changings == null)
                        Changings = new ObservableCollection<Changing>();
                    else
                        Changings = baby.Changings.ToObservableCollection();
                }
            }
            IsBusy = false;
        }
    }
}
