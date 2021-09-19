using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_49 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                schema: "ecom",
                table: "Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                schema: "ecom",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
