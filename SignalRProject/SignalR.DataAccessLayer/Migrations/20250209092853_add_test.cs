using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class add_test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiningTableID",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_DiningTableID",
                table: "Baskets",
                column: "DiningTableID");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_DiningTables_DiningTableID",
                table: "Baskets",
                column: "DiningTableID",
                principalTable: "DiningTables",
                principalColumn: "DiningTableID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_DiningTables_DiningTableID",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_DiningTableID",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "DiningTableID",
                table: "Baskets");
        }
    }
}
