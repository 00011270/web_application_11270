using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseAccess.Migrations
{
    public partial class RemovereviewsOnProductDeletion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Product_ProductId",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 7, 20, 31, 15, 612, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 4, 7, 20, 31, 15, 612, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 7, 20, 31, 15, 612, DateTimeKind.Local).AddTicks(9907), new DateTime(2023, 4, 7, 20, 31, 15, 612, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 7, 20, 31, 15, 609, DateTimeKind.Local).AddTicks(6926), new DateTime(2023, 4, 7, 20, 31, 15, 610, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 7, 20, 31, 15, 611, DateTimeKind.Local).AddTicks(147), new DateTime(2023, 4, 7, 20, 31, 15, 611, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 7, 20, 31, 15, 613, DateTimeKind.Local).AddTicks(1207), new DateTime(2023, 4, 7, 20, 31, 15, 613, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Product_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Product_ProductId",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 7, 5, 0, 51, 848, DateTimeKind.Local).AddTicks(7281), new DateTime(2023, 4, 7, 5, 0, 51, 848, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 7, 5, 0, 51, 848, DateTimeKind.Local).AddTicks(8095), new DateTime(2023, 4, 7, 5, 0, 51, 848, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 7, 5, 0, 51, 845, DateTimeKind.Local).AddTicks(5315), new DateTime(2023, 4, 7, 5, 0, 51, 846, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 7, 5, 0, 51, 846, DateTimeKind.Local).AddTicks(9945), new DateTime(2023, 4, 7, 5, 0, 51, 846, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 7, 5, 0, 51, 848, DateTimeKind.Local).AddTicks(9677), new DateTime(2023, 4, 7, 5, 0, 51, 848, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Product_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
