using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TakeCtrl.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedUsageDataDiskNetwork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usages",
                columns: new[] { "Id", "Date", "IopsRead", "IopsWrite", "MbitIn", "MbitOut", "Percent", "Type", "UUID" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), null, null, 456789.0, null, null, "Network", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 5, new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), null, null, 456123.0, null, null, "Network", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 6, new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), null, null, null, 56894.0, null, "Network", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 7, new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), null, null, null, 56241.0, null, "Network", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 8, new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), 653.0, null, null, null, null, "Disk", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 9, new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), 645.0, null, null, null, null, "Disk", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 10, new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), null, 423.0, null, null, null, "Disk", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 11, new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), null, 380.0, null, null, null, "Disk", "eb6c28c2-f618-11ed-b67e-0242ac120002" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
