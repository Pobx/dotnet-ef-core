using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_ef_core.Migrations
{
    public partial class InitializeItemConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Items",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Items",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETUTCDATE()");
        }
    }
}
