using milkdrunk.models;
using System.Collections.ObjectModel;

namespace milkdrunk.pagemodels
{
    class ChangingDetailPageModel : BasePageModel
    {
        public ChangingDetailPageModel()
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
