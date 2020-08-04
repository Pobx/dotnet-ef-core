using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_ef_core.Migrations
{
    public partial class InitializePriceForEachItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Item 01", 100.99f });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Item 02", 200.99f });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Item 03", 300.99f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Hamlet", 0f });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "King Lear", 0f });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Othello", 0f });
        }
    }
}
