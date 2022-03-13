using milkdrunk.Droid.Services;
using milkdrunk.services.interfaces;
using System;
using System.IO;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(LocalStorageAccessService))]
namespace milkdrunk.Droid.Services
{
    public sealed class LocalStorageAccessService : ILocalStorageAccessService
    {
        public Task<string> FilePathAsync(string filename)
        {
            var lad = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dir = Path.Combine(lad, "milkdrunk");
            var path = Path.Combine(dir, filename);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            return Task.FromResult(path);
        }

        public string FilePath(string filename) =>
            FilePathAsync(filename).Result;
    }
}