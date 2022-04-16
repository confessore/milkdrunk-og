using milkdrunk.models;
using milkdrunk.models.enums;
using System;
using System.Collections.ObjectModel;

namespace milkdrunk.pagemodels
{
    class ChangingDetailPageModel : BasePageModel
    {
        public ChangingDetailPageModel(
            Changing changing)
        {
            Time = changing.Time;
            ChangingType = changing.ChangingType;
        }

        ObservableCollection<Changing>? changings;
        public ObservableCollection<Changing>? Changings
        {
            get => changings;
            set
            {
                changings = value;
                OnPropertyChanged();
            }
        }

        DateTime time;
        public DateTime Time
        {
            get => time;
            set
            {
                time = value;
                OnPropertyChanged();
            }
        }

        ChangingType changingType;
        public ChangingType ChangingType
        {
            get => changingType;
            set
            {
                changingType = value;
                OnPropertyChanged();
            }
        }
    }
}
