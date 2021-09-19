using Ecommerce.Core.Model.Category;
using System.Collections.Generic;

namespace EcommerceBackEnd.Services
{
    public interface ISubCategory
    {
        void Save(SubCategory sub, string currentUser,string companyId,string type);
        void Delete(SubCategory sub, string currentUser);
        IEnumerable<SubCategory> GetSubCategories(string companyId);
        SubCategory FindById(string subId);
    }
}
