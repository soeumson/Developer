using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.ContractClass;
using Ecommerce.Core.Model.Menu;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.PermissionUser;
using EcommerceBackEnd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Controllers
{
    [Authorize]
    public class MenuController : Controller
    {
       
        private readonly IMenu _menu;
        private readonly DataContext _context;
        private readonly IMenuItem _menuItem;
        public MenuController(IMenu menu,DataContext context, IMenuItem menuItem)
        {
            _menu = menu;
            _context = context;
            _menuItem = menuItem;
        }
        [HttpGet]
        public IActionResult RedirectPage(string urlRedirect)
        {
            var menuId = urlRedirect.Split("~")[0];
            var menuItem = urlRedirect.Split("~")[1];
            var destinatinUrl = urlRedirect.Split("~")[2];
            var route = urlRedirect.Split("~")[3];
            var icon = urlRedirect.Split("~")[4];
            var controller = destinatinUrl.Split("/")[0];
            var action = destinatinUrl.Split("/")[1];
            TempData["ActiveMenu"] = menuId;
            TempData["ActiveMenuItem"] = menuItem;
            TempData["Route"] = route;
            TempData["Icon"] = icon;
            return RedirectToAction(action, controller);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Menu, AccessRightContract.List)]
        public IActionResult Index()
        {
            return View(_menu.GetMenus());
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Menu, AccessRightContract.Create)]
        public IActionResult Create(string respons)
        {
            if (respons == "T")
                ViewBag.Success = "Success";
            ViewData["MenuItem"] = new SelectList(_menuItem.GetMenuItems(),"Id","Description") ;
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Menu, AccessRightContract.Create)]
        public IActionResult Create(MenuClass.Menu menu)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var find = _menu.FindById(menu.Id);
                    if (find == null)
                    {
                        var menuItem = "";
                        if (menu.MenuItems.Length > 0)
                        {
                            for (int i = 0; i < menu.MenuItems.Length; i++)
                            {
                                if (i == 0)
                                    menuItem = menu.MenuItems[i];
                                else
                                    menuItem += "," + menu.MenuItems[i];
                            }
                        }
                        menu.MenuItemId = menuItem.Trim();
                        _menu.Save(menu, "C");
                        return RedirectToAction("create", "menu", new { respons = "T" });
                    }
                    else
                    {
                        ViewBag.Error = "Menu ID is already.";
                    }
                   
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            ViewData["MenuItem"] = new SelectList(_menuItem.GetMenuItems(), "Id", "Description");
            return View(menu);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Menu, AccessRightContract.Edit)]
        public IActionResult Edit(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var menu = _menu.FindById(key.UnProtection());
            if (menu == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            menu.MenuItems = menu.MenuItemId.Split(',');
            ViewData["MenuItem"] = new SelectList(_menuItem.GetMenuItems(), "Id", "Description");
            return View(menu);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Menu, AccessRightContract.Edit)]
        public IActionResult Edit(MenuClass.Menu menu)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var menuItem = "";
                    if (menu.MenuItems.Length > 0)
                    {
                        for (int i = 0; i < menu.MenuItems.Length; i++)
                        {
                            if (i == 0)
                                menuItem = menu.MenuItems[i];
                            else
                                menuItem += "," + menu.MenuItems[i];
                        }
                    }
                    menu.MenuItemId = menuItem.Trim();
                    _menu.Save(menu, "U");
                    return RedirectToAction("index", "menu");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            ViewData["MenuItem"] = new SelectList(_menuItem.GetMenuItems(), "Id", "Description");
            return View(menu);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Menu, AccessRightContract.Delete)]
        public IActionResult Delete(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var menu = _menu.FindById(key.UnProtection());
            if (menu == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(menu);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Menu, AccessRightContract.Delete)]
        public IActionResult Delete(MenuClass.Menu menu)
        {
            try
            {
                _menu.Delete(menu);
                return RedirectToAction("index", "menu");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View(menu);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Menu, AccessRightContract.See)]
        public IActionResult See(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var menu = _menu.FindById(key.UnProtection());
            if (menu == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(menu);
        }
    }
}
