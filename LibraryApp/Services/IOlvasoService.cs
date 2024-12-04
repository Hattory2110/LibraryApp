using LibraryApp.Shared;

namespace LibraryApp;

public interface IOlvasoService
{
    Task AddAsync(Olvaso olvaso);

    Task DeleteAsync(Guid osz);

    Task<Olvaso> GetAsync(Guid osz);

    Task<List<Olvaso>> GetAllAsync();

    Task UpdateAsync(Olvaso newOlvaso);
}