﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NinjaManager.Data;

#nullable disable

namespace NinjaManager.Data.Migrations
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NinjaManager.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Head"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Necklace"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chest"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hands"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ring"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Feet"
                        });
                });

            modelBuilder.Entity("NinjaManager.Data.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Agility")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Rarity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Equipments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Agility = 1,
                            CategoryId = 1,
                            Intelligence = 0,
                            Name = "Leather Helmet",
                            Price = 300,
                            Rarity = "Leather",
                            Strength = 2
                        },
                        new
                        {
                            Id = 2,
                            Agility = 2,
                            CategoryId = 1,
                            Intelligence = 0,
                            Name = "Iron Helmet",
                            Price = 450,
                            Rarity = "Iron",
                            Strength = 5
                        },
                        new
                        {
                            Id = 3,
                            Agility = 2,
                            CategoryId = 1,
                            Intelligence = 0,
                            Name = "Golden Helmet",
                            Price = 700,
                            Rarity = "Gold",
                            Strength = 7
                        },
                        new
                        {
                            Id = 4,
                            Agility = 3,
                            CategoryId = 1,
                            Intelligence = 0,
                            Name = "Diamond Helmet",
                            Price = 1000,
                            Rarity = "Diamond",
                            Strength = 10
                        },
                        new
                        {
                            Id = 5,
                            Agility = 4,
                            CategoryId = 1,
                            Intelligence = 2,
                            Name = "Mythic Helmet",
                            Price = 1500,
                            Rarity = "Mythic",
                            Strength = 15
                        },
                        new
                        {
                            Id = 6,
                            Agility = 0,
                            CategoryId = 2,
                            Intelligence = 1,
                            Name = "Leather Necklace",
                            Price = 200,
                            Rarity = "Leather",
                            Strength = 1
                        },
                        new
                        {
                            Id = 7,
                            Agility = 1,
                            CategoryId = 2,
                            Intelligence = 2,
                            Name = "Iron Necklace",
                            Price = 400,
                            Rarity = "Iron",
                            Strength = 3
                        },
                        new
                        {
                            Id = 8,
                            Agility = 1,
                            CategoryId = 2,
                            Intelligence = 3,
                            Name = "Golden Necklace",
                            Price = 600,
                            Rarity = "Gold",
                            Strength = 5
                        },
                        new
                        {
                            Id = 9,
                            Agility = 2,
                            CategoryId = 2,
                            Intelligence = 4,
                            Name = "Diamond Necklace",
                            Price = 900,
                            Rarity = "Diamond",
                            Strength = 7
                        },
                        new
                        {
                            Id = 10,
                            Agility = 3,
                            CategoryId = 2,
                            Intelligence = 5,
                            Name = "Mythic Necklace",
                            Price = 1400,
                            Rarity = "Mythic",
                            Strength = 10
                        },
                        new
                        {
                            Id = 11,
                            Agility = 2,
                            CategoryId = 3,
                            Intelligence = 0,
                            Name = "Leather Chestplate",
                            Price = 350,
                            Rarity = "Leather",
                            Strength = 3
                        },
                        new
                        {
                            Id = 12,
                            Agility = 3,
                            CategoryId = 3,
                            Intelligence = 0,
                            Name = "Iron Chestplate",
                            Price = 500,
                            Rarity = "Iron",
                            Strength = 6
                        },
                        new
                        {
                            Id = 13,
                            Agility = 3,
                            CategoryId = 3,
                            Intelligence = 0,
                            Name = "Golden Chestplate",
                            Price = 750,
                            Rarity = "Gold",
                            Strength = 9
                        },
                        new
                        {
                            Id = 14,
                            Agility = 4,
                            CategoryId = 3,
                            Intelligence = 1,
                            Name = "Diamond Chestplate",
                            Price = 1200,
                            Rarity = "Diamond",
                            Strength = 12
                        },
                        new
                        {
                            Id = 15,
                            Agility = 5,
                            CategoryId = 3,
                            Intelligence = 3,
                            Name = "Mythic Chestplate",
                            Price = 1800,
                            Rarity = "Mythic",
                            Strength = 18
                        },
                        new
                        {
                            Id = 16,
                            Agility = 1,
                            CategoryId = 4,
                            Intelligence = 0,
                            Name = "Leather Gloves",
                            Price = 200,
                            Rarity = "Leather",
                            Strength = 1
                        },
                        new
                        {
                            Id = 17,
                            Agility = 2,
                            CategoryId = 4,
                            Intelligence = 0,
                            Name = "Iron Gloves",
                            Price = 400,
                            Rarity = "Iron",
                            Strength = 3
                        },
                        new
                        {
                            Id = 18,
                            Agility = 2,
                            CategoryId = 4,
                            Intelligence = 0,
                            Name = "Golden Gloves",
                            Price = 600,
                            Rarity = "Gold",
                            Strength = 5
                        },
                        new
                        {
                            Id = 19,
                            Agility = 3,
                            CategoryId = 4,
                            Intelligence = 0,
                            Name = "Diamond Gloves",
                            Price = 800,
                            Rarity = "Diamond",
                            Strength = 7
                        },
                        new
                        {
                            Id = 20,
                            Agility = 4,
                            CategoryId = 4,
                            Intelligence = 1,
                            Name = "Mythic Gloves",
                            Price = 1200,
                            Rarity = "Mythic",
                            Strength = 10
                        },
                        new
                        {
                            Id = 21,
                            Agility = 0,
                            CategoryId = 5,
                            Intelligence = 1,
                            Name = "Leather Ring",
                            Price = 150,
                            Rarity = "Leather",
                            Strength = 1
                        },
                        new
                        {
                            Id = 22,
                            Agility = 1,
                            CategoryId = 5,
                            Intelligence = 2,
                            Name = "Iron Ring",
                            Price = 300,
                            Rarity = "Iron",
                            Strength = 2
                        },
                        new
                        {
                            Id = 23,
                            Agility = 1,
                            CategoryId = 5,
                            Intelligence = 3,
                            Name = "Golden Ring",
                            Price = 500,
                            Rarity = "Gold",
                            Strength = 4
                        },
                        new
                        {
                            Id = 24,
                            Agility = 2,
                            CategoryId = 5,
                            Intelligence = 4,
                            Name = "Diamond Ring",
                            Price = 800,
                            Rarity = "Diamond",
                            Strength = 6
                        },
                        new
                        {
                            Id = 25,
                            Agility = 3,
                            CategoryId = 5,
                            Intelligence = 6,
                            Name = "Mythic Ring",
                            Price = 1200,
                            Rarity = "Mythic",
                            Strength = 8
                        },
                        new
                        {
                            Id = 26,
                            Agility = 2,
                            CategoryId = 6,
                            Intelligence = 0,
                            Name = "Leather Boots",
                            Price = 250,
                            Rarity = "Leather",
                            Strength = 1
                        },
                        new
                        {
                            Id = 27,
                            Agility = 3,
                            CategoryId = 6,
                            Intelligence = 0,
                            Name = "Iron Boots",
                            Price = 450,
                            Rarity = "Iron",
                            Strength = 3
                        },
                        new
                        {
                            Id = 28,
                            Agility = 3,
                            CategoryId = 6,
                            Intelligence = 0,
                            Name = "Golden Boots",
                            Price = 650,
                            Rarity = "Gold",
                            Strength = 5
                        },
                        new
                        {
                            Id = 29,
                            Agility = 4,
                            CategoryId = 6,
                            Intelligence = 1,
                            Name = "Diamond Boots",
                            Price = 900,
                            Rarity = "Diamond",
                            Strength = 7
                        },
                        new
                        {
                            Id = 30,
                            Agility = 5,
                            CategoryId = 6,
                            Intelligence = 2,
                            Name = "Mythic Boots",
                            Price = 1400,
                            Rarity = "Mythic",
                            Strength = 10
                        });
                });

            modelBuilder.Entity("NinjaManager.Data.Models.Ninja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ninjas");
                });

            modelBuilder.Entity("NinjaManager.Data.Models.NinjaEquipment", b =>
                {
                    b.Property<int>("NinjaId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("BuyPrice")
                        .HasColumnType("int");

                    b.HasKey("NinjaId", "EquipmentId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("NinjaEquipments");
                });

            modelBuilder.Entity("NinjaManager.Data.Models.Equipment", b =>
                {
                    b.HasOne("NinjaManager.Data.Models.Category", "Category")
                        .WithMany("Equipments")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NinjaManager.Data.Models.NinjaEquipment", b =>
                {
                    b.HasOne("NinjaManager.Data.Models.Equipment", "Equipment")
                        .WithMany("NinjaEquipments")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NinjaManager.Data.Models.Ninja", "Ninja")
                        .WithMany("NinjaEquipments")
                        .HasForeignKey("NinjaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("Ninja");
                });

            modelBuilder.Entity("NinjaManager.Data.Models.Category", b =>
                {
                    b.Navigation("Equipments");
                });

            modelBuilder.Entity("NinjaManager.Data.Models.Equipment", b =>
                {
                    b.Navigation("NinjaEquipments");
                });

            modelBuilder.Entity("NinjaManager.Data.Models.Ninja", b =>
                {
                    b.Navigation("NinjaEquipments");
                });
#pragma warning restore 612, 618
        }
    }
}
