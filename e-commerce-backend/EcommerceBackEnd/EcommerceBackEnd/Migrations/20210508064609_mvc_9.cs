using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAppMenu",
                schema: "ecom");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAppMenu",
                schema: "ecom",
                columns: table => new
                {
                    UserAppMenuID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "NEWID()"),
                    AccessRight = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MenuID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAppMenu", x => x.UserAppMenuID);
                });
        }
    }
}
