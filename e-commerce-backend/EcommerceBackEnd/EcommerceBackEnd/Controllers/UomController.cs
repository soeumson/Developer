using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.ContractClass;
using Ecommerce.Core.Model.Uom;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.Models;
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
    public class UomController : BaseController
    {
        private readonly IUom _uom;

        public UomController(IUom uom, DataContext context) : base(context)
        {
            _uom = uom;
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Uom, AccessRightContract.List)]
        public IActionResult Index()
        {
            var lsUom = _uom.GetUoms(User.FindFirst("CompanyID").Value).Select(x=> {
                x.Encryted = x.UomID.Protection();
                return x;
            });
            return View(lsUom);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Uom, AccessRightContract.Create)]
        public IActionResult Create(string respons)
        {
            if (respons == "T")
                ViewBag.Success = "Success";
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Uom, AccessRightContract.Create)]
        public IActionResult Create(Uom model) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _uom.Save(model, User.FindFirstValue(ClaimTypes.NameIdentifier),User.FindFirst("CompanyID").Value,"C");
                    return RedirectToAction("create","uom", new { respons = "T" });
                }catch(Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Uom, AccessRightContract.Edit)]
        public IActionResult Edit(string key) 
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var uom = _uom.FindById(key.UnProtection());
            if (uom == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(uom);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Uom, AccessRightContract.Edit)]
        public IActionResult Edit(Uom model) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _uom.Save(model, User.FindFirstValue(ClaimTypes.NameIdentifier), User.FindFirst("CompanyID").Value, "U");
                    return RedirectToAction("index","uom");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Uom, AccessRightContract.Delete)]
        public IActionResult Delete(string key) 
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var uom = _uom.FindById(key.UnProtection());
            if (uom == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(uom);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Uom, AccessRightContract.Delete)]
        public IActionResult Delete(Uom model)
        {
            try
            {
                _uom.Delete(model, User.FindFirstValue(ClaimTypes.NameIdentifier));
                return RedirectToAction("index", "uom");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Uom, AccessRightContract.See)]
        public IActionResult See(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var uom = _uom.FindById(key.UnProtection());
            if (uom == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(uom);
        }
    }
}
