using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TakeCtrl.Api.Migrations
{
    /// <inheritdoc />
    public partial class UsageCPUDataForTesting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "percent",
                table: "Usages",
                newName: "Percent");

            migrationBuilder.RenameColumn(
                name: "mbitOut",
                table: "Usages",
                newName: "MbitOut");

            migrationBuilder.RenameColumn(
                name: "mbitIn",
                table: "Usages",
                newName: "MbitIn");

            migrationBuilder.RenameColumn(
                name: "isEnabled",
                table: "Firewalls",
                newName: "IsEnabled");

            migrationBuilder.InsertData(
                table: "Usages",
                columns: new[] { "Id", "Date", "IopsRead", "IopsWrite", "MbitIn", "MbitOut", "Percent", "Type", "UUID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 20.0, "CPU", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 2, new DateTime(2023, 6, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 40.0, "CPU", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 3, new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 80.0, "CPU", "eb6c28c2-f618-11ed-b67e-0242ac120002" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Percent",
                table: "Usages",
                newName: "percent");

            migrationBuilder.RenameColumn(
                name: "MbitOut",
                table: "Usages",
                newName: "mbitOut");

            migrationBuilder.RenameColumn(
                name: "MbitIn",
                table: "Usages",
                newName: "mbitIn");

            migrationBuilder.RenameColumn(
                name: "IsEnabled",
                table: "Firewalls",
                newName: "isEnabled");
        }
    }
}
