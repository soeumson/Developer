using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Category;
using EcommerceBackEnd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Linq;
using System.Security.Claims;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.PermissionUser;
using Ecommerce.Core.Model.ContractClass;

namespace EcommerceBackEnd.Controllers
{
    [Authorize]
    public class CategoryController : BaseController
    {
        private readonly ICategory _category;
        public CategoryController(ICategory contegory,DataContext context) : base(context)
        {
            _category = contegory;
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Cateogry, AccessRightContract.List)]
        public IActionResult Index()
        {
            var lsUom = _category.GetCategory().ToList().Select(x=> {
                x.Encryted = x.CategoryID.Protection();
                return x;
            });
            return View(lsUom);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Cateogry, AccessRightContract.Create)]
        public IActionResult Create(string respons)
        {
            if (respons == "T")
                ViewBag.Success = "Success";
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Cateogry, AccessRightContract.Create)]
        public IActionResult Create(Category model) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _category.Save(model,"C");
                    return RedirectToAction("create","category", new { respons = "T" }); 
                }catch(Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Cateogry, AccessRightContract.Edit)]
        public IActionResult Edit(string key) 
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var category = _category.FindById(key.UnProtection());
            if (category == null)
            {
                Log.Error("Category id not found" + key.UnProtection());
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(category);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Cateogry, AccessRightContract.Edit)]
        public IActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _category.Save(model, "U");
                    return RedirectToAction("index","category");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Cateogry, AccessRightContract.Delete)]
        public IActionResult Delete(string key) 
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var category = _category.FindById(key.UnProtection());
            if (category == null)
            {
                Log.Error("Category id not found" + key.UnProtection());
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(category);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Cateogry, AccessRightContract.Delete)]
        public IActionResult Delete(Category model)
        {
            try
            {
                _category.Delete(model);
                return RedirectToAction("index", "category");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }

            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Cateogry, AccessRightContract.See)]
        public IActionResult See(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var category = _category.FindById(key.UnProtection());
            if (category == null)
            {
                Log.Error("Category id not found" + key.UnProtection());
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(category);
        }
    }
}
