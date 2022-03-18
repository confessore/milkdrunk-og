using milkdrunk.views;
using Xamarin.Forms;

namespace milkdrunk.viewmodels
{
    public class FeedingViewModel : BaseViewModel
    {
        public FeedingViewModel()
        {
            MyFeedingsCommand = new Command(MyFeedings);
        }

        public Command? MyFeedingsCommand { get; }

        async void MyFeedings()
        {
            IsBusy = true;
            await Shell.Current.Navigation.PushAsync(new MyFeedingsPage());
            IsBusy = false;
        }
    }
}
