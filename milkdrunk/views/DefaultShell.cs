using Xamarin.Forms;

namespace milkdrunk.views
{
    public partial class DefaultShell
    {
        void Build()
        {
            Resources.Add("BaseStyle", DefaultStyle());
            Resources.Add(TabBarStyle());
            Items.Add(DefaultTabBar());
        }

        Style DefaultStyle()
        {
            var style = new Style(typeof(Element));
            style.Setters.Add(new()
            {
                Property = Shell.BackgroundColorProperty,
                Value = App.Current.Resources["Primary"] ?? default
            });
            style.Setters.Add(new()
            {
                Property = Shell.TabBarBackgroundColorProperty,
                Value = App.Current.Resources["Tertiary"] ?? default
            });
            return style;
        }

        Style TabBarStyle()
        {
            var style = new Style(typeof(TabBar))
            {
                BasedOn = (Style)Resources["BaseStyle"] ?? default
            };
            return style;
        }

        TabBar DefaultTabBar()
        {
            return new()
            {
                Items =
                {
                    HomeTab(),
                    SleepingTab()
                }
            };
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
