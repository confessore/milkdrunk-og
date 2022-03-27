using System;
using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class DefaultShell
    {
        void Build()
        {
            Items.Add(DefaultTabBar());
            new Setter() { Property = Shell.BackgroundColorProperty, Value = App.Current.Resources.TryGetValue("Primary", out var primary) ? primary : Color.Blue };
        }

        ResourceDictionary DefaultResourceDictionary()
        {
            var resourceDictionary = new ResourceDictionary()
            {
                
            };
        }

        Style DefaultStyle()
        {
            var style = new Style(typeof(Element))
            {

            };
        }

        TabBar DefaultTabBar()
        {
            var tabBar = new TabBar();
            tabBar.Items.Add(HomeTab());
            return tabBar;
        }

        ShellContent HomeTab()
        {
            return new ShellContent()
            {
                Title = "home",
                Icon = "home.png",
                Route = "HomePage",
                ContentTemplate = new DataTemplate(typeof(HomePage)),
            };
        }
    }
}
