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

        public string? Title { get; set; } = string.Empty;

        public async Task UpdatePropertiesAsync()
        {
            Caregiver = await _localStorageService.ReadFromFileAsync<Caregiver>("caregiver");
            if (Caregiver != null)
            {
                Baby = await _localStorageService.ReadFromFileAsync<Baby>("baby");
                if (Baby != null)
                    Title = $"{Baby.Name!} | {(DateTime.Now - Baby.BirthDate!).Days / 7}w, {(DateTime.Now - Baby.BirthDate!).Days % 7}d";
            }
        }
    }
}
