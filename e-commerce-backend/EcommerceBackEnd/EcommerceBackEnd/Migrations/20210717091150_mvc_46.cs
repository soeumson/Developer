using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_46 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LockupMenus",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LockupOptions",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "LookupMenus",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhmerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LookupOptions",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhmerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupOptions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LookupMenus",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LookupOptions",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "LockupMenus",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhmerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LockupMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LockupOptions",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhmerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LockupOptions", x => x.Id);
                });
        }
    }
}
