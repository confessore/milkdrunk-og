using milkdrunk.ViewModels;
using System;

using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class FeedingPage
    {
        FeedingViewModel _vm;

        public FeedingPage()
        {
            BindingContext = _vm = new FeedingViewModel();
            Build();
        }
    }
}

