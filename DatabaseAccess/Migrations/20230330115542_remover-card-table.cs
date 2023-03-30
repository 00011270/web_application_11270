using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseAccess.Migrations
{
    public partial class removercardtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 55, 42, 369, DateTimeKind.Local).AddTicks(6294), new DateTime(2023, 3, 30, 16, 55, 42, 369, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 55, 42, 369, DateTimeKind.Local).AddTicks(7236), new DateTime(2023, 3, 30, 16, 55, 42, 369, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 55, 42, 366, DateTimeKind.Local).AddTicks(8225), new DateTime(2023, 3, 30, 16, 55, 42, 367, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 55, 42, 368, DateTimeKind.Local).AddTicks(415), new DateTime(2023, 3, 30, 16, 55, 42, 368, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 55, 42, 369, DateTimeKind.Local).AddTicks(9053), new DateTime(2023, 3, 30, 16, 55, 42, 369, DateTimeKind.Local).AddTicks(9358) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Balance = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 21, 38, 22, 704, DateTimeKind.Local).AddTicks(8477), new DateTime(2023, 3, 28, 21, 38, 22, 704, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 21, 38, 22, 704, DateTimeKind.Local).AddTicks(9230), new DateTime(2023, 3, 28, 21, 38, 22, 704, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 21, 38, 22, 701, DateTimeKind.Local).AddTicks(8652), new DateTime(2023, 3, 28, 21, 38, 22, 703, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 21, 38, 22, 703, DateTimeKind.Local).AddTicks(1591), new DateTime(2023, 3, 28, 21, 38, 22, 703, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 21, 38, 22, 705, DateTimeKind.Local).AddTicks(1183), new DateTime(2023, 3, 28, 21, 38, 22, 705, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_UserId",
                table: "Cards",
                column: "UserId",
                unique: true);
        }
    }
}
