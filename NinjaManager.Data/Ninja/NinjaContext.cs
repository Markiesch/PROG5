using Microsoft.EntityFrameworkCore;

namespace NinjaManager.Data;

public class NinjaContext : DbContext
{
    public DbSet<Ninja> Ninjas { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source =localhost\\MSSQLLocalDB; initial catalog = WoningDB");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}