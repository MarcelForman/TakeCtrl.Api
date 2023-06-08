using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TakeCtrl.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    UUID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUAmount = table.Column<int>(type: "int", nullable: false),
                    DiskSize = table.Column<int>(type: "int", nullable: false),
                    MemorySize = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.UUID);
                });

            migrationBuilder.CreateTable(
                name: "Usages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UUID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    percent = table.Column<double>(type: "float", nullable: true),
                    IopsRead = table.Column<double>(type: "float", nullable: true),
                    IopsWrite = table.Column<double>(type: "float", nullable: true),
                    mbitOut = table.Column<double>(type: "float", nullable: true),
                    mbitIn = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "UUID", "CPUAmount", "DiskSize", "IPAddress", "MemorySize", "Name", "Status" },
                values: new object[,]
                {
                    { "081b833e-f617-11ed-b67e-0242ac120002", 6, 136464745, "56.84.125.213", 3456789, "VPS-2", "running" },
                    { "111d37ca-f617-11ed-b67e-0242ac120002", 6, 136464745, "56.84.125.214", 3456789, "VPS-3", "running" },
                    { "878859d6-f616-11ed-b67e-0242ac120002", 6, 136464745, "56.84.125.212", 3456789, "VPS-1", "running" },
                    { "eb6c28c2-f618-11ed-b67e-0242ac120002", 6, 136464745, "56.84.125.215", 3456789, "VPS-4", "running" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "Usages");
        }
    }
}
