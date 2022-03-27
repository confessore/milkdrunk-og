using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class DefaultShell
    {
        void Build()
        {
            Resources.Add("BaseStyle", DefaultResourceDictionary());
            Items.Add(DefaultTabBar());
        }

        ResourceDictionary DefaultResourceDictionary()
        {
            return new()
            {
                DefaultStyle(),
                TabBarStyle()
            };
        }

        Style DefaultStyle()
        {
            var style = new Style(typeof(Element));
            style.Setters.Add(new Setter()
            {
                Property = Shell.BackgroundColorProperty,
                Value = App.Current.Resources.TryGetValue("Primary", out var primary) ? primary : default
            });
            return style;
        }

        Style TabBarStyle()
        {
            var style = new Style(typeof(TabBar))
            {
                BasedOn = Resources.TryGetValue("BaseStyle", out var baseStyle) ? (Style)baseStyle : default
            };
            return style;
        }

        TabBar DefaultTabBar()
        {
            var tabBar = new TabBar();
            tabBar.Items.Add(HomeTab());
            tabBar.Items.Add(SleepingTab());
            return tabBar;
        }

        ShellContent HomeTab()
        {
            return new()
            {
                Title = "home",
                Icon = "home.png",
                Route = "HomePage",
                ContentTemplate = new DataTemplate(typeof(HomePage)),
            };
        }

        ShellContent SleepingTab()
        {
            return new()
            {
                Title = "sleeping",
                Icon = "sleep.png",
                Route = "SleepingPage",
                ContentTemplate = new DataTemplate(typeof(SleepingPage)),
            };
        }
    }
}
