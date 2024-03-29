﻿using milkdrunk.models;
using System;
using System.Linq;
using Xamarin.Forms;

namespace milkdrunk.pagemodels
{
    class BabyDetailPageModel : BasePageModel
    {
        public BabyDetailPageModel(
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
            IsBusy = true;
            await _localStorageService.WriteToFileAsync(Caregiver.Babies.FirstOrDefault(x => x.Id == Id), "baby");
            await Shell.Current.Navigation.PopAsync();
            IsBusy = false;
        }
    }
}
