using EcommerceFrontEnd.Models.Authorize;
using EcommerceFrontEnd.Models.Category;
using EcommerceFrontEnd.Models.OtherProductModel;
using EcommerceFrontEnd.Models.Products;
using EcommerceFrontEnd.Models.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceFrontEnd.Service
{
    public interface IMasterData
    {
        Task<ResponseAuthorize> Authorize();
        Task<ProductModel> GetProducts(string token);
        Task<ProductById> GetProductById(string token, string productId);
        Task<CategoryModel> GetCategories(string token);
        Task<ShopModel> GetShops(string token);
        Task<OtherProductModel> GetOtherProduct(string token);
        Task<ProductSingleModel> GetProductSingleModel(string token, string productId);
    }
}
