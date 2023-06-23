using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TakeCtrl.Api.Migrations
{
    /// <inheritdoc />
    public partial class ChangedUsageData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 11,
                column: "IopsWrite",
                value: 890.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 12,
                column: "Percent",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 14,
                column: "MbitIn",
                value: 45789.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 15,
                column: "MbitIn",
                value: 45613.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 16,
                column: "MbitOut",
                value: 5689.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 17,
                column: "MbitOut",
                value: 10241.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 18,
                column: "IopsRead",
                value: 63.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 19,
                column: "IopsRead",
                value: 945.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 20,
                column: "IopsWrite",
                value: 123.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 21,
                column: "IopsWrite",
                value: 280.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 11,
                column: "IopsWrite",
                value: 380.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 12,
                column: "Percent",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 14,
                column: "MbitIn",
                value: 456789.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 15,
                column: "MbitIn",
                value: 456123.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 16,
                column: "MbitOut",
                value: 56894.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 17,
                column: "MbitOut",
                value: 56241.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 18,
                column: "IopsRead",
                value: 653.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 19,
                column: "IopsRead",
                value: 645.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 20,
                column: "IopsWrite",
                value: 423.0);

            migrationBuilder.UpdateData(
                table: "Usages",
                keyColumn: "Id",
                keyValue: 21,
                column: "IopsWrite",
                value: 380.0);
        }
    }
}
