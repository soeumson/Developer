using Ecommerce.Core.Model.Menu;
using Ecommerce.Core.Model.Uom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Services
{
    public interface IMainMenu
    {
        void Save(MenuClass.MainMenu menu,string type);
        void Delete(MenuClass.MainMenu menu);
        IEnumerable<MenuClass.MainMenu> GetMainMenus();
        MenuClass.MainMenu FindById(string id);
    }
}
