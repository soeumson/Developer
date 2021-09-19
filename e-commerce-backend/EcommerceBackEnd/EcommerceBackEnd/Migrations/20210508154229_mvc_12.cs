using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: false,
                filter: "[NormalizedName] IS NOT NULL");
        }
    }
}
