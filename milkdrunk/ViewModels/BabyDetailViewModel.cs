using milkdrunk.models;
using System;
using System.Linq;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class BabyDetailViewModel : BaseViewModel
    {
        public BabyDetailViewModel(
            Baby baby)
        {
            EditBabyCommand = new Command(EditBaby);
            SetDefaultBabyCommand = new Command(SetDefaultBaby);
            Id = baby.Id;
            Name = baby.Name;
            BirthDate = baby.BirthDate;
        }

        string? id;
        public string? Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }

        string? name;
        public string? Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
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

        public Command? EditBabyCommand { get; }

        void EditBaby()
        {

        }

        public Command? SetDefaultBabyCommand { get; }

        async void SetDefaultBaby()
        {
            System.Diagnostics.Debug.WriteLine("hello from set default baby");
            await _localStorageService.WriteToFileAsync(Caregiver.Babies.FirstOrDefault(x => x.Id == Id), "baby");
            await Shell.Current.Navigation.PopAsync();
        }
    }
}
