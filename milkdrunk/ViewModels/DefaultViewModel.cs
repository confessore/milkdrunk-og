using System;
using System.Threading.Tasks;
using milkdrunk.Views;
using Xamarin.Forms;

namespace milkdrunk.ViewModels
{
    public class DefaultViewModel : BaseViewModel
    {
        string? name;
        public string? Name
        {
            get => name;
            set
            {
                name = value;
                Baby!.Name = value;
                OnPropertyChanged();
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

        public override async Task OnAppearingAsync()
        {
            if (await _babyContext.AnyAsync())
                App.Current.MainPage = new AppShell();
            else
                App.Current.MainPage = new NewBabyPage();
        }
    }
}
