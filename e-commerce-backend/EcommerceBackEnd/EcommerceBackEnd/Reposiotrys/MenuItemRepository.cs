using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Menu;
using Ecommerce.Core.Model.Uom;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.Services;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Reposiotrys
{
    public class MenuItemRepository : IMenuItem
    {
        private readonly DataContext _context;
        private string UserID;
        private string CompanyID;
        public MenuItemRepository(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            UserID = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            CompanyID = httpContextAccessor.HttpContext.User.FindFirst("CompanyID").Value;
        }
        public void Delete(MenuClass.MenuItem menuItem)
        {
            try
            {
                var data = _context.MenuItem.FirstOrDefault(x => x.Id.Equals(menuItem.Id));
                if (data == null)
                {
                    Log.Warning("Menu Item id not found " + menuItem.Id);
                }
                else
                {
                    _context.MenuItem.Remove(data);
                    _context.SaveChanges();
                    Log.Information("Delete Menu item successfully " + "data " + JsonConvert.SerializeObject(data) + "By user id" + UserID);
                }
               
            }catch(Exception ex)
            {
                Log.Error("Something went wrong while delete menu item " + ex + "Id " + menuItem.Id);
                throw new Exception("Something went wrong.");
            }
        }

        public MenuClass.MenuItem FindById(string id)
        {
            var lsMenuItem = from menu in _context.MenuItem 
                             join x in _context.Users on menu.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                             join y in _context.Users on menu.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                             join z in _context.CompanyProfile on menu.CompanyId equals z.CompanyID into zz from com in zz.DefaultIfEmpty()
                             where menu.Id==id
                             select new MenuClass.MenuItem
                             {
                                 Id = menu.Id,
                                 Encryted = menu.Id.Protection(),
                                 Description =menu.Description,
                                 KhmerDescription=menu.KhmerDescription,
                                 Url = menu.Url,
                                 CreateBy = c_b.FullName ?? menu.CreateBy,
                                 CreateDate=menu.CreateDate,
                                 UpdateBy= u_b.FullName ?? menu.UpdateBy,
                                 UpdateDate=menu.UpdateDate,
                                 CompanyId = com.CompanyName ?? menu.CompanyId
                             };
            return lsMenuItem.Count() > 0 ? lsMenuItem.First() : null;
        }

        public IEnumerable<MenuClass.MenuItem> GetMenuItems()
        {
            var lsMenuItem = from menu in _context.MenuItem
                             join x in _context.Users on menu.CreateBy equals x.Id into xx
                             from c_b in xx.DefaultIfEmpty()
                             join y in _context.Users on menu.UpdateBy equals y.Id into yy
                             from u_b in yy.DefaultIfEmpty()
                             join z in _context.CompanyProfile on menu.CompanyId equals z.CompanyID into zz
                             from com in zz.DefaultIfEmpty()
                             where menu.CompanyId == CompanyID
                             select new MenuClass.MenuItem
                             {
                                 Id = menu.Id,
                                 Encryted= menu.Id.Protection(),
                                 Description = menu.Description,
                                 KhmerDescription = menu.KhmerDescription,
                                 Url = menu.Url,
                                 CreateBy = c_b.FullName ?? menu.CreateBy,
                                 CreateDate = menu.CreateDate,
                                 UpdateBy = u_b.FullName ?? menu.UpdateBy,
                                 UpdateDate = menu.UpdateDate,
                                 CompanyId = com.CompanyName ?? menu.CompanyId
                             };
            return lsMenuItem;
        }

        public void Save(MenuClass.MenuItem menuItem, string type)
        {
            if (type == "C")
            {
                try
                {
                    menuItem.CompanyId = CompanyID;
                    menuItem.CreateBy = UserID;
                    menuItem.CreateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    _context.MenuItem.Add(menuItem);
                    _context.SaveChanges();
                    _context.SaveChanges();
                    Log.Information("Create menu item successfully" + "Id " + menuItem.Id );
                }
                catch(Exception ex)
                {
                    Log.Error("Something went worng while create menu item " + ex + "data " + JsonConvert.SerializeObject(menuItem) + "By user Id " + UserID);
                    throw new Exception("Somethong went wrong.");
                }
            }
            else
            {
                var find = _context.MenuItem.FirstOrDefault(x => x.Id == menuItem.Id);
                if (find != null)
                {
                    try
                    {
                        find.Description = menuItem.Description;
                        find.KhmerDescription = menuItem.KhmerDescription;
                        find.Url = menuItem.Url;
                        find.UpdateBy = UserID;
                        find.UpdateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                        _context.MenuItem.Update(find);
                        _context.SaveChanges();
                        Log.Information("Update menu item successfully" + "Id " + menuItem.Id);
                    }
                    catch(Exception ex)
                    {
                        Log.Error("Something went worng while update menu item " + ex + "data " + JsonConvert.SerializeObject(menuItem) + "By user Id " + UserID);
                        throw new Exception("Somethong went wrong.");
                    }
                }
                else
                {
                    Log.Error("Menu item id not found " + "Id " + menuItem.Id);
                }
            }
        }
    }
}
