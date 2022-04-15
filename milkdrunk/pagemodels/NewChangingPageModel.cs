using milkdrunk.models;
using milkdrunk.models.enums;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.pagemodels
{
    class NewChangingPageModel : BasePageModel
    {
        public NewChangingPageModel()
        {
            AddNewChangingCommand = new Command(AddNewChanging, CanAddNewChanging);
            PropertyChanged +=
                (_, __) => AddNewChangingCommand.ChangeCanExecute();
            ChangingTypes = Enum.GetNames(typeof(ChangingType));
        }

        public string[] ChangingTypes { get; }

        string? selectedChangingType;
        public string? SelectedChangingType
        {
            get => selectedChangingType;
            set
            {
                selectedChangingType = value;
                OnPropertyChanged();
            }
        }
         
        DateTime date = DateTime.Now;
        public DateTime Date
        {
            get => date;
            set
            {
                date = value;
                OnPropertyChanged();
            }
        }

        TimeSpan time = DateTime.Now.TimeOfDay;
        public TimeSpan Time
        {
            get => time;
            set
            {
                time = value;
                OnPropertyChanged();
            }
        }

        public Command? AddNewChangingCommand { get; }

        bool CanAddNewChanging() =>
            !string.IsNullOrWhiteSpace(SelectedChangingType);

        async void AddNewChanging()
        {
            IsBusy = true;
            var record = new DateTime(Date.Year, Date.Month, Date.Day, Time.Hours, Time.Minutes, 0);
            var changing = new Changing()
            {
                ChangingType = Enum.Parse<ChangingType>(SelectedChangingType),
                Time = record
            };
            var baby = Caregiver.Babies.FirstOrDefault(x => x.Id == Baby.Id);
            if (baby.Changings == null)
                baby.Changings = new Collection<Changing>();
            baby.Changings.Add(changing);
            Caregiver.Babies.Remove(baby);
            Caregiver.Babies.Add(baby);
            await _localStorageService.WriteToFileAsync<Caregiver>(Caregiver, "caregiver");
            await Shell.Current.Navigation.PopAsync();
            IsBusy = false;
        }

        public override async Task OnAppearingAsync()
        {
            await base.OnAppearingAsync();
            IsBusy = true;

            IsBusy = false;
        }
    }
}
