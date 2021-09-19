using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_42 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KhmerDescription",
                table: "MainMenu");

            migrationBuilder.AddColumn<string>(
                name: "MainMenuId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainMenuId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "KhmerDescription",
                table: "MainMenu",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
