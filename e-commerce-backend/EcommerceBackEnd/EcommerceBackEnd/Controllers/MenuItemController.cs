using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.ContractClass;
using Ecommerce.Core.Model.Menu;
using Ecommerce.Core.Model.Uom;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.PermissionUser;
using EcommerceBackEnd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Controllers
{
    [Authorize]
    public class MenuItemController : BaseController
    {
        private readonly IMenuItem _menuItem;
        public MenuItemController(IMenuItem menuItem,DataContext context) : base(context)
        {
            _menuItem = menuItem;
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.MenuItem, AccessRightContract.List)]
        public IActionResult Index()
        {
            return View(_menuItem.GetMenuItems());
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.MenuItem, AccessRightContract.Create)]
        public IActionResult Create(string respons)
        {
            if (respons == "T")
                ViewBag.Success = "Success";
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.MenuItem, AccessRightContract.Create)]
        public IActionResult Create(MenuClass.MenuItem menuItem) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var find = _menuItem.FindById(menuItem.Id);
                    if (find == null)
                    {
                        _menuItem.Save(menuItem, "C");
                        return RedirectToAction("create", "menuitem", new { respons = "T" });
                    }
                    else
                    {
                        ViewBag.Error = "Menu Item ID is already.";
                    }
                   
                }catch(Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(menuItem);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.MenuItem, AccessRightContract.Edit)]
        public IActionResult Edit(string key) 
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var menItem = _menuItem.FindById(key.UnProtection());
            if (menItem == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(menItem);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.MenuItem, AccessRightContract.Edit)]
        public IActionResult Edit(MenuClass.MenuItem menuItem) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _menuItem.Save(menuItem,"U");
                    return RedirectToAction("index","menuitem");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(menuItem);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.MenuItem, AccessRightContract.Delete)]
        public IActionResult Delete(string key) 
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var menItem = _menuItem.FindById(key.UnProtection());
            if (menItem == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(menItem);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.MenuItem, AccessRightContract.Delete)]
        public IActionResult Delete(MenuClass.MenuItem menuItem)
        {
            try
            {
                _menuItem.Delete(menuItem);
                return RedirectToAction("index", "menuitem");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View(menuItem);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.MenuItem, AccessRightContract.See)]
        public IActionResult See(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var menItem = _menuItem.FindById(key.UnProtection());
            if (menItem == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(menItem);
        }
    }
}
