using milkdrunk.models;
using System;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    internal class WelcomeViewModel : BaseViewModel
    {
        public WelcomeViewModel()
        {
            ConfirmCommand = new Command(Confirm);
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

        void Confirm()
        {
            IsBusy = true;
            var caregiver = new Caregiver()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Name
            };
            _caregiverContext.UpsertAsync(caregiver);
            App.Current.MainPage = new AppShell();
            IsBusy = false;
        }
    }
}
