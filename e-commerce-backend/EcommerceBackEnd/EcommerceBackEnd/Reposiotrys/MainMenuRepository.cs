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
    public class MainMenuRepository : IMainMenu
    {
        private readonly DataContext _context;
        private string UserID;
        private string CompanyID;
        public MainMenuRepository(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            UserID = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            CompanyID = httpContextAccessor.HttpContext.User.Claims.Count() > 0 ? httpContextAccessor.HttpContext.User.FindFirst("CompanyID").Value : "";
        }
        public void Delete(MenuClass.MainMenu menu)
        {
            try
            {
                var data = _context.MainMenu.FirstOrDefault(x => x.Id.Equals(menu.Id));
                if (data == null)
                {
                    Log.Warning("Main menu id not found " + menu.Id);
                }
                else
                {
                    _context.MainMenu.Remove(data);
                    _context.SaveChanges();
                    Log.Information("Delete main menu successfully " + "data " + JsonConvert.SerializeObject(data) + "By user id" + UserID);
                }
               
            }catch(Exception ex)
            {
                Log.Error("Something went wrong while delete main menu " + ex + "Id " + menu.Id);
                throw new Exception("Something went wrong.");
            }
        }

        public MenuClass.MainMenu FindById(string id)
        {
            var lsMenuItem = from menu in _context.MainMenu 
                             join x in _context.Users on menu.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                             join y in _context.Users on menu.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                             join z in _context.CompanyProfile on menu.CompanyId equals z.CompanyID into zz from com in zz.DefaultIfEmpty()
                             where menu.Id==id
                             select new MenuClass.MainMenu
                             {
                                 Id = menu.Id,
                                 Encryted = menu.Id.Protection(),
                                 Description =menu.Description,
                                 ShowMenu = string.Join(',', _context.Menu.Where(x=>menu.MenuId.Contains(x.Id)).Select(x=>x.Description)),
                                 CreateBy = c_b.FullName ?? menu.CreateBy,
                                 CreateDate=menu.CreateDate,
                                 UpdateBy= u_b.FullName ?? menu.UpdateBy,
                                 UpdateDate=menu.UpdateDate,
                                 CompanyId = com.CompanyName ?? menu.CompanyId,
                                 MenuId = menu.MenuId
                             };
            return lsMenuItem.Count() > 0 ? lsMenuItem.First() : null;
        }

        public IEnumerable<MenuClass.MainMenu> GetMainMenus()
        {
            var lsMenuItem = from menu in _context.MainMenu
                             join x in _context.Users on menu.CreateBy equals x.Id into xx
                             from c_b in xx.DefaultIfEmpty()
                             join y in _context.Users on menu.UpdateBy equals y.Id into yy
                             from u_b in yy.DefaultIfEmpty()
                             join z in _context.CompanyProfile on menu.CompanyId equals z.CompanyID into zz
                             from com in zz.DefaultIfEmpty()
                             where menu.CompanyId == CompanyID
                             select new MenuClass.MainMenu
                             {
                                 Id = menu.Id,
                                 Encryted = menu.Id.Protection(),
                                 Description = menu.Description,
                                 ShowMenu = string.Join(',', _context.Menu.Where(x => menu.MenuId.Contains(x.Id)).Select(x => x.Description)),
                                 CreateBy = c_b.FullName ?? menu.CreateBy,
                                 CreateDate = menu.CreateDate,
                                 UpdateBy = u_b.FullName ?? menu.UpdateBy,
                                 UpdateDate = menu.UpdateDate,
                                 CompanyId = com.CompanyName ?? menu.CompanyId,
                                 MenuId = menu.MenuId

                             };
            return lsMenuItem;
        }

        public void Save(MenuClass.MainMenu menu, string type)
        {
            if (type == "C")
            {
                try
                {
                    menu.CompanyId = CompanyID;
                    menu.CreateBy = UserID;
                    menu.CreateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    _context.MainMenu.Add(menu);
                    _context.SaveChanges();
                    _context.SaveChanges();
                    Log.Information("Create main menu successfully" + "Id " + menu.Id );
                }
                catch(Exception ex)
                {
                    Log.Error("Something went worng while create main menu " + ex + "data " + JsonConvert.SerializeObject(menu) + "By user Id " + UserID);
                    throw new Exception("Somethong went wrong.");
                }
            }
            else
            {
                var find = _context.MainMenu.FirstOrDefault(x => x.Id == menu.Id);
                if (find != null)
                {
                    try
                    {
                        find.Description = menu.Description;
                        find.MenuId = menu.MenuId;
                        find.UpdateBy = UserID;
                        find.UpdateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                        _context.MainMenu.Update(find);
                        _context.SaveChanges();
                        Log.Information("Update main menu successfully" + "Id " + menu.Id);
                    }
                    catch(Exception ex)
                    {
                        Log.Error("Something went worng while update main menu " + ex + "data " + JsonConvert.SerializeObject(menu) + "By user Id " + UserID);
                        throw new Exception("Somethong went wrong.");
                    }
                }
                else
                {
                    Log.Error("Main menu id not found " + "Id " + menu.Id);
                }
            }
        }
    }
}
