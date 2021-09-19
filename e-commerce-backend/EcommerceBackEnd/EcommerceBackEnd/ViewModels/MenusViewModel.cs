using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.ViewModels
{
    public class MenusViewModel
    {
        public class MainModel
        {
            public string Id { get; set; }
            public string Description { get; set; }
            public List<MenuModel> MenuModel { get; set; }
        }
        public class MenuModel
        {
            public string Id { get; set; }
            public string Description { get; set; }
            public string KhmerDescription { get; set; }
            public string Icon { get; set; }
            public List<MenuItemModel> MenuItemModel { get; set; }

        }
        public class MenuItemModel
        {
            public string Id { get; set; }
            public string Description { get; set; }
            public string KhmerDescription { get; set; }
            public string Url { get; set; }
        }
    }
}
