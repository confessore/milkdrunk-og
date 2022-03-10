using System.Threading.Tasks;

namespace milkdrunk.services.interfaces
{
    public interface ILiteDBAccessService
    {
        Task<string> ConnectionAsync(string filename);
        string Connection(string filename);
    }
}
