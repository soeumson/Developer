using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Company;
using Ecommerce.Core.Model.ContractClass;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.Models;
using EcommerceBackEnd.PermissionUser;
using EcommerceBackEnd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Controllers
{
    [Authorize]
    public class CompanyController : BaseController
    {
        private readonly ICompany _company;
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _appEnvironment;
        public CompanyController(DataContext context,ICompany company,
             IWebHostEnvironment webHostEnvironment) : base(context)
        {

            _company = company;
            _context = context;
            _appEnvironment = webHostEnvironment;
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Shop, AccessRightContract.Create)]
        public IActionResult Create(string response)
        {
            if (response == "T")
                ViewBag.Success = "Success";
            ViewBag.Currencys = new SelectList(_context.Currency.Where(x => x.Status == true), "CurrencyID", "CurrencyName");
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Shop, AccessRightContract.Create)]
        public async Task<IActionResult> Create(CompanyProfile model)
        {
            if (model.CompanyPhone.Length > 10)
            {
                ModelState.AddModelError("CompanyPhone", "");
                ViewBag.Error = "Phone number invalid format.";
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var checkCompany = _context.CompanyProfile.FirstOrDefault(x=>x.CompanyID==User.FindFirst("CompanyID").Value);
                    if (checkCompany == null)
                    {
                        var checkEmail = _context.CompanyProfile.FirstOrDefault(x => x.CompanyEmail == model.CompanyEmail);
                        if (checkEmail != null)
                        {
                            ViewBag.Error = "Email address is already in use​ , try again new email.";
                        }
                        else
                        {
                            var files = HttpContext.Request.Form.Files;
                            foreach (var Image in files)
                            {
                                if (Image != null && Image.Length > 0)
                                {
                                    var file = Image;
                                    var uploads = Path.Combine(_appEnvironment.WebRootPath, "images");
                                    if (file.Length > 0)
                                    {
                                        using (var fileStream = new FileStream(Path.Combine(uploads, model.Logo), FileMode.Create))
                                        {
                                            await file.CopyToAsync(fileStream);
                                            model.Logo = model.Logo;
                                        }
                                    }
                                }
                            }
                            await _company.CompanyProfile(model, User.FindFirstValue(ClaimTypes.NameIdentifier), User.Identity as ClaimsIdentity);

                            return RedirectToAction("create", "company", new { response = "T" });
                        }
                    }
                    else
                    {
                        ViewBag.Error = "The shop can no longer create because it has already been created.";
                    }
                   
                }catch(Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            ViewBag.Currencys = new SelectList(_context.Currency.Where(x => x.Status == true), "CurrencyID", "CurrencyName");
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Shop, AccessRightContract.List)]
        public IActionResult Index()
        {
            return View(_company.GetCompanyProfiles(User.FindFirst("CompanyID").Value));
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Shop, AccessRightContract.See)]
        public IActionResult See(string key)
        {
            var detail = _company.FindById(key.UnProtection());
            if (detail == null)
            {
                return RedirectToAction("pagenotfound", "home");
            }
            return View(detail);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Shop, AccessRightContract.Edit)]
        public IActionResult Edit(string key)
        {
            var detail = _company.FindById(key.UnProtection());
            if (detail == null)
            {
                return RedirectToAction("pagenotfound", "home");
            }
            ViewBag.Currencys = new SelectList(_context.Currency.Where(x => x.Status == true), "CurrencyID", "CurrencyName");
            return View(detail);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Shop, AccessRightContract.Edit)]
        public async Task<IActionResult> Edit(CompanyProfile model)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;
                foreach (var Image in files)
                {
                    if (Image != null && Image.Length > 0)
                    {
                        var file = Image;
                        var uploads = Path.Combine(_appEnvironment.WebRootPath, "images");
                        if (file.Length > 0)
                        {
                            using (var fileStream = new FileStream(Path.Combine(uploads, model.Logo), FileMode.Create))
                            {
                               await file.CopyToAsync(fileStream);
                                model.Logo = model.Logo;
                            }
                        }
                    }
                }
                _company.Edit(model, User.FindFirstValue(ClaimTypes.NameIdentifier));
                return RedirectToAction("index", "company", new { key = model.Encryted });

            }catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            ViewBag.Currencys = new SelectList(_context.Currency.Where(x => x.Status == true), "CurrencyID", "CurrencyName");
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Shop, AccessRightContract.Create)]
        public IActionResult Register()
        {
            ViewBag.Currencys = new SelectList(_context.Currency.Where(x => x.Status == true), "CurrencyID", "CurrencyName");
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Shop, AccessRightContract.Create)]
        public async Task<IActionResult> Register(CompanyProfile model)
        {
            if (model.CompanyPhone.Length > 10)
            {
                ModelState.AddModelError("CompanyPhone", "");
                ViewBag.Error = "Phone number invalid format.";
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var checkCompany = _context.CompanyProfile.FirstOrDefault(x => x.CompanyID == User.FindFirst("CompanyID").Value);
                    if (checkCompany ==null)
                    {
                        var checkEmail = _context.CompanyProfile.FirstOrDefault(x => x.CompanyEmail == model.CompanyEmail);
                        if (checkEmail != null)
                        {
                            ViewBag.Error = "Email address is already in use​ , try again new email.";
                        }
                        else
                        {
                            var files = HttpContext.Request.Form.Files;
                            foreach (var Image in files)
                            {
                                if (Image != null && Image.Length > 0)
                                {
                                    var file = Image;
                                    var uploads = Path.Combine(_appEnvironment.WebRootPath, "images");
                                    if (file.Length > 0)
                                    {
                                        using (var fileStream = new FileStream(Path.Combine(uploads, model.Logo), FileMode.Create))
                                        {
                                            await file.CopyToAsync(fileStream);
                                            model.Logo = model.Logo;
                                        }
                                    }
                                }
                            }
                            await _company.CompanyProfile(model, User.FindFirstValue(ClaimTypes.NameIdentifier),User.Identity as ClaimsIdentity);

                            return RedirectToAction("dashboard", "home");
                        }
                    }
                    else
                    {
                        ViewBag.Error = "The shop can no longer create because it has already been created.";
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            ViewBag.Currencys = new SelectList(_context.Currency.Where(x => x.Status == true), "CurrencyID", "CurrencyName");
            return View(model);
        }
    }
}
