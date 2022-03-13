using milkdrunk.models;
using milkdrunk.views;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class DefaultViewModel : BaseViewModel
    {
        new public virtual async Task OnAppearingAsync()
        {
            IsBusy = true;
            var caregiver = await _jsonStorageService.ReadFromFileAsync<Caregiver>("caregiver");
            if (caregiver != null)
            {
                await Task.Delay(1000);
                App.Current.MainPage = new AppShell();
            }
            else
                App.Current.MainPage = new WelcomePage();
            IsBusy = false;
        }
    }
}
