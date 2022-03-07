using System;
using System.Collections.Generic;
using milkdrunk.ViewModels;
using milkdrunk.Views;
using Xamarin.Forms;

namespace milkdrunk
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
