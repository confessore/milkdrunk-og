using milkdrunk.models;
using Xamarin.Forms;

namespace milkdrunk.pagemodels
{
    class EditChangingPageModel : BasePageModel
    {
        readonly Changing _changing;

        public EditChangingPageModel(
            Changing changing)
        {
            _changing = changing;
            ConfirmCommand = new Command(Confirm);
        }

        public Command? ConfirmCommand { get; }

        void Confirm()
        {

        }
    }
}
