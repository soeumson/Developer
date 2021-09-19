using Ecommerce.Core.Model.Uom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Services
{
    public interface IUom
    {
        void Save(Uom uom, string currentUser,string companyId,string type);
        void Delete(Uom uom, string currentUser);
        IEnumerable<Uom> GetUoms(string companyId);
        Uom FindById(string uomId);
    }
}
