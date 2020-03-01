using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace avtopark.Migrations
{
    public partial class Db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Model = table.Column<string>(maxLength: 30, nullable: false),
                    Color = table.Column<string>(maxLength: 10, nullable: false),
                    YearMaking = table.Column<DateTime>(nullable: true),
                    PriceNaem = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    CarOnLoan = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Family = table.Column<string>(nullable: false),
                    Idcard = table.Column<int>(maxLength: 40, nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Creditcard = table.Column<string>(nullable: false),
                    Boughtin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.CarOnLoan);
                    table.ForeignKey(
                        name: "FK_Clients_Cars_CarOnLoan",
                        column: x => x.CarOnLoan,
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
