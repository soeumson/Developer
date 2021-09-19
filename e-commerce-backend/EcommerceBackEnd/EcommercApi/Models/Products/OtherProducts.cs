using Ecommerce.Core.Model.Category;
using Ecommerce.Core.Model.Model;
using Ecommerce.Core.Model.Product;
using Ecommerce.Core.Model.Uom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercApi.Models.Products
{
    public class OtherProducts
    {
        public List<Product> ProductArrival { get; set; }
        public List<Product> ProductBestseller { get; set; }
        public List<Product> FeatureProduct { get; set; }
        public List<Product> SpecialProduct { get; set; }
        public List<ProductCategory> ProductCategory { get; set; }
    }
    public class ProductCategory
    {
       public string Category { get; set; }
       public List<Product> Products { get; set; }
    }
    public class SingleProduct
    {
        public Product Product { get; set; }
        public List<Product> RelateProducts { get; set; }
        public List<Product> ModelProducts { get; set; }
    }
    public class MoreProducts
    {
        public List<Uom> Uoms { get; set; }
        public List<ModelProduct> ModelProducts { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
