using System.IO;
using System.Threading.Tasks;
using milkdrunk.iOS.Services;
using milkdrunk.Services.Interfaces;
using milkdrunk.statics;

[assembly: Xamarin.Forms.Dependency(typeof(LiteDBAccessService))]
namespace milkdrunk.iOS.Services
{
    public sealed class LiteDBAccessService : ILiteDBAccessService
    {
        public Task<string> ConnectionAsync(string filename)
        {
            if (!Directory.Exists(Paths.CachesDirectory))
                Directory.CreateDirectory(Paths.CachesDirectory);
            return Task.FromResult(Paths.CachesFile(filename));
        }

        public string Connection(string filename) =>
            ConnectionAsync(filename).Result;
    }
}
