using System.Threading.Tasks;

namespace milkdrunk.viewmodels
{
    public class NewSleepingViewModel : BaseViewModel
    {
        public NewSleepingViewModel()
        {
        }

        public override async Task OnAppearingAsync()
        {
            await base.OnAppearingAsync();
            IsBusy = true;

            IsBusy = false;
        }
    }
}
