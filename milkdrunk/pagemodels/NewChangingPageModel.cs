using milkdrunk.models.enums;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.pagemodels
{
    class NewChangingPageModel : BasePageModel
    {
        public NewChangingPageModel()
        {
            //PropertyChanged +=
            //    (_, __) => SaveCommand.ChangeCanExecute();
            AddNewChangingCommand = new Command(AddNewChanging, CanAddNewChanging);
            ChangingTypes = Enum.GetNames(typeof(ChangingType));
        }

        public string[] ChangingTypes { get; }

        ChangingType? changingType;
        public ChangingType? ChangingType
        {
            get => changingType;
            set
            {
                changingType = value;
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

        bool CanAddNewChanging()
        {
            //if (IsChecked)
            //{
            //    if (StartDate.Date == EndDate.Date)
            //        return Math.Floor(StartTime.TotalMinutes) < Math.Floor(EndTime.TotalMinutes);
            //    return StartDate.Date < EndDate.Date;
            //}
            return true;
        }

        async void AddNewChanging()
        {
            IsBusy = true;
            //var start = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartTime.Hours, StartTime.Minutes, 0);
            //var end = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartTime.Hours, StartTime.Minutes, 0);
            //var sleeping = new Sleeping() { Start = start, End = end };
            //var baby = Caregiver.Babies.FirstOrDefault(x => x.Id == Baby.Id);
            //if (baby.Sleepings == null)
            //    baby.Sleepings = new Collection<Sleeping>();
            //baby.Sleepings.Add(sleeping);
            //Caregiver.Babies.Remove(baby);
            //Caregiver.Babies.Add(baby);
            //await _localStorageService.WriteToFileAsync<Caregiver>(Caregiver, "caregiver");
            //await Shell.Current.Navigation.PopAsync();
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
