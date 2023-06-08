using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TakeCtrl.Api.Migrations
{
    /// <inheritdoc />
    public partial class Firewall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Usages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Firewalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UUID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartPort = table.Column<int>(type: "int", nullable: false),
                    EndPort = table.Column<int>(type: "int", nullable: false),
                    Protocol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firewalls", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Firewalls");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Usages");
        }
    }
}
