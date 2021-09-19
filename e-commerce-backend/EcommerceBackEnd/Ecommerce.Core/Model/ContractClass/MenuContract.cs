using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Model.ContractClass
{
    public static class MenuContract
    {
        public const string UserAccount = "USER.ACCOUNT";
        public const string Shop = "SHOP";
        public const string Product = "PRODUCT";
        public const string Cateogry = "CATEGORY";
        public const string SubCategory = "SUB.CATEGORY";
        public const string ModelProduct = "MODEL";
        public const string Uom = "UNIT.OF.MEASURE";
        public const string Role = "ROLE";
        public const string MainMenu = "MAIN.MENU";
        public const string Menu = "MENU";
        public const string MenuItem = "MENU.ITEM";
        public const string Approval = "APPROVAL";
        public const string Dashboad = "DASHBOAD";
        public const string AllMenu = "ALL.MENUS";

    }
    public static class AccessRightContract
    {
        public const string All = "ALL";
        public const string Delete = "D";
        public const string Edit = "E";
        public const string Create = "C";
        public const string See = "S";
        public const string List = "L";
        public const string Approval = "A";
    }
}
