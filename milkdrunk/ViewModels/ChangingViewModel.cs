using milkdrunk.Views;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.ViewModels
{
    public class ChangingViewModel : BaseViewModel
    {
        ILiteDBService<Baby, string> _babyContext =>
            DependencyService.Get<ILiteDBService<Baby, string>>();

        public ChangingViewModel()
        {
        }

        Changing changing;
        public Changing Changing
        {
            get => changing;
            set
            {
                changing = value;
                OnPropertyChanged();
            }
        }

        ICollection<Changing> changings;
        public ICollection<Changing> Changings
        {
            get => changings;
            set
            {
                changings = value;
                OnPropertyChanged();
            }
        }

        Baby baby;
        public Baby Baby
        {
            get => baby;
            set
            {
                baby = value;
                OnPropertyChanged();
            }
        }

        public async Task OnAppearingAsync()
        {
            var babies = await _babyContext.FindAllAsync();
            Baby = babies.FirstOrDefault();
            if (Baby == null)
                await Shell.Current.Navigation.PushAsync(new NewBabyPage());
        }
    }
}
