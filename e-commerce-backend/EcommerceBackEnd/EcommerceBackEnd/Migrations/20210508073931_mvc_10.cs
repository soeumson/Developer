using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyID",
                table: "AspNetRoles",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "AspNetRoles",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreateDate",
                table: "AspNetRoles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "AspNetRoles",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateDate",
                table: "AspNetRoles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AspNetRoles");
        }
    }
}
