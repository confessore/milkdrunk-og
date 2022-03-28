using milkdrunk.models;
using milkdrunk.shells;
using System;
using Xamarin.Forms;

namespace milkdrunk.pagemodels
{
    class WelcomePageModel : BasePageModel
    {
        public WelcomePageModel()
        {
            ConfirmCommand = new Command(ConfirmAsync);
        }

        string? name;
        public string? Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public Command? ConfirmCommand { get; }

        async void ConfirmAsync()
        {
            IsBusy = true;
            var caregiver = new Caregiver()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Name
            };
            await _localStorageService.WriteToFileAsync(caregiver, "caregiver");
            App.Current.MainPage = new DefaultShell();
            IsBusy = false;
        }
    }
}
