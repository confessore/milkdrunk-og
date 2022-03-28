using milkdrunk.shellmodels;
using Xamarin.Forms;

namespace milkdrunk.shells
{
    public partial class DefaultShell : Shell
    {
        DefaultShellModel _sm;

        public DefaultShell()
        {
            BindingContext = _sm = new DefaultShellModel();
            Build();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
