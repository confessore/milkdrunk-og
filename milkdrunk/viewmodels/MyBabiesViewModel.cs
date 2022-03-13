using milkdrunk.extensions;
using milkdrunk.models;
using milkdrunk.views;
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

        public Command? NewBabyCommand { get; }

        async void NewBaby()
        {
            IsBusy = true;
                await Shell.Current.Navigation.PushAsync(new NewBabyPage());
            IsBusy = false;
        }

        public override async Task OnAppearingAsync()
        {
            await base.OnAppearingAsync();
            var babies = await _babyContext.FindAllAsync();
            Babies = babies.ToObservableCollection();
        }
    }
}
