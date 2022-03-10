using milkdrunk.models;
using System.Collections.Generic;

namespace milkdrunk.viewmodels
{
    public class ChangingViewModel : BaseViewModel
    {
        public ChangingViewModel()
        {
        }

        Changing changing;
        public Changing Changing
        {
            get => changing;
            set
            {
                changing = value;
                OnPropertyChanged();
            }
        }

        ICollection<Changing> changings;
        public ICollection<Changing> Changings
        {
            get => changings;
            set
            {
                changings = value;
                OnPropertyChanged();
            }
        }
    }
}
