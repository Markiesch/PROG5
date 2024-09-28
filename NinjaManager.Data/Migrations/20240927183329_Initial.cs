using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NinjaManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ninjas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ninjas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Rarity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agility = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentNinja",
                columns: table => new
                {
                    EquipmentsId = table.Column<int>(type: "int", nullable: false),
                    NinjasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentNinja", x => new { x.EquipmentsId, x.NinjasId });
                    table.ForeignKey(
                        name: "FK_EquipmentNinja_Equipments_EquipmentsId",
                        column: x => x.EquipmentsId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentNinja_Ninjas_NinjasId",
                        column: x => x.NinjasId,
                        principalTable: "Ninjas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Head" },
                    { 2, "Necklace" },
                    { 3, "Chest" },
                    { 4, "Hands" },
                    { 5, "Ring" },
                    { 6, "Feet" }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Agility", "CategoryId", "Img", "Intelligence", "Name", "Price", "Rarity", "Strength" },
                values: new object[,]
                {
                    { 1, 1, 1, "helmet_01a", 0, "Leather Helmet", 300, "Leather", 2 },
                    { 2, 2, 1, "helmet_01b", 0, "Iron Helmet", 450, "Iron", 5 },
                    { 3, 2, 1, "helmet_01c", 0, "Golden Helmet", 700, "Gold", 7 },
                    { 4, 3, 1, "helmet_01d", 0, "Diamond Helmet", 1000, "Diamond", 10 },
                    { 5, 4, 1, "helmet_01e", 2, "Mythic Helmet", 1500, "Mythic", 15 },
                    { 6, 0, 2, "necklace_03a", 1, "Leather Necklace", 200, "Leather", 1 },
                    { 7, 1, 2, "necklace_03b", 2, "Iron Necklace", 400, "Iron", 3 },
                    { 8, 1, 2, "necklace_03c", 3, "Golden Necklace", 600, "Gold", 5 },
                    { 9, 2, 2, "necklace_03d", 4, "Diamond Necklace", 900, "Diamond", 7 },
                    { 10, 3, 2, "necklace_03e", 5, "Mythic Necklace", 1400, "Mythic", 10 },
                    { 11, 2, 3, "armor_01a", 0, "Leather Chestplate", 350, "Leather", 3 },
                    { 12, 3, 3, "armor_01b", 0, "Iron Chestplate", 500, "Iron", 6 },
                    { 13, 3, 3, "armor_01c", 0, "Golden Chestplate", 750, "Gold", 9 },
                    { 14, 4, 3, "armor_01d", 1, "Diamond Chestplate", 1200, "Diamond", 12 },
                    { 15, 5, 3, "armor_01e", 3, "Mythic Chestplate", 1800, "Mythic", 18 },
                    { 16, 1, 4, "gloves_01a", 0, "Leather Gloves", 200, "Leather", 1 },
                    { 17, 2, 4, "gloves_01b", 0, "Iron Gloves", 400, "Iron", 3 },
                    { 18, 2, 4, "gloves_01c", 0, "Golden Gloves", 600, "Gold", 5 },
                    { 19, 3, 4, "gloves_01d", 0, "Diamond Gloves", 800, "Diamond", 7 },
                    { 20, 4, 4, "gloves_01e", 1, "Mythic Gloves", 1200, "Mythic", 10 },
                    { 21, 0, 5, "ring_01a", 1, "Leather Ring", 150, "Leather", 1 },
                    { 22, 1, 5, "ring_01b", 2, "Iron Ring", 300, "Iron", 2 },
                    { 23, 1, 5, "ring_01c", 3, "Golden Ring", 500, "Gold", 4 },
                    { 24, 2, 5, "ring_01d", 4, "Diamond Ring", 800, "Diamond", 6 },
                    { 25, 3, 5, "ring_01e", 6, "Mythic Ring", 1200, "Mythic", 8 },
                    { 26, 2, 6, "boots_01a", 0, "Leather Boots", 250, "Leather", 1 },
                    { 27, 3, 6, "boots_01b", 0, "Iron Boots", 450, "Iron", 3 },
                    { 28, 3, 6, "boots_01c", 0, "Golden Boots", 650, "Gold", 5 },
                    { 29, 4, 6, "boots_01d", 1, "Diamond Boots", 900, "Diamond", 7 },
                    { 30, 5, 6, "boots_01e", 2, "Mythic Boots", 1400, "Mythic", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentNinja_NinjasId",
                table: "EquipmentNinja",
                column: "NinjasId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_CategoryId",
                table: "Equipments",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentNinja");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Ninjas");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
