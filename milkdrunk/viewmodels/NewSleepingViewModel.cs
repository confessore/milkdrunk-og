using milkdrunk.models;
using System;
using System.Threading.Tasks;

namespace milkdrunk.viewmodels
{
    public class NewSleepingViewModel : BaseViewModel
    {
        public NewSleepingViewModel()
        {
        }

        DateTime start = DateTime.Now;
        public DateTime Start
        {
            get => start;
            set
            {
                start = value;
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

        DateTime end = DateTime.Now;
        public DateTime End
        {
            get => end;
            set
            {
                end = value;
                OnPropertyChanged();
            }
        }

        Sleeping sleeping;
        public Sleeping Sleeping
        {
            get => sleeping;
            set
            {
                sleeping = value;
                OnPropertyChanged();
            }
        }

        public override async Task OnAppearingAsync()
        {
            await base.OnAppearingAsync();
            IsBusy = true;

            IsBusy = false;
        }
    }
}
