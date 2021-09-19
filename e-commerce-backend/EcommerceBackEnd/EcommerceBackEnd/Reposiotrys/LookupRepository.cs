using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.LockupClass;
using EcommerceBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Reposiotrys
{
    public class LookupRepository: ILookup
    {
        private readonly DataContext _context;
        public LookupRepository(DataContext context)
        {
            _context = context;
        }
        public LookupOptions FindById(string Id, string extention)
        {
            var key = extention.ToUpper() + "*" + Id.ToUpper();
            return _context.LookupOptions.FirstOrDefault(x => x.Id.ToUpper() == key);
        }

        public IEnumerable<LookupMenus> GetLookupMenu()
        {
            return _context.LookupMenus.ToList();
        }

        public IEnumerable<LookupOptions> GetOption(string Id)
        {
            var key = Id + "*";
            return _context.LookupOptions.Where(x => x.Id.Contains(key)).ToList().Select(o =>
            {
                o.Id = o.Id.Split('*')[1];
                return o;
            });
        }
    }
}
