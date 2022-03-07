using System;
namespace milkdrunk.ViewModels
{
    public class NewBabyViewModel : BaseViewModel
    {
        public NewBabyViewModel()
        {
        }

        string? name;
        public string? Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                birthDate = value;
                OnPropertyChanged();
            }
        }
    }
}
