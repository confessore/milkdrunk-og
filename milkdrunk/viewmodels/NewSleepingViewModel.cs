using milkdrunk.models;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class NewSleepingViewModel : BaseViewModel
    {
        public NewSleepingViewModel()
        {
            AddNewSleepingCommand = new Command(AddNewSleeping, CanAddNewSleeping);
        }

        DateTime startDate = DateTime.Now;
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                startDate = value;
                AddNewSleepingCommand.ChangeCanExecute();
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
                AddNewSleepingCommand.ChangeCanExecute();
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
                AddNewSleepingCommand.ChangeCanExecute();
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
                AddNewSleepingCommand.ChangeCanExecute();
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
                AddNewSleepingCommand.ChangeCanExecute();
                OnPropertyChanged();
            }
        }

        Sleeping sleeping = new Sleeping();
        public Sleeping Sleeping
        {
            get => sleeping;
            set
            {
                sleeping = value;
                OnPropertyChanged();
            }
        }

        public Command? AddNewSleepingCommand { get; }

        bool CanAddNewSleeping()
        {
            if (IsChecked)
            {
                if (StartDate.Date == EndDate.Date)
                    return StartTime.Minutes < EndTime.Minutes;
                return StartDate.Date < EndDate.Date;
            }
            return true;
        }

        void AddNewSleeping()
        {

        }

        public override async Task OnAppearingAsync()
        {
            await base.OnAppearingAsync();
            IsBusy = true;

            IsBusy = false;
        }
    }
}
