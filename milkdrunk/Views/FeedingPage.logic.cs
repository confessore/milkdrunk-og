using milkdrunk.ViewModels;

namespace milkdrunk.Views
{
    public partial class FeedingPage
    {
        FeedingViewModel _vm;

        public FeedingPage()
        {
            BindingContext = _vm = new FeedingViewModel();
            Build();
        }
    }
}