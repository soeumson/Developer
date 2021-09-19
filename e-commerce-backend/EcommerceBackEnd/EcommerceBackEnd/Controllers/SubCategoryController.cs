using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Category;
using Ecommerce.Core.Model.ContractClass;
using Ecommerce.Core.Model.Uom;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.Models;
using EcommerceBackEnd.PermissionUser;
using EcommerceBackEnd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Serilog;
using System;
using System.Linq;
using System.Security.Claims;


namespace EcommerceBackEnd.Controllers
{
    [Authorize]
    public class SubCategoryController : BaseController
    {
        private readonly ISubCategory _subCategory;
        private readonly DataContext _context;

        public SubCategoryController(ISubCategory sub, DataContext context) : base(context)
        {
            _subCategory = sub;
            _context = context;
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.SubCategory, AccessRightContract.List)]
        public IActionResult Index()
        {
            var lsSub = _subCategory.GetSubCategories(User.FindFirst("CompanyID").Value).Select(x=> {
                x.Encryted = x.SubCategoryID.Protection();
                return x;
            });
            return View(lsSub);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.SubCategory, AccessRightContract.Create)]
        public IActionResult Create(string respons)
        {
            if (respons == "T")
                ViewBag.Success = "Success";
            ViewData["Category"] = new SelectList(_context.Category.Where(x => x.Delete == false), "CategoryID", "CategoryName");
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.SubCategory, AccessRightContract.Create)]
        public IActionResult Create(SubCategory model) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _subCategory.Save(model, User.FindFirstValue(ClaimTypes.NameIdentifier),User.FindFirst("CompanyID").Value,"C");
                    return RedirectToAction("create","subcategory", new { respons = "T" });
                }catch(Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            ViewData["Category"] = new SelectList(_context.Category.Where(x => x.Delete == false), "CategoryID", "CategoryName");
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.SubCategory, AccessRightContract.Edit)]
        public IActionResult Edit(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var uom = _subCategory.FindById(key.UnProtection());
            if (uom == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            ViewData["Category"] = new SelectList(_context.Category.Where(x => x.Delete == false), "CategoryID", "CategoryName");
            return View(uom);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.SubCategory, AccessRightContract.Edit)]
        public IActionResult Edit(SubCategory model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _subCategory.Save(model, User.FindFirstValue(ClaimTypes.NameIdentifier), User.FindFirst("CompanyID").Value, "U");
                    return RedirectToAction("index", "subcategory");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            ViewData["Category"] = new SelectList(_context.Category.Where(x => x.Delete == false), "CategoryID", "CategoryName");
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.SubCategory, AccessRightContract.Delete)]
        public IActionResult Delete(string key) 
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var sub = _subCategory.FindById(key.UnProtection());
            if (sub == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(sub);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.SubCategory, AccessRightContract.Delete)]
        public IActionResult Delete(SubCategory model)
        {
            try
            {
                _subCategory.Delete(model, User.FindFirstValue(ClaimTypes.NameIdentifier));
                return RedirectToAction("index", "subcategory");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.SubCategory, AccessRightContract.See)]
        public IActionResult See(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var sub = _subCategory.FindById(key.UnProtection());
            if (sub == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(sub);
        }
    }
}
