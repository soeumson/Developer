using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.ContractClass;
using Ecommerce.Core.Model.Model;
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
using System.Linq;
using System.Security.Claims;

namespace EcommerceBackEnd.Controllers
{
    [Authorize]
    public class ModelController : BaseController
    {
        private readonly IModel _model; 

        public ModelController(IModel model, DataContext context) : base(context)
        {
            _model = model;
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.ModelProduct, AccessRightContract.List)]
        public IActionResult Index()
        {
            var lsModel = _model.GetModels(User.FindFirst("CompanyID").Value).Select(x=> {
                x.Encryted = x.ModelID.Protection();
                return x;
            });
            return View(lsModel);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.ModelProduct, AccessRightContract.Create)]
        public IActionResult Create(string respons)
        {
            if (respons == "T")
                ViewBag.Success = "Success";
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.ModelProduct, AccessRightContract.Create)]
        public IActionResult Create(ModelProduct model) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _model.Save(model, User.FindFirstValue(ClaimTypes.NameIdentifier),User.FindFirst("CompanyID").Value,"C");
                    return RedirectToAction("create","model", new { respons = "T" });
                }catch(Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.ModelProduct, AccessRightContract.Edit)]
        public IActionResult Edit(string key) 
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var model = _model.FindById(key.UnProtection());
            if (model == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(model);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.ModelProduct, AccessRightContract.Edit)]
        public IActionResult Edit(ModelProduct model) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _model.Save(model, User.FindFirstValue(ClaimTypes.NameIdentifier), User.FindFirst("CompanyID").Value, "U");
                    return RedirectToAction("index","model");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.ModelProduct, AccessRightContract.Delete)]
        public IActionResult Delete(string key) 
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var model = _model.FindById(key.UnProtection());
            if (model == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(model);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.ModelProduct, AccessRightContract.Delete)]
        public IActionResult Delete(ModelProduct model)
        {
            try
            {
                _model.Delete(model, User.FindFirstValue(ClaimTypes.NameIdentifier));
                return RedirectToAction("index", "model");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.ModelProduct, AccessRightContract.See)]
        public IActionResult See(string key)
        {
            if (key == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            var model = _model.FindById(key.UnProtection());
            if (model == null)
            {
                return RedirectToAction("PageNotFound", "Home");
            }
            return View(model);
        }
    }
}
