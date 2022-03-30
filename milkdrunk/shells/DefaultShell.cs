using milkdrunk.pages;
using Xamarin.Forms;

namespace milkdrunk.shells
{
    public partial class DefaultShell
    {
        void Build()
        {
            Resources.Add("BaseStyle", DefaultStyle());
            Resources.Add(TabBarStyle());
            Resources.Add(FlyoutItemStyle());
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
                Property = Shell.ForegroundColorProperty,
                Value = Color.White
            });
            style.Setters.Add(new()
            {
                Property = Shell.TitleColorProperty,
                Value = Color.White
            });
            style.Setters.Add(new()
            {
                Property = Shell.DisabledColorProperty,
                Value = Color.FromHex("#B4FFFFFF")
            });
            style.Setters.Add(new()
            {
                Property = Shell.UnselectedColorProperty,
                Value = Color.FromHex("#95FFFFFF")
            });
            style.Setters.Add(new()
            {
                Property = Shell.TabBarBackgroundColorProperty,
                Value = App.Current.Resources["Tertiary"] ?? default
            });
            style.Setters.Add(new()
            {
                Property = Shell.TabBarForegroundColorProperty,
                Value = Color.White
            });
            style.Setters.Add(new()
            {
                Property = Shell.TabBarUnselectedColorProperty,
                Value = Color.FromHex("#95FFFFFF")
            });
            style.Setters.Add(new()
            {
                Property = Shell.TabBarTitleColorProperty,
                Value = Color.White
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

        Style FlyoutItemStyle()
        {
            var style = new Style(typeof(FlyoutItem))
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
                    ChangingTab(),
                    FeedingTab(),
                    SleepingTab(),
                    PumpingTab()
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

        ShellContent ChangingTab()
        {
            return new()
            {
                Title = "changing",
                Icon = "diaper.png",
                Route = "ChangingPage",
                ContentTemplate = new DataTemplate(typeof(ChangingPage)),
            };
        }

        ShellContent FeedingTab()
        {
            return new()
            {
                Title = "feeding",
                Icon = new FileImageSource(),
                Route = "FeedingPage",
                ContentTemplate = new DataTemplate(typeof(FeedingPage)),
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

        ShellContent PumpingTab()
        {
            return new()
            {
                Title = "pumping",
                Icon = "pump.png",
                Route = "PumpingPage",
                ContentTemplate = new DataTemplate(typeof(PumpingPage)),
            };
        }
    }
}
