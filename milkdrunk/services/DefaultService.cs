using milkdrunk.models;
using milkdrunk.services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.services
{
    public class DefaultService : IDefaultService
    {
        ILocalStorageService _localStorageService =>
            DependencyService.Get<ILocalStorageService>();

        public Caregiver? Caregiver { get; set; }

        public Caregroup? Caregroup { get; set; }

        public Baby? Baby { get; set; }

        public string? Title { get; set; }

        public async Task UpdatePropertiesAsync()
        {
            Caregiver = await _localStorageService.ReadFromFileAsync<Caregiver>("caregiver");
        }
    }
}
