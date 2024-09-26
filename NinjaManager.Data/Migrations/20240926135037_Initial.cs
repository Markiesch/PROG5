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
                columns: new[] { "Id", "Agility", "CategoryId", "Img", "Intelligence", "Name", "Price", "Strength" },
                values: new object[,]
                {
                    { 1, 0, 1, "helmet_01a", 0, "Leather Helmet", 300, 0 },
                    { 2, 0, 1, "helmet_01b", 0, "Iron Helmet", 300, 0 },
                    { 3, 0, 1, "helmet_01c", 0, "Golden Helmet", 300, 0 },
                    { 4, 0, 1, "helmet_01d", 0, "Diamond Helmet", 300, 0 },
                    { 5, 0, 1, "helmet_01e", 0, "Mythic Helmet", 300, 0 },
                    { 6, 0, 2, "necklace_03a", 0, "Leather Necklace", 300, 0 },
                    { 7, 0, 2, "necklace_03b", 0, "Iron Necklace", 300, 0 },
                    { 8, 0, 2, "necklace_03c", 0, "Golden Necklace", 300, 0 },
                    { 9, 0, 2, "necklace_03d", 0, "Diamond Necklace", 300, 0 },
                    { 10, 0, 2, "necklace_03e", 0, "Mythic Necklace", 300, 0 },
                    { 11, 0, 3, "armor_01a", 0, "Leather Chestplate", 300, 0 },
                    { 12, 0, 3, "armor_01b", 0, "Iron Chestplate", 300, 0 },
                    { 13, 0, 3, "armor_01c", 0, "Golden Chestplate", 300, 0 },
                    { 14, 0, 3, "armor_01d", 0, "Diamond Chestplate", 300, 0 },
                    { 15, 0, 3, "armor_01e", 0, "Mythic Chestplate", 300, 0 },
                    { 16, 0, 4, "gloves_01a", 0, "Leather Gloves", 300, 0 },
                    { 17, 0, 4, "gloves_01b", 0, "Iron Gloves", 300, 0 },
                    { 18, 0, 4, "gloves_01c", 0, "Golden Gloves", 300, 0 },
                    { 19, 0, 4, "gloves_01d", 0, "Diamond Gloves", 300, 0 },
                    { 20, 0, 4, "gloves_01e", 0, "Mythic Gloves", 300, 0 },
                    { 21, 0, 5, "ring_01a", 0, "Leather Ring", 300, 0 },
                    { 22, 0, 5, "ring_01b", 0, "Iron Ring", 300, 0 },
                    { 23, 0, 5, "ring_01c", 0, "Golden Ring", 300, 0 },
                    { 24, 0, 5, "ring_01d", 0, "Diamond Ring", 300, 0 },
                    { 25, 0, 5, "ring_01e", 0, "Mythic Ring", 300, 0 },
                    { 26, 0, 6, "boots_01a", 0, "Leather Boots", 300, 0 },
                    { 27, 0, 6, "boots_01b", 0, "Iron Boots", 300, 0 },
                    { 28, 0, 6, "boots_01c", 0, "Golden Boots", 300, 0 },
                    { 29, 0, 6, "boots_01d", 0, "Diamond Boots", 300, 0 },
                    { 30, 0, 6, "boots_01e", 0, "Mythic Boots", 300, 0 }
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
