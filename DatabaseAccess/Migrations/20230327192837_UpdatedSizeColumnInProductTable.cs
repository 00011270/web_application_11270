using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseAccess.Migrations
{
    public partial class UpdatedSizeColumnInProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Size",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 28, 36, 594, DateTimeKind.Local).AddTicks(2841), "M", new DateTime(2023, 3, 28, 0, 28, 36, 594, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 28, 36, 594, DateTimeKind.Local).AddTicks(3665), "M", new DateTime(2023, 3, 28, 0, 28, 36, 594, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 28, 36, 591, DateTimeKind.Local).AddTicks(6151), new DateTime(2023, 3, 28, 0, 28, 36, 592, DateTimeKind.Local).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 28, 36, 592, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 3, 28, 0, 28, 36, 592, DateTimeKind.Local).AddTicks(8119) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 24, 13, 699, DateTimeKind.Local).AddTicks(8750), 1, new DateTime(2023, 3, 28, 0, 24, 13, 699, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 24, 13, 699, DateTimeKind.Local).AddTicks(9562), 1, new DateTime(2023, 3, 28, 0, 24, 13, 699, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 24, 13, 696, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 3, 28, 0, 24, 13, 697, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 24, 13, 697, DateTimeKind.Local).AddTicks(7608), new DateTime(2023, 3, 28, 0, 24, 13, 697, DateTimeKind.Local).AddTicks(7622) });
        }
    }
}
