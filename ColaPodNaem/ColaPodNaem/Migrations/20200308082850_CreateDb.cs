using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ColaPodNaem.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Model = table.Column<string>(maxLength: 30, nullable: false),
                    Color = table.Column<string>(maxLength: 20, nullable: true),
                    YearMaking = table.Column<DateTime>(nullable: false),
                    PriceNaem = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Kola = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Family = table.Column<string>(maxLength: 50, nullable: false),
                    LichnaKarta = table.Column<int>(nullable: false),
                    Adress = table.Column<string>(maxLength: 100, nullable: true),
                    CreditCard = table.Column<string>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Kola);
                    table.ForeignKey(
                        name: "FK_Clients_Cars_Kola",
                        column: x => x.Kola,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
