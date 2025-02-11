using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class add_tabletable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_DiningTables_DiningTableID",
                table: "Baskets");

            migrationBuilder.AlterColumn<int>(
                name: "DiningTableID",
                table: "Baskets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_DiningTables_DiningTableID",
                table: "Baskets",
                column: "DiningTableID",
                principalTable: "DiningTables",
                principalColumn: "DiningTableID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_DiningTables_DiningTableID",
                table: "Baskets");

            migrationBuilder.AlterColumn<int>(
                name: "DiningTableID",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_DiningTables_DiningTableID",
                table: "Baskets",
                column: "DiningTableID",
                principalTable: "DiningTables",
                principalColumn: "DiningTableID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
