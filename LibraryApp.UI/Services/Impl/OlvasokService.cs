using LibraryApp.Shared;
using System.Net.Http.Json;

namespace LibraryApp.UI.Services;


public class OlvasokService : IOlvasokService
{
    private readonly HttpClient _httpClient;

    public OlvasokService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Olvaso>> GetAllAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Olvaso>>("olvaso");
    }

    public async Task AddAsync(Olvaso olvaso)
    {
        await _httpClient.PostAsJsonAsync("olvaso", olvaso);
    }

    public async Task<Olvaso> GetAsync(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<Olvaso>($"olvaso/{id}");
    }

    public async Task DeleteAsync(Guid id)
    {
        await _httpClient.DeleteAsync($"olvaso/{id}");
    }

    public async Task UpdateAsync(Olvaso olvaso)
    {
        await _httpClient.PutAsJsonAsync<Olvaso>($"people/{olvaso.OSz}", olvaso);
    }
}