using LibraryApp.Shared;

namespace LibraryApp.UI.Services;

public interface IOlvasokService
{
    public Task<List<Olvaso>> GetAllAsync();
    
    public Task AddAsync(Olvaso olvaso);
    
    public Task<Olvaso> GetAsync(Guid id);
    
    public Task DeleteAsync(Guid id);
    
    public Task UpdateAsync(Olvaso olvaso);
}