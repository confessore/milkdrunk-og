using milkdrunk.ViewModels;
using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
