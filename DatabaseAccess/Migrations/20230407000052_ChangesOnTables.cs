using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseAccess.Migrations
{
    public partial class ChangesOnTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Users_UserId",
                table: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_UserId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OrderDetails");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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
                columns: new[] { "CreatedAt", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 3, 30, 16, 55, 42, 369, DateTimeKind.Local).AddTicks(9053), "agagagd", new DateTime(2023, 3, 30, 16, 55, 42, 369, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_UserId",
                table: "OrderDetails",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Users_UserId",
                table: "OrderDetails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
