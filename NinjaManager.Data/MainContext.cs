using Microsoft.EntityFrameworkCore;
using NinjaManager.Data.Models;

namespace NinjaManager.Data;

public class MainContext : DbContext
{
    public DbSet<Ninja> Ninjas { get; set; }
    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=NinjaManager;Integrated Security=SSPI;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Relationships
        modelBuilder.Entity<Ninja>()
            .HasMany(e => e.Equipments)
            .WithMany(e => e.Ninjas);

        // Seed data
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Head" },
            new Category { Id = 2, Name = "Necklace" },
            new Category { Id = 3, Name = "Chest" },
            new Category { Id = 4, Name = "Hands" },
            new Category { Id = 5, Name = "Ring" },
            new Category { Id = 6, Name = "Feet" }
        );
        
        modelBuilder.Entity<Equipment>().HasData(
            // Head
            new Equipment { Id = 1, CategoryId = 1, Rarity = "Leather",  Name = "Leather Helmet", Price = 300, Strength = 2, Intelligence = 0, Agility = 1 },
            new Equipment { Id = 2, CategoryId = 1, Rarity = "Iron",  Name = "Iron Helmet", Price = 450, Strength = 5, Intelligence = 0, Agility = 2 },
            new Equipment { Id = 3, CategoryId = 1, Rarity = "Gold",  Name = "Golden Helmet", Price = 700, Strength = 7, Intelligence = 0, Agility = 2 },
            new Equipment { Id = 4, CategoryId = 1, Rarity = "Diamond",  Name = "Diamond Helmet", Price = 1000, Strength = 10, Intelligence = 0, Agility = 3 },
            new Equipment { Id = 5, CategoryId = 1, Rarity = "Mythic",  Name = "Mythic Helmet", Price = 1500, Strength = 15, Intelligence = 2, Agility = 4 },

            // Necklaces
            new Equipment { Id = 6, CategoryId = 2, Rarity = "Leather",  Name = "Leather Necklace", Price = 200, Strength = 1, Intelligence = 1, Agility = 0 },
            new Equipment { Id = 7, CategoryId = 2, Rarity = "Iron",  Name = "Iron Necklace", Price = 400, Strength = 3, Intelligence = 2, Agility = 1 },
            new Equipment { Id = 8, CategoryId = 2, Rarity = "Gold",  Name = "Golden Necklace", Price = 600, Strength = 5, Intelligence = 3, Agility = 1 },
            new Equipment { Id = 9, CategoryId = 2, Rarity = "Diamond",  Name = "Diamond Necklace", Price = 900, Strength = 7, Intelligence = 4, Agility = 2 },
            new Equipment { Id = 10, CategoryId = 2, Rarity = "Mythic",  Name = "Mythic Necklace", Price = 1400, Strength = 10, Intelligence = 5, Agility = 3 },
            
            // Chest
            new Equipment { Id = 11, CategoryId = 3, Rarity = "Leather",  Name = "Leather Chestplate", Price = 350, Strength = 3, Intelligence = 0, Agility = 2 },
            new Equipment { Id = 12, CategoryId = 3, Rarity = "Iron",  Name = "Iron Chestplate", Price = 500, Strength = 6, Intelligence = 0, Agility = 3 },
            new Equipment { Id = 13, CategoryId = 3, Rarity = "Gold",  Name = "Golden Chestplate", Price = 750, Strength = 9, Intelligence = 0, Agility = 3 },
            new Equipment { Id = 14, CategoryId = 3, Rarity = "Diamond",  Name = "Diamond Chestplate", Price = 1200, Strength = 12, Intelligence = 1, Agility = 4 },
            new Equipment { Id = 15, CategoryId = 3, Rarity = "Mythic",  Name = "Mythic Chestplate", Price = 1800, Strength = 18, Intelligence = 3, Agility = 5 },

            // Hands
            new Equipment { Id = 16, CategoryId = 4, Rarity = "Leather",  Name = "Leather Gloves", Price = 200, Strength = 1, Intelligence = 0, Agility = 1 },
            new Equipment { Id = 17, CategoryId = 4, Rarity = "Iron",  Name = "Iron Gloves", Price = 400, Strength = 3, Intelligence = 0, Agility = 2 },
            new Equipment { Id = 18, CategoryId = 4, Rarity = "Gold",  Name = "Golden Gloves", Price = 600, Strength = 5, Intelligence = 0, Agility = 2 },
            new Equipment { Id = 19, CategoryId = 4, Rarity = "Diamond",  Name = "Diamond Gloves", Price = 800, Strength = 7, Intelligence = 0, Agility = 3 },
            new Equipment { Id = 20, CategoryId = 4, Rarity = "Mythic",  Name = "Mythic Gloves", Price = 1200, Strength = 10, Intelligence = 1, Agility = 4 },
                
            // Rings
            new Equipment { Id = 21, CategoryId = 5, Rarity = "Leather",  Name = "Leather Ring", Price = 150, Strength = 1, Intelligence = 1, Agility = 0 },
            new Equipment { Id = 22, CategoryId = 5, Rarity = "Iron",  Name = "Iron Ring", Price = 300, Strength = 2, Intelligence = 2, Agility = 1 },
            new Equipment { Id = 23, CategoryId = 5, Rarity = "Gold",  Name = "Golden Ring", Price = 500, Strength = 4, Intelligence = 3, Agility = 1 },
            new Equipment { Id = 24, CategoryId = 5, Rarity = "Diamond",  Name = "Diamond Ring", Price = 800, Strength = 6, Intelligence = 4, Agility = 2 },
            new Equipment { Id = 25, CategoryId = 5, Rarity = "Mythic",  Name = "Mythic Ring", Price = 1200, Strength = 8, Intelligence = 6, Agility = 3 },
                
            // Boots
            new Equipment { Id = 26, CategoryId = 6, Rarity = "Leather",  Name = "Leather Boots", Price = 250, Strength = 1, Intelligence = 0, Agility = 2 },
            new Equipment { Id = 27, CategoryId = 6, Rarity = "Iron",  Name = "Iron Boots", Price = 450, Strength = 3, Intelligence = 0, Agility = 3 },
            new Equipment { Id = 28, CategoryId = 6, Rarity = "Gold",  Name = "Golden Boots", Price = 650, Strength = 5, Intelligence = 0, Agility = 3 },
            new Equipment { Id = 29, CategoryId = 6, Rarity = "Diamond",  Name = "Diamond Boots", Price = 900, Strength = 7, Intelligence = 1, Agility = 4 },
            new Equipment { Id = 30, CategoryId = 6, Rarity = "Mythic",  Name = "Mythic Boots", Price = 1400, Strength = 10, Intelligence = 2, Agility = 5 }       
        );
    }
}