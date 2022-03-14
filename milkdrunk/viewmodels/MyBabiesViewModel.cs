using milkdrunk.extensions;
using milkdrunk.models;
using milkdrunk.views;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class MyBabiesViewModel : BaseViewModel
    {
        public MyBabiesViewModel()
        {
            NewBabyCommand = new Command(NewBaby);
        }

        ObservableCollection<Baby>? babies;
        public ObservableCollection<Baby>? Babies
        {
            get => babies;
            set
            {
                babies = value;
                OnPropertyChanged();
            }
        }

        Baby? selectedBaby;
        public Baby? SelectedBaby
        {
            get => selectedBaby;
            set
            {
                selectedBaby = value;
                OnPropertyChanged();
            }
        }

        public Command? NewBabyCommand { get; }

        async void NewBaby()
        {
            IsBusy = true;
            await Shell.Current.Navigation.PushAsync(new NewBabyPage());
            IsBusy = false;
        }

        public async void OnBabySelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            IsBusy = true;
            await Shell.Current.Navigation.PushAsync(new BabyDetailPage());
            IsBusy = false;
        }

        public override async Task OnAppearingAsync()
        {
            await base.OnAppearingAsync();
            IsBusy = true;
            if (Caregiver != null)
            {
                if (Caregiver.Babies != null)
                    Babies = Caregiver.Babies.ToObservableCollection();
            }
            IsBusy = false;
        }
    }
}
