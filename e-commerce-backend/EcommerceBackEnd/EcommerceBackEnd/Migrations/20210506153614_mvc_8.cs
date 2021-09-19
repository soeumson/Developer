using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceBackEnd.Migrations
{
    public partial class mvc_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                schema: "ecom",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "NEWID()"),
                    CategoryName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                schema: "ecom",
                columns: table => new
                {
                    ModelID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "NEWID()"),
                    ModelName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.ModelID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "ecom",
                columns: table => new
                {
                    ProductID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "NEWID()"),
                    ProductCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    SubCategoryID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ModelID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    UomID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Qty = table.Column<float>(type: "real", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManageStock = table.Column<bool>(type: "bit", nullable: false),
                    StatusAvailable = table.Column<bool>(type: "bit", nullable: false),
                    DiscountActive = table.Column<bool>(type: "bit", nullable: false),
                    DiscountValue = table.Column<float>(type: "real", nullable: false),
                    DiscountType = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    FeeIncluded = table.Column<float>(type: "real", nullable: false),
                    VatIncluded = table.Column<float>(type: "real", nullable: false),
                    Statut = table.Column<bool>(type: "bit", nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                schema: "ecom",
                columns: table => new
                {
                    SubCategoryID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "NEWID()"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CategoryID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.SubCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Uom",
                schema: "ecom",
                columns: table => new
                {
                    UomID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "NEWID()"),
                    UomName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uom", x => x.UomID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category",
                schema: "ecom");

            migrationBuilder.DropTable(
                name: "Model",
                schema: "ecom");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "ecom");

            migrationBuilder.DropTable(
                name: "SubCategory",
                schema: "ecom");

            migrationBuilder.DropTable(
                name: "Uom",
                schema: "ecom");
        }
    }
}
