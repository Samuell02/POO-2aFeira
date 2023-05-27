using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula12_ef_test.Migrations
{
    /// <inheritdoc />
    public partial class Nomdededededed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "supplierId",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "People",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    phoneNumber = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_supplierId",
                table: "Products",
                column: "supplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_supplierId",
                table: "Products",
                column: "supplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_supplierId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Products_supplierId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "supplierId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "People");
        }
    }
}
