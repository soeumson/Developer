using Ecommerce.Core.Model.Category;
using Ecommerce.Core.Model.Product;
using System.Collections.Generic;

namespace EcommerceBackEnd.Services
{
    public interface IProduct
    {
        void Create(Product product, string currentUser,string companyId);
        void Edit(Product product, string currentUser, string companyId);
        void Delete(Product product, string currentUser);
        IEnumerable<Product> GetProducts(string companyId);
        Product FindById(string productId);
        string GetCurrency(string companyId);
    }
}
