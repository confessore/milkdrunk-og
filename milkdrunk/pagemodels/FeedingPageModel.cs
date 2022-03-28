using milkdrunk.pages;
using Xamarin.Forms;

namespace milkdrunk.pagemodels
{
    class FeedingPageModel : BasePageModel
    {
        public FeedingPageModel()
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
