using System.Threading.Tasks;

namespace milkdrunk.services.interfaces
{
    public interface ILocalStorageService
    {
        Task WriteToFileAsync<T>(T obj, string filename);

        Task<T> ReadFromFileAsync<T>(string filename);
        Task<bool> FileExistsAsync(string filepath);
    }
}
