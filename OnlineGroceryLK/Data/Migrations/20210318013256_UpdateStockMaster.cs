using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineGroceryLK.Data.Migrations
{
    public partial class UpdateStockMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SupplierId",
                table: "StockMaster",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "StockMaster");
        }
    }
}
