using Microsoft.EntityFrameworkCore;

namespace NinjaManager.Data;

public class MainContext : DbContext
{
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
            new Equipment { Id = 1, CategoryId = 1, Name = "Leather Helmet", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 2, CategoryId = 1, Name = "Iron Helmet", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 3, CategoryId = 1, Name = "Golden Helmet", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 4, CategoryId = 1, Name = "Diamond Helmet", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 5, CategoryId = 1, Name = "Mythic Helmet", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },

            // Necklaces
            new Equipment { Id = 6, CategoryId = 2, Name = "Leather Necklace", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 7, CategoryId = 2, Name = "Iron Necklace", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 8, CategoryId = 2, Name = "Golden Necklace", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 9, CategoryId = 2, Name = "Diamond Necklace", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 10, CategoryId = 2, Name = "Mythic Necklace", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            
            // Chest
            new Equipment { Id = 11, CategoryId = 3, Name = "Leather Chestplate", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 12, CategoryId = 3, Name = "Iron Chestplate", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 13, CategoryId = 3, Name = "Golden Chestplate", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 14, CategoryId = 3, Name = "Diamond Chestplate", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 15, CategoryId = 3, Name = "Mythic Chestplate", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },

            // Hands
            new Equipment { Id = 16, CategoryId = 4, Name = "Leather Gloves", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 17, CategoryId = 4, Name = "Iron Gloves", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 18, CategoryId = 4, Name = "Golden Gloves", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 19, CategoryId = 4, Name = "Diamond Gloves", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 20, CategoryId = 4, Name = "Mythic Gloves", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
                
            // Rings
            new Equipment { Id = 21, CategoryId = 5, Name = "Leather Ring", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 22, CategoryId = 5, Name = "Iron Ring", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 23, CategoryId = 5, Name = "Golden Ring", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 24, CategoryId = 5, Name = "Diamond Ring", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 25, CategoryId = 5, Name = "Mythic Ring", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
                
            // Boots
            new Equipment { Id = 26, CategoryId = 6, Name = "Leather Boots", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 27, CategoryId = 6, Name = "Iron Boots", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 28, CategoryId = 6, Name = "Golden Boots", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 29, CategoryId = 6, Name = "Diamond Boots", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 30, CategoryId = 6, Name = "Mythic Boots", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 }
        );
    }
}