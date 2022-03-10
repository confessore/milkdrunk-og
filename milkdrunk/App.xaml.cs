using milkdrunk.models;
using milkdrunk.services;
using milkdrunk.services.interfaces;
using milkdrunk.views;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //DependencyService.Register<MockDataStore>();
        }

        protected override async void OnStart()
        {
            await RegisterServicesAsync();
            // this will have to be moved back into the constructor
            // when migrated to net maui
            // the renderer will crash otherwise
            MainPage = new DefaultPage();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        Task RegisterServicesAsync()
        {
            DependencyService.Register<ILiteDBAccessService>();
            DependencyService.Register<ILiteDBService<Baby, string>, LiteDBService<Baby, string>>();
            return Task.CompletedTask;
        }
    }
}
