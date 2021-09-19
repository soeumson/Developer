using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Account;
using Ecommerce.Core.Model.ContractClass;
using EcommerceBackEnd.Models;
using EcommerceBackEnd.PermissionUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
namespace EcommerceBackEnd.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        private readonly UserManager<Account> _usermanager;
        private readonly DataContext _context;
        public HomeController(DataContext context, UserManager<Account> userManager) :base(context)
        {
            _context = context;
            _usermanager = userManager;
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Dashboad, AccessRightContract.See)]
        public async Task<IActionResult> dashboard(string skip)
        {
            if (!string.IsNullOrEmpty(skip))
            {
                try
                {
                    var user = await _usermanager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
                    if (user != null)
                    {
                        user.ResetPassword = true;
                        _context.Users.Update(user);
                        _context.SaveChanges();
                    }
                    else
                    {
                        return RedirectToAction("pagenotfound", "home");
                    }

                }catch(Exception ex)
                {
                    Log.Error("Something went wrong skip reset password" + ex);
                    return RedirectToAction("pagenotfound", "home");
                }
            }
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [AllowAnonymous]
        public IActionResult PageNotFound()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult ConfirmSuccess()
        {
            return View();
        }
    }
}
