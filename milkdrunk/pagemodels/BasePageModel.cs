﻿using milkdrunk.models;
using milkdrunk.services.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.pagemodels
{
    class BasePageModel : INotifyPropertyChanged
    {
        public IDefaultService _defaultService =>
            DependencyService.Get<IDefaultService>();

        public ILocalStorageService _localStorageService =>
            DependencyService.Get<ILocalStorageService>();

        public ILiteDBService<Caregiver, string> _caregiverDBService =>
            DependencyService.Get<ILiteDBService<Caregiver, string>>();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string? title = string.Empty;
        public string? Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        Caregiver? caregiver = new Caregiver();
        public Caregiver? Caregiver
        {
            get => caregiver;
            set
            {
                caregiver = value;
                OnPropertyChanged();
            }
        }

        Caregroup? caregroup = new Caregroup();
        public Caregroup? Caregroup
        {
            get => caregroup;
            set
            {
                caregroup = value;
                OnPropertyChanged();
            }
        }

        Baby? baby = new Baby();
        public Baby? Baby
        {
            get => baby;
            set
            {
                baby = value;
                OnPropertyChanged();
            }
        }

        public virtual async Task OnAppearingAsync()
        {
            IsBusy = true;
            var caregivers = await _caregiverDBService.FindAllAsync();
            Caregiver = caregivers.FirstOrDefault();
            if (Caregiver != null)
            {
                if (Caregiver.Babies != null)
                {
                    Baby = Caregiver.Babies.FirstOrDefault();
                    if (Baby != null)
                        Title = BuildTitle();
                }
            }
            IsBusy = false;
        }

        string? BuildTitle() =>
            $"{Baby!.Name!} | {(DateTime.Now - Baby.BirthDate!).Days / 7}w, {(DateTime.Now - Baby.BirthDate!).Days % 7}d";

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
