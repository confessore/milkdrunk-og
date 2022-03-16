using milkdrunk.viewmodels;
using Xamarin.Forms;

namespace milkdrunk.views
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
