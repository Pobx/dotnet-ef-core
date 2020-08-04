using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_ef_core.Migrations
{
    public partial class AddFullyDefinedRelationToItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Items",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "UpdatedDateTime" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Name", "OrderId", "Price", "UpdatedDateTime" },
                values: new object[] { 1, "Hamlet", 1, 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Name", "OrderId", "Price", "UpdatedDateTime" },
                values: new object[] { 2, "King Lear", 1, 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Name", "OrderId", "Price", "UpdatedDateTime" },
                values: new object[] { 3, "Othello", 1, 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Items",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
