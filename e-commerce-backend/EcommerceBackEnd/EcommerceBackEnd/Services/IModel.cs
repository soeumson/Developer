using Ecommerce.Core.Model.Model;
using Ecommerce.Core.Model.Uom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Services
{
    public interface IModel
    {
        void Save(ModelProduct model, string currentUser,string companyId,string type);
        void Delete(ModelProduct model, string currentUser);
        IEnumerable<ModelProduct> GetModels(string companyId); 
        ModelProduct FindById(string modelId);
    }
}
