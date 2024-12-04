using LibraryApp.Shared;

namespace LibraryApp;

public interface IKölcsönzesSzervice
{
    Task AddAsync(Kölcsönzes könyv);

    Task DeleteAsync(Guid id);

    Task<Kölcsönzes> GetAsync(Guid id);

    Task<List<Kölcsönzes>> GetAllAsync();

    Task UpdateAsync(Kölcsönzes newKölcsönzes);

}