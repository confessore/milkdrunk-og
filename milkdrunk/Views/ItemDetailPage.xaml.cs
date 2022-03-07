using System.ComponentModel;
using Xamarin.Forms;
using milkdrunk.ViewModels;

namespace milkdrunk.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
