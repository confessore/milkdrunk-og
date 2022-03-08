using milkdrunk.ViewModels;
using Xamarin.Forms;

namespace milkdrunk.Views
{
    public partial class AboutPage : ContentPage
    {
        AboutViewModel _vm;

        public AboutPage()
        {
            InitializeComponent();
            BindingContext = _vm = new AboutViewModel();
        }
    }
}
