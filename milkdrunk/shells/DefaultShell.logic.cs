using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.shells
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
