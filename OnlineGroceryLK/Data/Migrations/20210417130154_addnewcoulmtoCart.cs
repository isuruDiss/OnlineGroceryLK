using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineGroceryLK.Data.Migrations
{
    public partial class addnewcoulmtoCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ShoppingCart");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "ShoppingCart",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "ShoppingCart");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
