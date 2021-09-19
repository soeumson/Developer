using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessRight",
                schema: "ecom");

            migrationBuilder.AddColumn<string>(
                name: "AccessRight",
                schema: "ecom",
                table: "AppMenu",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessRight",
                schema: "ecom",
                table: "AppMenu");

            migrationBuilder.CreateTable(
                name: "AccessRight",
                schema: "ecom",
                columns: table => new
                {
                    AccessID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "NEWID()"),
                    Access = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppMenuID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessRight", x => x.AccessID);
                    table.ForeignKey(
                        name: "FK_AccessRight_AppMenu_AppMenuID",
                        column: x => x.AppMenuID,
                        principalSchema: "ecom",
                        principalTable: "AppMenu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessRight_AppMenuID",
                schema: "ecom",
                table: "AccessRight",
                column: "AppMenuID");
        }
    }
}
