using Microsoft.EntityFrameworkCore.Migrations;

namespace Katalogna_targovia.Migrations
{
    public partial class KatDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Egn = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: false),
                    Tel = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Egn);
                });

            migrationBuilder.CreateTable(
                name: "Distributors",
                columns: table => new
                {
                    DistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Tel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributors", x => x.DistId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduct = table.Column<string>(maxLength: 30, nullable: false),
                    CuantityProduct = table.Column<int>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    KlientId = table.Column<string>(nullable: false),
                    DistributorId = table.Column<int>(nullable: false),
                    DistributorId0 = table.Column<int>(name: " DistributorId", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Number);
                    table.ForeignKey(
                        name: "FK_Products_Distributors_ DistributorId",
                        column: x => x.DistributorId0,
                        principalTable: "Distributors",
                        principalColumn: "DistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Clients_KlientId",
                        column: x => x.KlientId,
                        principalTable: "Clients",
                        principalColumn: "Egn",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ DistributorId",
                table: "Products",
                column: " DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_KlientId",
                table: "Products",
                column: "KlientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Distributors");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
