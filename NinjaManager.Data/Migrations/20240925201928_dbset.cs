using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NinjaManager.Migrations
{
    /// <inheritdoc />
    public partial class dbset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Category_CategoryId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentNinja_Equipment_EquipmentsId",
                table: "EquipmentNinja");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentNinja_Ninja_NinjasId",
                table: "EquipmentNinja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ninja",
                table: "Ninja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Ninja",
                newName: "Ninjas");

            migrationBuilder.RenameTable(
                name: "Equipment",
                newName: "Equipments");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Equipment_CategoryId",
                table: "Equipments",
                newName: "IX_Equipments_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ninjas",
                table: "Ninjas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentNinja_Equipments_EquipmentsId",
                table: "EquipmentNinja",
                column: "EquipmentsId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentNinja_Ninjas_NinjasId",
                table: "EquipmentNinja",
                column: "NinjasId",
                principalTable: "Ninjas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Categories_CategoryId",
                table: "Equipments",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentNinja_Equipments_EquipmentsId",
                table: "EquipmentNinja");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentNinja_Ninjas_NinjasId",
                table: "EquipmentNinja");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Categories_CategoryId",
                table: "Equipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ninjas",
                table: "Ninjas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Ninjas",
                newName: "Ninja");

            migrationBuilder.RenameTable(
                name: "Equipments",
                newName: "Equipment");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Equipments_CategoryId",
                table: "Equipment",
                newName: "IX_Equipment_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ninja",
                table: "Ninja",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Category_CategoryId",
                table: "Equipment",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentNinja_Equipment_EquipmentsId",
                table: "EquipmentNinja",
                column: "EquipmentsId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentNinja_Ninja_NinjasId",
                table: "EquipmentNinja",
                column: "NinjasId",
                principalTable: "Ninja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
