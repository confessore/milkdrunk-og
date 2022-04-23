using milkdrunk.models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.pagemodels
{
    class NewSleepingPageModel : BasePageModel
    {
        public NewSleepingPageModel()
        {
            AddNewSleepingCommand = new Command(AddNewSleeping, CanAddNewSleeping);
            PropertyChanged +=
                (obj, args) => AddNewSleepingCommand.ChangeCanExecute();
        }

        DateTime startDate = DateTime.Now;
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                startDate = value;
                OnPropertyChanged();
            }
        }

        TimeSpan startTime = DateTime.Now.TimeOfDay;
        public TimeSpan StartTime
        {
            get => startTime;
            set
            {
                startTime = value;
                OnPropertyChanged();
            }
        }

        bool isChecked;
        public bool IsChecked
        {
            get => isChecked;
            set
            {
                isChecked = value;
                OnPropertyChanged();
            }
        }

        DateTime endDate = DateTime.Now;
        public DateTime EndDate
        {
            get => endDate;
            set
            {
                endDate = value;
                OnPropertyChanged();
            }
        }

        TimeSpan endTime = DateTime.Now.TimeOfDay;
        public TimeSpan EndTime

        {
            get => endTime;
            set
            {
                endTime = value;
                OnPropertyChanged();
            }
        }

        public Command? AddNewSleepingCommand { get; }

        bool CanAddNewSleeping()
        {
            if (IsChecked)
            {
                if (StartDate.Date == EndDate.Date)
                    return Math.Floor(StartTime.TotalMinutes) < Math.Floor(EndTime.TotalMinutes);
                return StartDate.Date < EndDate.Date;
            }
            return true;
        }

        async void AddNewSleeping()
        {
            IsBusy = true;
            var start = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartTime.Hours, StartTime.Minutes, 0);
            var end = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartTime.Hours, StartTime.Minutes, 0);
            var sleeping = new Sleeping()
            {
                Id = Guid.NewGuid().ToString(),
                Start = start,
                End = end
            };
            var baby = Caregiver.Babies.FirstOrDefault(x => x.Id == Baby.Id);
            if (baby.Sleepings == null)
                baby.Sleepings = new Collection<Sleeping>();
            baby.Sleepings.Add(sleeping);
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
