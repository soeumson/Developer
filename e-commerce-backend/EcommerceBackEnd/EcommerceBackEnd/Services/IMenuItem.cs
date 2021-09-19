using Ecommerce.Core.Model.Menu;
using Ecommerce.Core.Model.Uom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Services
{
    public interface IMenuItem
    {
        void Save(MenuClass.MenuItem menuItem,string type);
        void Delete(MenuClass.MenuItem menuItem);
        IEnumerable<MenuClass.MenuItem> GetMenuItems();
        MenuClass.MenuItem FindById(string id);
    }
}
