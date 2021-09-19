using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                schema: "ecom",
                table: "Uom",
                newName: "Delete");

            migrationBuilder.RenameColumn(
                name: "Statut",
                schema: "ecom",
                table: "Product",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "AspNetRoles",
                newName: "Delete");

            migrationBuilder.AddColumn<bool>(
                name: "Delete",
                schema: "ecom",
                table: "SubCategory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Delete",
                schema: "ecom",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Delete",
                schema: "ecom",
                table: "Model",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Delete",
                schema: "ecom",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Delete",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Delete",
                schema: "ecom",
                table: "AppMenu",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "AccessRight",
                columns: table => new
                {
                    AccessID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    AppMenuID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    Access = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                table: "AccessRight",
                column: "AppMenuID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessRight");

            migrationBuilder.DropColumn(
                name: "Delete",
                schema: "ecom",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "Delete",
                schema: "ecom",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Delete",
                schema: "ecom",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "Delete",
                schema: "ecom",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Delete",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Delete",
                schema: "ecom",
                table: "AppMenu");

            migrationBuilder.RenameColumn(
                name: "Delete",
                schema: "ecom",
                table: "Uom",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Status",
                schema: "ecom",
                table: "Product",
                newName: "Statut");

            migrationBuilder.RenameColumn(
                name: "Delete",
                table: "AspNetRoles",
                newName: "Status");
        }
    }
}
