using milkdrunk.ViewModels;
using System;

using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class SleepingPage
    {
        SleepingViewModel _vm;

        public SleepingPage()
        {
            BindingContext = _vm = new SleepingViewModel();
            Build();
        }
    }
}

