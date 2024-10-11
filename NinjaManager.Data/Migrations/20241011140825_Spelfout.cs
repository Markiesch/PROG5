using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NinjaManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class Spelfout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Rarity",
                value: "Iron");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Rarity",
                value: "I1`ron");
        }
    }
}
