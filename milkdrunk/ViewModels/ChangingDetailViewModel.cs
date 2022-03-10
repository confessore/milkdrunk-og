using milkdrunk.models;
using System.Collections.ObjectModel;

namespace milkdrunk.viewmodels
{
    public class ChangingDetailViewModel : BaseViewModel
    {
        public ChangingDetailViewModel()
        {
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
    }
}
