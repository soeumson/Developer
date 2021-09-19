using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.ContractClass;
using Ecommerce.Core.Model.Menu;
using Ecommerce.Core.Model.RoleManager;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.Models;
using EcommerceBackEnd.PermissionUser;
using EcommerceBackEnd.Services;
using EcommerceBackEnd.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Controllers
{
    [Authorize]
    public class RoleController : BaseController
    {
        private readonly IRole _role;
        private readonly ILookup _lookup;
        private readonly DataContext _context;
        public RoleController(DataContext context,IRole role ,ILookup lookup) :base(context)
        {
            _role = role;
            _context = context;
            _lookup = lookup;
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.List)]
        public IActionResult Index()
        {
            return View(_role.GetRoles(User.FindFirst("CompanyID").Value));
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.Create)]
        public IActionResult Create(string response) 
        {
            if (response == "T")
                ViewBag.Success = "Success";
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.Create)]
        public async Task<IActionResult> Create(Role model) 
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _role.Create(model, User.FindFirst("CompanyID").Value,User.FindFirstValue(ClaimTypes.NameIdentifier));
                    return RedirectToAction("create", new { response = "T" });

                }catch(Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.Edit)]
        public IActionResult Edit(string key)
        {
            var result =  _role.FindById(key.UnProtection());
            if (result == null)
            {
                return RedirectToAction("pagenotfound", "home");
            }
            return View(result);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.Edit)]
        public async Task<IActionResult> Edit(Role model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _role.Edit(model, User.FindFirst("CompanyID").Value, User.FindFirstValue(ClaimTypes.NameIdentifier));
                    return RedirectToAction("index","role");
                }catch(Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }

        [HttpGet]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.Delete)]
        public IActionResult Delete(string key)
        {
            var result = _role.FindById(key.UnProtection());
            if (result == null)
            {
                return RedirectToAction("pagenotfound", "home");
            }
            return View(result);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.Delete)]
        public  IActionResult Delete(Role model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                     _role.Delete(model);
                    return RedirectToAction("index", "role");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }

        [HttpGet]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.See)]
        public IActionResult See(string key)
        {
            var result = _role.FindById(key.UnProtection());
            if (result == null)
            {
                return RedirectToAction("pagenotfound", "home");
            }
            return View(result);
        }


        [HttpGet]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.List)]
        public IActionResult ProvidRoleAccessRight(string key)
        {
            if (key == null)
                return RedirectToAction("pagenotfound", "home");
            var role = _role.FindById(key.UnProtection());
            if (role == null)
                return RedirectToAction("pagenotfound", "home");
            ProvidRoleAccessRightViewModel model = new ProvidRoleAccessRightViewModel
            {
                RoleId = role.Id,
                RoleName = role.Name,
                MenuItemId = null,
                AccessRight = null
            };
            ViewData["ListAccessRight"] = _role.GetRoleClaim(key.UnProtection());
            ViewData["Menus"] = new SelectList(_lookup.GetLookupMenu(), "Id", "Description");
            ViewData["AccessRight"] = new SelectList(_lookup.GetOption("ACCESS.RIGHT"), "Id", "Description");
            return View(model);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.List)]
        public async Task<IActionResult> ProvidRoleAccessRight(ProvidRoleAccessRightViewModel model)
        {
            if (ModelState.IsValid)
            {
                var hasClaim = _context.RoleClaims.FirstOrDefault(x => x.ClaimType == model.MenuItemId && x.RoleId == model.RoleId);
                if (hasClaim == null)
                {
                    try
                    {
                        await _role.SaveRoleClaim(model,User.FindFirstValue(ClaimTypes.NameIdentifier));
                        return RedirectToAction("providroleaccessright", "role", new { key = model.RoleId.Protection() });
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Error = ex.Message;
                    }
                }
                else
                {
                    ViewBag.Error = "Menu is already provide";
                }
            }

            var role = _role.FindById(model.RoleId);
            if (role == null)
                return RedirectToAction("pagenotfound", "home");

            ProvidRoleAccessRightViewModel modelView = new ProvidRoleAccessRightViewModel
            {
                RoleId = role.Id,
                RoleName = role.Name,
                MenuItemId = model.MenuItemId,
                AccessRight = model.AccessRight
            };
            ViewData["ListAccessRight"] = _role.GetRoleClaim(model.RoleId);
            ViewData["Menus"] = new SelectList(_lookup.GetLookupMenu(), "Id", "Description");
            ViewData["AccessRight"] = new SelectList(_lookup.GetOption("ACCESS.RIGHT"), "Id", "Description");
            return View(modelView);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.Edit)]
        public IActionResult EditRoleClaim(string key)
        {
            if (key == null)
                return RedirectToAction("pagenotfound", "home");
            var roleClaim = _role.GetRoleClaimById(int.Parse(key.UnProtection()));
            if (roleClaim == null)
                return RedirectToAction("pagenotfound", "home");
            roleClaim.AccessRight = roleClaim.ClaimValue.Split(',');
            ViewData["AccessRight"] = new SelectList(_lookup.GetOption("ACCESS.RIGHT"), "Id", "Description");
            return View(roleClaim);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.Edit)]
        public IActionResult EditRoleClaim(RoleClaimViewModel model)
        {
            if (ModelState.IsValid)
            {
                var roleClaim = _context.RoleClaims.FirstOrDefault(x => x.Id == model.Id);
                if (roleClaim != null)
                {
                    try
                    {
                        if (model.AccessRight != null)
                        {
                            string access = "";
                            for (int i = 0; i < model.AccessRight.Length; i++)
                            {
                                if (i == 0)
                                {
                                    access = model.AccessRight[i].Trim();
                                }
                                else
                                {
                                    access += "," + model.AccessRight[i].Trim();
                                }
                            }
                            roleClaim.ClaimValue = access;
                        }
                        _context.RoleClaims.Update(roleClaim);
                        _context.SaveChanges();

                        Log.Information("Update role access right successfully." + "By user " + User.FindFirstValue(ClaimTypes.NameIdentifier) + "data " + JsonConvert.SerializeObject(model));
                        return RedirectToAction("providroleaccessright", "role", new { key = model.RoleId.Protection() });
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Something went wrong while update role access right." + ex + "data " + JsonConvert.SerializeObject(model));
                        ViewBag.Error = "Something went wrong.";
                    }
                }
                else
                {
                    ViewBag.Error = "Record not found.";
                }
            }
            ViewData["AccessRight"] = new SelectList(_lookup.GetOption("ACCESS.RIGHT"), "Id", "Description");
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.Delete)]
        public IActionResult DeleteRoleClaim(string key)
        {
            if (key == null)
                return RedirectToAction("pagenotfound", "home");
            var roleClaim = _role.GetRoleClaimById(int.Parse(key.UnProtection()));
            if (roleClaim == null)
                return RedirectToAction("pagenotfound", "home");
            return View(roleClaim);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Role, AccessRightContract.Delete)]
        public IActionResult DeleteRoleClaim(RoleClaimViewModel model)
        {
            if (ModelState.IsValid)
            {
                var roleClaim = _context.RoleClaims.FirstOrDefault(x => x.Id == model.Id);
                if (roleClaim != null)
                {
                    try
                    {
                        _context.RoleClaims.Remove(roleClaim);
                        _context.SaveChanges();

                        Log.Information("Delete role access right successfully." + "By user " + User.FindFirstValue(ClaimTypes.NameIdentifier) + "data " + JsonConvert.SerializeObject(model));
                        return RedirectToAction("providroleaccessright", "role", new { key = model.RoleId.Protection() });
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Something went wrong while delete role access right." + ex + "data " + JsonConvert.SerializeObject(model));
                        ViewBag.Error = "Something went wrong.";
                    }
                }
                else
                {
                    ViewBag.Error = "Record not found.";
                }
            }
            return View(model);
        }
    }
}
