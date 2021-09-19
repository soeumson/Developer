using Ecommerce.Core.Model.Account;
using Ecommerce.Core.Model.Category;
using Ecommerce.Core.Model.Company;
using Ecommerce.Core.Model.Currency;
using Ecommerce.Core.Model.LockupClass;
using Ecommerce.Core.Model.Menu;
using Ecommerce.Core.Model.Model;
using Ecommerce.Core.Model.Product;
using Ecommerce.Core.Model.RoleManager;
using Ecommerce.Core.Model.Tag;
using Ecommerce.Core.Model.Uom;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Core.AppContext
{
    public class DataContext: IdentityDbContext<Account, Role,string>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<AppMenu>  MenuStructure { get; set; } 
        public DbSet<CompanyProfile> CompanyProfile { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Uom> Uom { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<ModelProduct> ModelProduct  { get; set; }
        public DbSet<Tags> Tag { get; set; }
        public DbSet<MenuClass.MainMenu> MainMenu { get; set; }
        public DbSet<MenuClass.Menu> Menu { get; set; }
        public DbSet<MenuClass.MenuItem> MenuItem { get; set; }

        public DbSet<LookupMenus> LookupMenus { get; set; }
        public DbSet<LookupOptions> LookupOptions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CompanyProfile>().Property(x => x.CompanyID).HasDefaultValueSql("NEWID()");
            builder.Entity<AppMenu>().Property(x => x.MenuId).HasDefaultValueSql("NEWID()");
            builder.Entity<Product>().Property(x => x.ProductID).HasDefaultValueSql("NEWID()");
            builder.Entity<Uom>().Property(x => x.UomID).HasDefaultValueSql("NEWID()");
            builder.Entity<Category>().Property(x => x.CategoryID).HasDefaultValueSql("NEWID()");
            builder.Entity<SubCategory>().Property(x => x.SubCategoryID).HasDefaultValueSql("NEWID()");
            builder.Entity<ModelProduct>().Property(x => x.ModelID).HasDefaultValueSql("NEWID()");

        }
    }
}
