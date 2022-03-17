using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class MySleepingsViewModel : BaseViewModel
    {
        public async void OnBabySelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            IsBusy = true;
            //new SleepingDetailPage(SelectedSleeping ?? new Sleeping())
            //await Shell.Current.Navigation.PushAsync();
            IsBusy = false;
        }
    }
}
