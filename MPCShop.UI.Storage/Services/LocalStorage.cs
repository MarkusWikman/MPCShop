using Blazored.LocalStorage;

namespace MPCShop.UI.Storage.Services;

public class LocalStorage(ILocalStorageService localStorage) : IStorageService
{
    public async Task<T?> GetAsync<T>(string key) => //add
        await localStorage.GetItemAsync<T>(key);

    public async Task RemoveAsync(string key) => //remove
        await localStorage.RemoveItemAsync(key);

    public async Task SetAsync<T>(string key, T value) => //update
        await localStorage.SetItemAsync(key, value);
}

