using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineGroceryLK.Data.Migrations
{
    public partial class AddProductsToDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Product");
        }
    }
}
