﻿using milkdrunk.models;
using milkdrunk.services.interfaces;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace milkdrunk.services
{
    public  class LocalStorageService : ILocalStorageService
    {
        ILocalStorageAccessService _localStorageAccessService =>
            DependencyService.Get<ILocalStorageAccessService>();

        public async Task WriteToFileAsync<T>(T obj, string filename)
        {
            try
            {
                var filepath = await _localStorageAccessService.FilePathAsync(filename);
                await File.WriteAllTextAsync(filepath, JsonSerializer.Serialize(obj));
            }
            catch { }
        }

        public async Task<T> ReadFromFileAsync<T>(string filename)
        {
            try
            {
                var filepath = await _localStorageAccessService.FilePathAsync(filename);
                var obj = JsonSerializer.Deserialize<T>(await File.ReadAllTextAsync(filepath));
                if (obj != null)
                    return obj;
                return default;
            }
            catch { return default; }
        }

        public async Task<Caregiver> ReadCaregiverAsync()
        {
            var filepath = await _localStorageAccessService.FilePathAsync("caregiver");
            if (await FileExistsAsync(filepath))
                return JsonSerializer.Deserialize<Caregiver>(await File.ReadAllTextAsync(filepath));
            return new Caregiver();
        }

        public async Task<bool> FileExistsAsync(string filepath) =>
            await Task.FromResult(File.Exists(filepath));
    }
}