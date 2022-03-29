using System.Threading.Tasks;
using milkdrunk.models;
using milkdrunk.pages;
using milkdrunk.services;
using milkdrunk.services.interfaces;
using Xamarin.Forms;

namespace milkdrunk
{
    partial class App : Application
    {
        public App()
        {
            //DependencyService.Register<MockDataStore>();
            Build();
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
            DependencyService.Register<ILocalStorageAccessService>();
            DependencyService.Register<ILiteDBService<Caregiver, string>, LiteDBService<Caregiver, string>>();
            DependencyService.Register<IDefaultService, DefaultService>();
            DependencyService.Register<ILocalStorageService, LocalStorageService>();
            return Task.CompletedTask;
        }
    }
}
