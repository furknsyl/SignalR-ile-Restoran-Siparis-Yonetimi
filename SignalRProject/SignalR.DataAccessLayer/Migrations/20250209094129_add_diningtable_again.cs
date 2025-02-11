using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class add_diningtable_again : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_DiningTables_DiningTableID",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Tables_TableID",
                table: "Baskets");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_TableID",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "TableID",
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
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TableID",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    TableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.TableID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_TableID",
                table: "Baskets",
                column: "TableID");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_DiningTables_DiningTableID",
                table: "Baskets",
                column: "DiningTableID",
                principalTable: "DiningTables",
                principalColumn: "DiningTableID");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Tables_TableID",
                table: "Baskets",
                column: "TableID",
                principalTable: "Tables",
                principalColumn: "TableID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
