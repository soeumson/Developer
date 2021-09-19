using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LockoutOptions");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LockupOptions",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "LockoutOptions",
                columns: table => new
                {
                    AllowedForNewUsers = table.Column<bool>(type: "bit", nullable: false),
                    DefaultLockoutTimeSpan = table.Column<TimeSpan>(type: "time", nullable: false),
                    MaxFailedAccessAttempts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }
    }
}
