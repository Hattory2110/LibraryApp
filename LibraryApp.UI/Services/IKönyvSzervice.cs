using LibraryApp.Shared;

namespace LibraryApp;

public interface IKönyvSzervice
{
    Task AddAsync(Könyv könyv);

    Task DeleteAsync(Guid lsz);

    Task<Könyv> GetAsync(Guid lsz);

    Task<List<Könyv>> GetAllAsync();

    Task UpdateAsync(Könyv newKönyv);

}