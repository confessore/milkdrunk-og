using milkdrunk.models;
using milkdrunk.views;
using System.Threading.Tasks;

namespace milkdrunk.viewmodels
{
    public class DefaultViewModel : BaseViewModel
    {
        new public virtual async Task OnAppearingAsync()
        {
            IsBusy = true;
            var caregiver = await _localStorageService.ReadFromFileAsync<Caregiver>("caregiver");
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
