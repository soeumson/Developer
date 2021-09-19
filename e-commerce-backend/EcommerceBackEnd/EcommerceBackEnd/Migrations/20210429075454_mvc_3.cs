using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserAppMenuID",
                schema: "ecom",
                table: "UserAppMenu",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "MenuId",
                schema: "ecom",
                table: "AppMenu",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserAppMenuID",
                schema: "ecom",
                table: "UserAppMenu",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<string>(
                name: "MenuId",
                schema: "ecom",
                table: "AppMenu",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldDefaultValueSql: "NEWID()");
        }
    }
}
