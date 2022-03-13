using milkdrunk.models;
using System;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class NewBabyViewModel : BaseViewModel
    {
        public NewBabyViewModel()
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
            }
        }

        DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                birthDate = value;
                OnPropertyChanged();
            }
        }

        public Command? ConfirmCommand { get; }

        async void Confirm()
        {
            IsBusy = true;
            var baby = new Baby()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Name,
                BirthDate = BirthDate
            };
            await _babyContext.UpsertAsync(baby);
            await Shell.Current.Navigation.PopAsync();
            IsBusy = false;
        }
    }
}
