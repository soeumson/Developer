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
    public class MainMenuController : Controller
    {

        private readonly IMainMenu _mainMenu;
        private readonly DataContext _context;
        private readonly IMenu _menu;
        public MainMenuController(IMainMenu mainMenu,DataContext context, IMenu menu)
        {
            _mainMenu = mainMenu;
            _context = context;
            _menu = menu;
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.MainMenu, AccessRightContract.List)]
        public IActionResult Index()
        {
            return View(_mainMenu.GetMainMenus());
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.MainMenu, AccessRightContract.Create)]
        public IActionResult Create(string respons)
        {
            if (respons == "T")
                ViewBag.Success = "Success";
            ViewData["Menu"] = new SelectList(_menu.GetMenus(),"Id","Description") ;
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.MainMenu, AccessRightContract.Create)]
        public IActionResult Create(MenuClass.MainMenu menu)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var find = _mainMenu.FindById(menu.Id);
                    if (find == null)
                    {
                        var menuItem = "";
                        if (menu.Menus.Length > 0)
                        {
                            for (int i = 0; i < menu.Menus.Length; i++)
                            {
                                if (i == 0)
                                    menuItem = menu.Menus[i];
                                else
                                    menuItem += "," + menu.Menus[i];
                            }
                        }
                        menu.MenuId = menuItem.Trim();
                        _mainMenu.Save(menu, "C");
                        return RedirectToAction("create", "mainmenu", new { respons = "T" });
                    }
                    else
                    {
                        ViewBag.Error = "Main menu id is already.";
                    }
                   
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            ViewData["Menu"] = new SelectList(_menu.GetMenus(), "Id", "Description");
            return View(menu);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.MainMenu, AccessRightContract.Edit)]
        public IActionResult Edit(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var menu = _mainMenu.FindById(key.UnProtection());
            if (menu == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            menu.Menus = menu.MenuId.Split(',');
            ViewData["Menu"] = new SelectList(_menu.GetMenus(), "Id", "Description");
            return View(menu);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.MainMenu, AccessRightContract.Edit)]
        public IActionResult Edit(MenuClass.MainMenu menu)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var menuItem = "";
                    if (menu.Menus.Length > 0)
                    {
                        for (int i = 0; i < menu.Menus.Length; i++)
                        {
                            if (i == 0)
                                menuItem = menu.Menus[i];
                            else
                                menuItem += "," + menu.Menus[i];
                        }
                    }
                    menu.MenuId = menuItem.Trim();
                    _mainMenu.Save(menu, "U");
                    return RedirectToAction("index", "mainmenu");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            ViewData["Menu"] = new SelectList(_menu.GetMenus(), "Id", "Description");
            return View(menu);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.MainMenu, AccessRightContract.Delete)]
        public IActionResult Delete(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var menu = _mainMenu.FindById(key.UnProtection());
            if (menu == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(menu);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.MainMenu, AccessRightContract.Delete)]
        public IActionResult Delete(MenuClass.MainMenu menu)
        {
            try
            {
                _mainMenu.Delete(menu);
                return RedirectToAction("index", "menu");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View(menu);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.MainMenu, AccessRightContract.See)]
        public IActionResult See(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var menu = _mainMenu.FindById(key.UnProtection());
            if (menu == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(menu);
        }
    }
}
