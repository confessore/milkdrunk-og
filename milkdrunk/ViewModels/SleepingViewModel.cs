using milkdrunk.models;
using System;
using System.Collections.Generic;
using System.Timers;

namespace milkdrunk.ViewModels
{
    public class SleepingViewModel : BaseViewModel
    {
        public SleepingViewModel()
        {
        }

        DateTime start;
        public DateTime Start
        {
            get => start;
            set
            {
                start = value;
                OnPropertyChanged();
            }
        }

        DateTime end;
        public DateTime End
        {
            get => end;
            set
            {
                end = value;
                OnPropertyChanged();
            }
        }

        Timer timer;
        public Timer Timer
        {
            get => timer;
            set
            {
                timer = value;
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

        ICollection<Sleeping> sleepings;
        public ICollection<Sleeping> Sleepings
        {
            get => sleepings;
            set
            {
                sleepings = value;
                OnPropertyChanged();
            }
        }
    }
}
