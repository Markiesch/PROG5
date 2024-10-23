using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NinjaManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class NinjaEquipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentNinja");

            migrationBuilder.CreateTable(
                name: "NinjaEquipments",
                columns: table => new
                {
                    NinjaId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    BuyPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NinjaEquipments", x => new { x.NinjaId, x.EquipmentId });
                    table.ForeignKey(
                        name: "FK_NinjaEquipments_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NinjaEquipments_Ninjas_NinjaId",
                        column: x => x.NinjaId,
                        principalTable: "Ninjas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NinjaEquipments_EquipmentId",
                table: "NinjaEquipments",
                column: "EquipmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NinjaEquipments");

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

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentNinja_NinjasId",
                table: "EquipmentNinja",
                column: "NinjasId");
        }
    }
}
