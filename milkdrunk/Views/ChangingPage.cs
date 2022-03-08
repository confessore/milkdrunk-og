using milkdrunk.ViewModels;
using System;

using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class ChangingPage
    {
        ChangingViewModel _vm;

        public ChangingPage()
        {
            BindingContext = _vm = new ChangingViewModel();
            Build();
        }
    }
}

