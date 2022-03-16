using milkdrunk.viewmodels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace milkdrunk.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}
