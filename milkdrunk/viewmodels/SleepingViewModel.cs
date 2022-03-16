﻿using milkdrunk.views;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class SleepingViewModel : BaseViewModel
    {
        public SleepingViewModel()
        {
            NewSleepingCommand = new Command(NewSleeping);
        }

        public Command? NewSleepingCommand { get; }

        async void NewSleeping()
        {
            IsBusy = true;
            await Shell.Current.Navigation.PushAsync(new NewSleepingPage());
            IsBusy = false;
        }
    }
}