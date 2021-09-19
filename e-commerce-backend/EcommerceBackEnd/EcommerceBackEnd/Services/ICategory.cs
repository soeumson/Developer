using Ecommerce.Core.Model.Category;
using System.Collections.Generic;

namespace EcommerceBackEnd.Services
{
    public interface ICategory
    {
        void Save(Category category,string type);
        void Delete(Category category);
        IEnumerable<Category> GetCategory(); 
        Category FindById(string id);
    }
}
