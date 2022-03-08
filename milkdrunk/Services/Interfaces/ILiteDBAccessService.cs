using System.Threading.Tasks;

namespace milkdrunk.Services.Interfaces
{
    public interface ILiteDBAccessService
    {
        Task<string> ConnectionAsync(string filename);
        string Connection(string filename);
    }
}
