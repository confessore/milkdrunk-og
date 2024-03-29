﻿using milkdrunk.models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace milkdrunk.pagemodels
{
    class NewBabyPageModel : BasePageModel
    {
        public NewBabyPageModel()
        {
            ConfirmCommand = new Command(ConfirmAsync);
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

        DateTime birthDate = DateTime.Now;
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                birthDate = value;
                OnPropertyChanged();
            }
        }

        public Command? ConfirmCommand { get; }

        async void ConfirmAsync()
        {
            IsBusy = true;
            var baby = new Baby()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Name,
                BirthDate = BirthDate
            };
            //await _defaultService._babyContext.UpsertAsync(baby);
            if (Caregiver.Babies == null)
                Caregiver.Babies = new Collection<Baby>();
            Caregiver.Babies.Add(baby);
            await _localStorageService.WriteToFileAsync(Caregiver, "caregiver");
            if (!await _localStorageService.FileExistsAsync("baby"))
                await _localStorageService.WriteToFileAsync(baby, "baby");
            await Shell.Current.Navigation.PopAsync();
            IsBusy = false;
        }
    }
}
