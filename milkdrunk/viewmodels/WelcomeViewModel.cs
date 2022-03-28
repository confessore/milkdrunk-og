using milkdrunk.models;
using milkdrunk.views;
using System;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    internal class WelcomeViewModel : BaseViewModel
    {
        public WelcomeViewModel()
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
