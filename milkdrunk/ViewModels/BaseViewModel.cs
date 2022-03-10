﻿using milkdrunk.models;
using milkdrunk.services.interfaces;
using milkdrunk.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public ILiteDBService<Baby, string> _babyContext =>
            DependencyService.Get<ILiteDBService<Baby, string>>();

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

        Baby? baby;
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
            var babies = await _babyContext.FindAllAsync();
            Baby = babies.FirstOrDefault();
            if (Baby == null)
                await Shell.Current.Navigation.PushAsync(new NewBabyPage());
            else
                Title = $"{Baby!.Name!} | {(DateTime.Now - Baby!.BirthDate!).Days / 7} weeks, {(DateTime.Now - Baby!.BirthDate!).Days%7} days old";
        }

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
        public event PropertyChangedEventHandler PropertyChanged;
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
