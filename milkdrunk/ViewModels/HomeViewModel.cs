using milkdrunk.models;
using milkdrunk.views;
using System;
using System.Linq;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            MyBabiesCommand = new Command(MyBabies);
            CreateCaregroupCommand = new Command(CreateCaregroupAsync);
        }

        public Command? CreateCaregroupCommand { get; }

        async void CreateCaregroupAsync()
        {
            IsBusy = true;
            var caregroup = new Caregroup()
            {
                Id = Guid.NewGuid().ToString(),
                Owner = Caregiver
            };
            //await _defaultService._caregroupContext.UpsertAsync(caregroup);
            var updated = new HomePage();
            await Shell.Current.Navigation.PopAsync();
            await Shell.Current.Navigation.PushAsync(updated);
            IsBusy = false;
        }

        public Command? MyBabiesCommand { get; }

        async void MyBabies()
        {
            IsBusy = true;
            await Shell.Current.Navigation.PushAsync(new MyBabiesPage());
            IsBusy = false;
        }
    }
}
