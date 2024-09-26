using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NinjaManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class EquipmentConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Agility", "Strength" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 2, 450, 5 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 2, 700, 7 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 3, 1000, 10 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 4, 2, 1500, 15 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Intelligence", "Price", "Strength" },
                values: new object[] { 1, 200, 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 1, 2, 400, 3 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 1, 3, 600, 5 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 2, 4, 900, 7 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 3, 5, 1400, 10 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 2, 350, 3 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 3, 500, 6 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 3, 750, 9 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 4, 1, 1200, 12 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 5, 3, 1800, 18 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 1, 200, 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 2, 400, 3 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 2, 600, 5 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 3, 800, 7 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 4, 1, 1200, 10 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Intelligence", "Price", "Strength" },
                values: new object[] { 1, 150, 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Agility", "Intelligence", "Strength" },
                values: new object[] { 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 1, 3, 500, 4 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 2, 4, 800, 6 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 3, 6, 1200, 8 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 2, 250, 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 3, 450, 3 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 3, 650, 5 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 4, 1, 900, 7 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 5, 2, 1400, 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Agility", "Strength" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Agility", "Intelligence", "Strength" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Agility", "Price", "Strength" },
                values: new object[] { 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Agility", "Intelligence", "Price", "Strength" },
                values: new object[] { 0, 0, 300, 0 });
        }
    }
}
