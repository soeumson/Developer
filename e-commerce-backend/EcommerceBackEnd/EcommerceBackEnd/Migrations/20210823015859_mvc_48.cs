using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_48 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                schema: "ecom",
                table: "Category",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                schema: "ecom",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    TagID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    TagName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.TagID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropColumn(
                name: "Image",
                schema: "ecom",
                table: "Category");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                schema: "ecom",
                table: "Category",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }
    }
}
