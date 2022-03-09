using System;
using Xamarin.Forms;

namespace milkdrunk.ViewModels
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

        void Confirm()
        {
            IsBusy = true;
            var baby = new Baby()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Name,
                BirthDate = BirthDate
            };
            _babyContext.UpsertAsync(baby);
            IsBusy = false;
        }
    }
}
