using milkdrunk.models;
using milkdrunk.models.enums;
using milkdrunk.pages;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace milkdrunk.pagemodels
{
    class ChangingDetailPageModel : BasePageModel
    {

        readonly Changing _changing;

        public ChangingDetailPageModel(
            Changing changing)
        {
            _changing = changing;
            Time = changing.Time;
            ChangingType = changing.ChangingType;
            EditChangingCommand = new Command(EditChanging);
            DeleteChangingCommand = new Command(DeleteChanging);
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

        public Command? EditChangingCommand { get; }

        async void EditChanging()
        {
            IsBusy = true;
            await Shell.Current.Navigation.PushAsync(new EditChangingPage(_changing));
            IsBusy = false;
        }

        public Command? DeleteChangingCommand { get; }

        async void DeleteChanging()
        {
            IsBusy = true;
            var baby = Caregiver.Babies.FirstOrDefault(x => x.Id == Baby.Id);
            if (baby.Changings == null)
                baby.Changings = new Collection<Changing>();
            var changing = baby.Changings.FirstOrDefault(x => x.Id == _changing.Id);
            baby.Changings.Remove(changing);
            Caregiver.Babies.Remove(baby);
            Caregiver.Babies.Add(baby);
            await _localStorageService.WriteToFileAsync<Caregiver>(Caregiver, "caregiver");
            await Shell.Current.Navigation.PopAsync();
            IsBusy = false;
        }
    }
}
