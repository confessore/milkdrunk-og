using System.Threading.Tasks;

namespace milkdrunk.services.interfaces
{
    public interface ILocalStorageAccessService
    {
        Task<string> FilePathAsync(string filename);
        string FilePath(string filename);
    }
}
