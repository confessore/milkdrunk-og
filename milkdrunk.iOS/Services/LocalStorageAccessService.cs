using milkdrunk.iOS.Services;
using milkdrunk.services.interfaces;
using milkdrunk.statics;
using System.IO;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(LocalStorageAccessService))]
namespace milkdrunk.iOS.Services
{
    public sealed class LocalStorageAccessService : ILocalStorageAccessService
    {
        public Task<string> FilePathAsync(string filename)
        {
            if (!Directory.Exists(Paths.CachesDirectory))
                Directory.CreateDirectory(Paths.CachesDirectory);
            return Task.FromResult(Paths.CachesFile(filename));
        }

        public string FilePath(string filename) =>
            FilePathAsync(filename).Result;
    }
}
