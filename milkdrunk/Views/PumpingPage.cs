using milkdrunk.ViewModels;
using System;

using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class PumpingPage
    {
        PumpingViewModel _vm;

        public PumpingPage()
        {
            BindingContext = _vm = new PumpingViewModel();
            Build();
        }
    }
}

