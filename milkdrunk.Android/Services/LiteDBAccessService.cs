using System;
using System.IO;
using System.Threading.Tasks;
using milkdrunk.Droid.Services;
using milkdrunk.Services.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(LiteDatabaseAccessService))]
namespace milkdrunk.Droid.Services
{
    public sealed class LiteDatabaseAccessService : ILiteDBAccessService
    {
        public Task<string> ConnectionAsync(string filename)
        {
            var lad = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dir = Path.Combine(lad, "milkdrunk");
            var path = Path.Combine(dir, filename);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            return Task.FromResult(path);
        }

        public string Connection(string filename) =>
            ConnectionAsync(filename).Result;
    }
}