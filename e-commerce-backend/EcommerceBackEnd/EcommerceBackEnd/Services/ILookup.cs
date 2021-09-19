using Ecommerce.Core.Model.LockupClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Services
{
    public interface ILookup
    {
        LookupOptions FindById(string Id, string extention);
        IEnumerable<LookupMenus> GetLookupMenu();
        IEnumerable<LookupOptions> GetOption(string Id);
    }
}
