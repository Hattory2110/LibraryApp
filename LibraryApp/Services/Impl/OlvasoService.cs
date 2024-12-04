using LibraryApp.Shared;
using System.Net.Http.Json;

namespace LibraryApp;

public class OlvasoService : IOlvasoService
{
    private readonly HttpClient _httpClient;

    public OlvasoService(ILogger<OlvasoService> logger, AppContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task AddAsync(Olvaso olvaso)
    {
        _logger.LogInformation("Olvaso to add: {@Olvaso}", olvaso);

        await _context.AddAsync(olvaso);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var olvaso = await GetAsync(id);

        if (olvaso is null)
        {
            throw new KeyNotFoundException("Olvaso not found");
        }
        
        _context.Remove(olvaso);
        await _context.SaveChangesAsync();
    }

    public async Task<Olvaso> GetAsync(Guid id)
    {
        return await _context.FindAsync<Olvaso>(id);
    }

    public async Task<List<Olvaso>> GetAllAsync()
    {
        _logger.LogInformation("All olvasó retrieved");
        return await _context.Olvaso.ToListAsync();
    }

    public async Task UpdateAsync(Olvaso newOlvaso)
    {
        var existingOlvaso = await GetAsync(newOlvaso.OSz);

        existingOlvaso.Name = newOlvaso.Name;
        existingOlvaso.Address = newOlvaso.Address;
        existingOlvaso.BirthDate = newOlvaso.BirthDate;
        
        await _context.SaveChangesAsync();
    }
}