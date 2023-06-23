using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TakeCtrl.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddedExtraUsageData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usages",
                columns: new[] { "Id", "Date", "IopsRead", "IopsWrite", "MbitIn", "MbitOut", "Percent", "Type", "UUID" },
                values: new object[,]
                {
                    { 12, new DateTime(2023, 6, 4, 10, 15, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 40.0, "CPU", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 13, new DateTime(2023, 6, 8, 10, 20, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 80.0, "CPU", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 14, new DateTime(2023, 6, 8, 10, 20, 0, 0, DateTimeKind.Unspecified), null, null, 456789.0, null, null, "Network", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 15, new DateTime(2023, 6, 8, 10, 20, 0, 0, DateTimeKind.Unspecified), null, null, 456123.0, null, null, "Network", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 16, new DateTime(2023, 6, 8, 10, 20, 0, 0, DateTimeKind.Unspecified), null, null, null, 56894.0, null, "Network", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 17, new DateTime(2023, 6, 8, 10, 20, 0, 0, DateTimeKind.Unspecified), null, null, null, 56241.0, null, "Network", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 18, new DateTime(2023, 6, 8, 10, 20, 0, 0, DateTimeKind.Unspecified), 653.0, null, null, null, null, "Disk", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 19, new DateTime(2023, 6, 8, 10, 20, 0, 0, DateTimeKind.Unspecified), 645.0, null, null, null, null, "Disk", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 20, new DateTime(2023, 6, 8, 10, 20, 0, 0, DateTimeKind.Unspecified), null, 423.0, null, null, null, "Disk", "eb6c28c2-f618-11ed-b67e-0242ac120002" },
                    { 21, new DateTime(2023, 6, 8, 10, 20, 0, 0, DateTimeKind.Unspecified), null, 380.0, null, null, null, "Disk", "eb6c28c2-f618-11ed-b67e-0242ac120002" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 21);
        }
    }
}
