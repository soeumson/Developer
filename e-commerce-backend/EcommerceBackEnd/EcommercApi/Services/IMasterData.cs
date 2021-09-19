using EcommercApi.Models.Products;
using Ecommerce.Core.Model.Category;
using Ecommerce.Core.Model.Company;
using Ecommerce.Core.Model.Model;
using Ecommerce.Core.Model.Product;
using Ecommerce.Core.Model.Uom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercApi.Services
{
    public interface IMasterData
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(string productId);
        IEnumerable<CompanyProfile> GetShop();
        IEnumerable<Category> GetCategories();
        OtherProducts GetOtherProducts();
        SingleProduct GetSingleProduct(string productId);
        IEnumerable<SubCategory> GetSubCategories();
        IEnumerable<Uom> GetUoms();
        IEnumerable<ModelProduct> GetModelProducts();
        MoreProducts GetMoreProducts();
    }
}
