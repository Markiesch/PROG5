using Microsoft.EntityFrameworkCore;

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
            new Equipment { Id = 1, CategoryId = 1, Img = "helmet_01a",  Name = "Leather Helmet", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 2, CategoryId = 1, Img = "helmet_01b",  Name = "Iron Helmet", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 3, CategoryId = 1, Img = "helmet_01c",  Name = "Golden Helmet", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 4, CategoryId = 1, Img = "helmet_01d",  Name = "Diamond Helmet", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 5, CategoryId = 1, Img = "helmet_01e",  Name = "Mythic Helmet", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },

            // Necklaces
            new Equipment { Id = 6, CategoryId = 2, Img = "necklace_03a",  Name = "Leather Necklace", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 7, CategoryId = 2, Img = "necklace_03b",  Name = "Iron Necklace", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 8, CategoryId = 2, Img = "necklace_03c",  Name = "Golden Necklace", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 9, CategoryId = 2, Img = "necklace_03d",  Name = "Diamond Necklace", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 10, CategoryId = 2, Img = "necklace_03e",  Name = "Mythic Necklace", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            
            // Chest
            new Equipment { Id = 11, CategoryId = 3, Img = "armor_01a",  Name = "Leather Chestplate", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 12, CategoryId = 3, Img = "armor_01b",  Name = "Iron Chestplate", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 13, CategoryId = 3, Img = "armor_01c",  Name = "Golden Chestplate", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 14, CategoryId = 3, Img = "armor_01d",  Name = "Diamond Chestplate", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 15, CategoryId = 3, Img = "armor_01e",  Name = "Mythic Chestplate", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },

            // Hands
            new Equipment { Id = 16, CategoryId = 4, Img = "gloves_01a",  Name = "Leather Gloves", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 17, CategoryId = 4, Img = "gloves_01b",  Name = "Iron Gloves", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 18, CategoryId = 4, Img = "gloves_01c",  Name = "Golden Gloves", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 19, CategoryId = 4, Img = "gloves_01d",  Name = "Diamond Gloves", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 20, CategoryId = 4, Img = "gloves_01e",  Name = "Mythic Gloves", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
                
            // Rings
            new Equipment { Id = 21, CategoryId = 5, Img = "ring_01a",  Name = "Leather Ring", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 22, CategoryId = 5, Img = "ring_01b",  Name = "Iron Ring", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 23, CategoryId = 5, Img = "ring_01c",  Name = "Golden Ring", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 24, CategoryId = 5, Img = "ring_01d",  Name = "Diamond Ring", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 25, CategoryId = 5, Img = "ring_01e",  Name = "Mythic Ring", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
                
            // Boots
            new Equipment { Id = 26, CategoryId = 6, Img = "boots_01a",  Name = "Leather Boots", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 27, CategoryId = 6, Img = "boots_01b",  Name = "Iron Boots", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 28, CategoryId = 6, Img = "boots_01c",  Name = "Golden Boots", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 29, CategoryId = 6, Img = "boots_01d",  Name = "Diamond Boots", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 },
            new Equipment { Id = 30, CategoryId = 6, Img = "boots_01e",  Name = "Mythic Boots", Price = 300, Strength = 0, Intelligence = 0, Agility = 0 }
        );
    }
}