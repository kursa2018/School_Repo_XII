using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StokiPoKatalog.Migrations
{
    public partial class bdCatalogCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Egn = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Adress = table.Column<string>(maxLength: 60, nullable: false),
                    Tel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Egn);
                });

            migrationBuilder.CreateTable(
                name: "Distributors",
                columns: table => new
                {
                    DistrId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    TelContact = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributors", x => x.DistrId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Clients = table.Column<string>(nullable: false),
                    Distributors = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Naimenovanie = table.Column<string>(maxLength: 40, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => new { x.Clients, x.Distributors });
                    table.ForeignKey(
                        name: "FK_Products_Clients_Clients",
                        column: x => x.Clients,
                        principalTable: "Clients",
                        principalColumn: "Egn",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Distributors_Distributors",
                        column: x => x.Distributors,
                        principalTable: "Distributors",
                        principalColumn: "DistrId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Distributors",
                table: "Products",
                column: "Distributors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Distributors");
        }
    }
}
