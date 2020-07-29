using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_ef_core.Migrations
{
    public partial class AddSaleOneToManyOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalerId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Salers",
                columns: table => new
                {
                    SalerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salers", x => x.SalerId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SalerId",
                table: "Orders",
                column: "SalerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Salers_SalerId",
                table: "Orders",
                column: "SalerId",
                principalTable: "Salers",
                principalColumn: "SalerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Salers_SalerId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Salers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SalerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SalerId",
                table: "Orders");
        }
    }
}
