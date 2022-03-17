using milkdrunk.models;
using milkdrunk.views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class ChangingViewModel : BaseViewModel
    {
        public ChangingViewModel()
        {
            MyChangingsCommand = new Command(MyChangings);
        }

        Changing? changing;
        public Changing? Changing
        {
            get => changing;
            set
            {
                changing = value;
                OnPropertyChanged();
            }
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

        public Command? MyChangingsCommand { get; }

        async void MyChangings()
        {
            IsBusy = true;
            await Shell.Current.Navigation.PushAsync(new MyChangingsPage());
            IsBusy = false;
        }
    }
}
