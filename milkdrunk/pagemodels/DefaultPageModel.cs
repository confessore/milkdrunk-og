using milkdrunk.models;
using milkdrunk.pages;
using milkdrunk.shells;
using System.Linq;
using System.Threading.Tasks;

namespace milkdrunk.pagemodels
{
    class DefaultPageModel : BasePageModel
    {
        new public virtual async Task OnAppearingAsync()
        {
            IsBusy = true;
            var caregivers = await _caregiverDBService.FindAllAsync();
            var caregiver = caregivers.FirstOrDefault();
            //var caregiver = await _localStorageService.ReadFromFileAsync<Caregiver>("caregiver");
            if (caregiver != null)
            {
                await Task.Delay(1000);
                App.Current.MainPage = new DefaultShell();
            }
            else
                App.Current.MainPage = new WelcomePage();
            IsBusy = false;
        }
    }
}
