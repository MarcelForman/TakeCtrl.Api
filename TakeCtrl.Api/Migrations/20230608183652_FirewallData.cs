using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TakeCtrl.Api.Migrations
{
    /// <inheritdoc />
    public partial class FirewallData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Firewalls",
                columns: new[] { "Id", "Description", "EndPort", "Protocol", "StartPort", "UUID", "isEnabled" },
                values: new object[,]
                {
                    { 1, "RDP", 3389, "tcp", 3389, "eb6c28c2-f618-11ed-b67e-0242ac120002", true },
                    { 2, "FTP", 21, "tcp", 21, "eb6c28c2-f618-11ed-b67e-0242ac120002", false },
                    { 3, "SSL", 22, "tcp", 22, "878859d6-f616-11ed-b67e-0242ac120002", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Firewalls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Firewalls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Firewalls",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
