using LibraryApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Contexts;

public class AppContext : DbContext
{
    public AppContext(DbContextOptions<AppContext> options)
        : base(options)
    {
    }
    
    public virtual DbSet<Könyv> Könyv { get; set; }
    
    public virtual DbSet<Kölcsönzes> Kölcsönzes { get; set; }
    
    public virtual DbSet<Olvaso> Olvaso { get; set; }
}
