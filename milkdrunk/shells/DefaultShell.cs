using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using milkdrunk.pages;
using milkdrunk.views;
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

        // double check to make sure that you set the resources to build as embedded
        // you can just select all of them in vs2022, right click to properties and set to embedded resource
        // if there are alot (15+), the UI will get blocked but should respond when processing completes
        const string resources = "resource://milkdrunk.resources.";
        static string ToUri(string resource) => string.Concat(resources, resource);

        DefaultShellContent HomeTab()
        {
            return new()
            {
                Title = "home",
                Icon = new SvgCachedImage() { Source = "resource://milkdrunk.resources.home.png", HeightRequest = 64 },
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

        DefaultShellContent PumpingTab()
        {
            return new()
            {
                Title = "pumping",
                Icon = new SvgCachedImage() { Source = ToUri("pump.png"), HeightRequest = 28, WidthRequest = 28 },
                Route = "PumpingPage",
                ContentTemplate = new DataTemplate(typeof(PumpingPage)),
            };
        }
    }
}
