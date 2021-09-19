using Ecommerce.Core.Model.Menu;
using Ecommerce.Core.Model.Uom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Services
{
    public interface IMenu
    {
        void Save(MenuClass.Menu menu,string type);
        void Delete(MenuClass.Menu menu);
        IEnumerable<MenuClass.Menu> GetMenus();
        MenuClass.Menu FindById(string id);
    }
}
