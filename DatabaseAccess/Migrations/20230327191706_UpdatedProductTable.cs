using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseAccess.Migrations
{
    public partial class UpdatedProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 17, 5, 629, DateTimeKind.Local).AddTicks(6969), new DateTime(2023, 3, 28, 0, 17, 5, 629, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 17, 5, 629, DateTimeKind.Local).AddTicks(7727), new DateTime(2023, 3, 28, 0, 17, 5, 629, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 17, 5, 626, DateTimeKind.Local).AddTicks(7707), new DateTime(2023, 3, 28, 0, 17, 5, 628, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 17, 5, 628, DateTimeKind.Local).AddTicks(1033), new DateTime(2023, 3, 28, 0, 17, 5, 628, DateTimeKind.Local).AddTicks(1051) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 27, 23, 53, 42, 973, DateTimeKind.Local).AddTicks(9825), new DateTime(2023, 3, 27, 23, 53, 42, 974, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 27, 23, 53, 42, 974, DateTimeKind.Local).AddTicks(704), new DateTime(2023, 3, 27, 23, 53, 42, 974, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 27, 23, 53, 42, 970, DateTimeKind.Local).AddTicks(9832), new DateTime(2023, 3, 27, 23, 53, 42, 972, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 27, 23, 53, 42, 972, DateTimeKind.Local).AddTicks(2482), new DateTime(2023, 3, 27, 23, 53, 42, 972, DateTimeKind.Local).AddTicks(2498) });
        }
    }
}
