using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingWebApi.Migrations
{
    public partial class creditcardadditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Intrest = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    intrestowed = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreditCards");
        }
    }
}
