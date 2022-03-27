using System;
using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class DefaultShell : Shell
    {
        DefaultShellViewModel _vm;

        public DefaultShell()
        {
            BindingContext = _vm = new DefaultShellViewModel();
            Build();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
