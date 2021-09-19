using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Revenue",
                schema: "ecom",
                table: "Product",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TotalOrder",
                schema: "ecom",
                table: "Product",
                type: "real",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Revenue",
                schema: "ecom",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "TotalOrder",
                schema: "ecom",
                table: "Product");
        }
    }
}
