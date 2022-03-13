using milkdrunk.models;
using System.Threading.Tasks;

namespace milkdrunk.services.interfaces
{
    public interface IDefaultService
    {
        Caregiver? Caregiver { get; set; }

         Caregroup? Caregroup { get; set; }

        Baby? Baby { get; set; }

        string? Title { get; set; }

        Task UpdatePropertiesAsync();
    }
}
