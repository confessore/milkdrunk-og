using milkdrunk.models;
using milkdrunk.services.interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.services
{
    public class DefaultService : IDefaultService
    {
        ILocalStorageService _localStorageService =>
            DependencyService.Get<ILocalStorageService>();

        public ILiteDBService<Caregiver, string> _caregiverDBService =>
            DependencyService.Get<ILiteDBService<Caregiver, string>>();

        public Caregiver? Caregiver { get; set; }

        public Caregroup? Caregroup { get; set; }

        public Baby? Baby { get; set; } = new Baby();

        public string? Title { get; set; } = string.Empty;

        public async Task UpdatePropertiesAsync()
        {
            var caregivers = await _caregiverDBService.FindAllAsync();
            Caregiver = caregivers.FirstOrDefault();
            //Caregiver = await _localStorageService.ReadFromFileAsync<Caregiver>("caregiver");
            if (Caregiver != null)
            {
                if (Caregiver.Babies != null)
                    Baby = Caregiver.Babies.FirstOrDefault();
                //Baby = await _localStorageService.ReadFromFileAsync<Baby>("baby");
                if (Baby != null)
                    Title = $"{Baby.Name!} | {(DateTime.Now - Baby.BirthDate!).Days / 7}w, {(DateTime.Now - Baby.BirthDate!).Days % 7}d";
            }
        }
    }
}
