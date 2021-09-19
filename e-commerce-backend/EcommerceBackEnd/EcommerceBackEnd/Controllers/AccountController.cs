using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Account;
using Ecommerce.Core.Model.ContractClass;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.Models;
using EcommerceBackEnd.PermissionUser;
using EcommerceBackEnd.Services;
using EcommerceBackEnd.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Serilog;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Controllers
{
    [Authorize]
    public class AccountController : BaseController
    {
        private readonly IAccount _account;
        private readonly UserManager<Account> _usermanager;
        private readonly SignInManager<Account> _signInManager;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly DataContext _context;
        private readonly IEmailSender _emailSender;
        private readonly IMainMenu _mainMenu;
        private readonly IRole _role;
        private readonly ILookup _lookup;
        public AccountController(DataContext context,IAccount account,UserManager<Account> userManager,
                                 IWebHostEnvironment webHostEnvironment,
                                 SignInManager<Account> signInManager,
                                 IEmailSender emailSender,
                                 IMainMenu mainMenu,
                                 IRole role,
                                 ILookup lookup
                                 ) :base(context) 
        {          
            _account = account;
            _usermanager = userManager;
            _appEnvironment = webHostEnvironment;
            _signInManager = signInManager;
            _context = context;
            _emailSender = emailSender;
            _mainMenu = mainMenu;
            _role = role;
            _lookup = lookup;
        }
        [UserClaimRequirement(MenuContract.UserAccount,AccessRightContract.List)]
        public  IActionResult Index()
        {
            return View( _account.GetAccounts());
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.Create)]
        public IActionResult Create(string reponse)
        {
            if(reponse=="T")
                ViewBag.Success = "Success";
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.Create)]
        public async Task<IActionResult> Create(Account model)
        {
            var AllError = "";
            if (model.PasswordHash != model.ConfirmPassword)
            {
                ModelState.AddModelError("ConfirmPassword", "");
                ViewBag.Error = "Password not match.";
            }
            if(model.StartDateProfile < DateTime.Today)
            {
                ModelState.AddModelError("StartDateProfile", "");
                ViewBag.Error = "Start date profile must be greater than current date.";
            }
            if (model.PhoneNumber.Length > 10)
            {
                ModelState.AddModelError("PhoneNumber", "");
                ViewBag.Error = "Phone number invalid format.";
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var company = _context.CompanyProfile.Where(x=>x.UserID==User.FindFirstValue(ClaimTypes.NameIdentifier)).Count();
                    if (company != 0)
                    {
                        var checkEmail = await _usermanager.FindByEmailAsync(model.Email);
                        if (checkEmail != null)
                        {
                            ViewBag.Error = "Email address is already in use​ , try again a new email.";
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
                                        using (var fileStream = new FileStream(Path.Combine(uploads, model.Image), FileMode.Create))
                                        {
                                            await file.CopyToAsync(fileStream);
                                            model.Image = model.Image;
                                        }
                                    }
                                }
                            }

                            var result = await _account.Create(model);
                            if (result.Count() == 0)
                            {
                                return RedirectToAction(nameof(Create), new { reponse = "T" });
                            }
                            else
                            {
                                foreach (var error in result.ToList())
                                {
                                    AllError = AllError + "." + error.Description;
                                }
                                ViewBag.Error = AllError;
                            }
                        }
                    }
                    else
                    {
                        ViewBag.Error = "Please complete your company profile after create user account.";
                    }
                }
                catch(Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterUser(string reponse)
        {
            if (reponse == "T")
                ViewBag.Success = "Success";
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterUser(Account model)
        {
            var AllError = "";
            if (model.PasswordHash != model.ConfirmPassword)
            {
                ModelState.AddModelError("ConfirmPassword", "");
                ViewBag.Error = "Password not match.";
            }
            if (model.PhoneNumber.Length > 10)
            {
                ModelState.AddModelError("PhoneNumber", "");
                ViewBag.Error = "Phone number invalid format.";
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var checkEmail =await _usermanager.FindByEmailAsync(model.Email);
                    if (checkEmail!=null)
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
                                    using (var fileStream = new FileStream(Path.Combine(uploads, model.Image), FileMode.Create))
                                    {
                                        await file.CopyToAsync(fileStream);
                                        model.Image = model.Image;
                                    }

                                }
                            }
                        }
                        var result = await _account.RegisterUser(model);
                        if (result.Count() == 0)
                        {
                            var token = await _usermanager.GenerateEmailConfirmationTokenAsync(model);
                            var callback = Url.Action("comfirmemail", "account", new { token, email = model.Email }, Request.Scheme);
                            await _emailSender.SendEmailAsync(model.Email, "Comfirm Email", "", "<b><p> Hi " + model.FullName + " </p></b> We've received a request to join  please click here to confirm  :<a href=\"" + callback + "\"><b>" + model.Email + "</b></a>");
                           
                            return RedirectToAction("registeruser", "account", new { reponse = "T" });
                        }
                        else
                        {
                            foreach (var error in result.ToList())
                            {
                                AllError = AllError + "." + error.Description;
                            }
                            ViewBag.Error = AllError;
                        }
                    }
                }
                catch(Exception ex)
                {
                    if (ex.InnerException.Message == "EMAIL")
                    {
                        var result=  await _usermanager.DeleteAsync(model);
                        if (!result.Succeeded)
                        {
                            Log.Error("Invalid Delete user when register user." + JsonConvert.SerializeObject(result.Errors.ToList()));
                        }
                    }
                    ViewBag.Error = ex.Message;
                }
            }
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.See)]
        public IActionResult See(string key)
        {
            var detail =  _account.FindById(key.UnProtection());
            if (detail == null)
            {
                return RedirectToAction("pagenotfound","home");
            }
            return View(detail);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.Edit)]
        public IActionResult Edit(string key)
        {
            var result = _account.FindById(key.UnProtection());
            if (result == null)
            {
                return RedirectToAction("pagenotfound", "home");
            }
            return View(result);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.Edit)]
        public async Task<ActionResult> Edit(AccountViewModel model)
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
                            using (var fileStream = new FileStream(Path.Combine(uploads, model.Image), FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                                model.Image = model.Image;
                            }
                        }
                    }
                }
                _account.Update(model);
                return RedirectToAction("index", "account", new { key = model.Encryted});
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View(model);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task <IActionResult> Login(LoginViewModel model,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string result = await _account.LoginControl(model);
                    if (result == "SC") // success
                    {
                        if (model.Remember == true)
                        {
                            Response.Cookies.Append("Email", model.EmailAddress, new CookieOptions { MaxAge = TimeSpan.FromDays(1) });
                            Response.Cookies.Append("PasswordHash", model.Password, new CookieOptions { MaxAge = TimeSpan.FromDays(1) });
                        }
                        else
                        {
                            Response.Cookies.Delete("EmailAddress");
                            Response.Cookies.Delete("Password");
                        }

                        var user = await _usermanager.FindByEmailAsync(model.EmailAddress);
                        if (user != null)
                        {
                            var mainMenu = _account.GetMenus(user.MainMenuId);
                            if (mainMenu != null)
                            {
                                var jsonMenu = JsonConvert.SerializeObject(mainMenu);
                                HttpContext.Session.SetString("MENUS", jsonMenu);
                            }
                        }
                        if (user != null && user.UserType == "ADMINUSER")
                        {
                            var company = _context.CompanyProfile.FirstOrDefault(x => x.UserID == user.Id);
                            if (company != null)
                            {
                                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                                    return Redirect(returnUrl);
                                else
                                    return RedirectToAction("dashboard", "home");
                            }
                            else
                                return RedirectToAction("register", "company");
                        }

                        if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                            return Redirect(returnUrl);
                        else
                            return RedirectToAction("dashboard", "home");

                    }
                    else if (result == "SU") // user unavailable
                        ViewBag.Info = "User is Unavailable.";
                    else if (result == "SD") // start data profile reached the deadline
                        ViewBag.info = "User have not reached the deadline";
                    else if(result=="AP") // user has not approve
                        ViewBag.Info = "Account email has not approved from administrator, please wait approval.";
                    else if (result == "EP") // verify email
                        ViewBag.Info = "Please verify your email.";
                    else if (result == "RP") // reset password after login
                        return RedirectToAction("resetpassword", "account");
                    else if (result == "LK") // user lock
                    {
                        ViewBag.Info = "User is locked.";
                        ViewBag.Lock = "True";
                    }
                    else if(result== "GN") // general error username and password invalid
                        ViewBag.Info = "Incorrect email or password.";
                }
                catch(Exception ex)
                {
                    ViewBag.Info = "Something went wrong.";
                    Log.Error("Something went wrong :" + ex.Message);
                }
            }
            else
            {
                ViewBag.Info = "Incorrect email or password.";
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewMedel model)
        {
            if (ModelState.IsValid)
            {
                if (model.NewPassoword != model.ConfirmNewPassword)
                {
                    ModelState.AddModelError("NewPassoword", "");
                    ViewBag.Error = "New password not match.";
                }
                else
                {
                    try
                    {
                        await _account.ResetPassword(model);
                        Log.Information("Reset password successfully by user " + User.FindFirstValue(ClaimTypes.NameIdentifier));
                        return RedirectToAction("dashboard", "home");
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "NotFound")
                        {
                           return RedirectToAction("login", "account");
                        }
                        else if(ex.InnerException.Message=="Error")
                        {
                            ModelState.AddModelError("newpassoword", ex.Message);
                            ViewBag.Error = ex.Message;
                        }
                        else
                        {
                            Log.Error("Something went wrong reset password :", ex.Message);
                            ViewBag.Error = "Something went wrong";
                        }
                    }
                }
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("login", "account");
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgetPassword(string Email)
        {
            if (ModelState.IsValid)
            {
                var user = await _usermanager.FindByEmailAsync(Email);
                if(user!=null)
                {
                    try
                    {
                        var token = await _usermanager.GeneratePasswordResetTokenAsync(user);
                        var callback = Url.Action(nameof(ResetPasswordSendEmail), "account", new { token, email = user.Email }, Request.Scheme);
                        await _emailSender.SendEmailAsync(Email, "Reset Password","", "<b><p> Hi "+ user.FullName +" </p></b> We've received a request to set a new password for this account please click here :<a href=\"" + callback + "\"><b>"+ Email +"</b></a>");
                      
                        return Ok( new { status="T",message= "Successful send email,please check email and verify link." });
                    }
                    catch(Exception ex)
                    {
                        return Ok(new {status="F",message=ex.Message});
                    }
                }
                else
                {
                    return Ok(new { status = "F", message = "The email you provided could not be found. "});
                }
            }
            return Ok(new { status = "F", message = "Please provide a valid email."});
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPasswordSendEmail(string token, string email)
        {
            if(token !=null && email != null)
            {
                var model = new ResetPasswordViewMedel { Token = token, Email = email };
                return View(model);
            }
            else
            {
                return RedirectToAction("pagenotfound", "home");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPasswordSendEmail(ResetPasswordViewMedel model)
        {
            if (ModelState.IsValid)
            {
                if (model.NewPassoword != model.ConfirmNewPassword)
                {
                    ModelState.AddModelError("NewPassoword", "");
                    ViewBag.Error = "New password not match.";
                }
                else
                {
                    try
                    {
                        await _account.ResetPasswordSendEmail(model);
                        Log.Information("Reset password successfully by email" + model.Email);
                        ViewBag.Success = "Success";
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "NotFound")
                        {
                            ViewBag.Error = "User not found.";
                        }
                        else if (ex.InnerException.Message == "Error")
                        {
                            ModelState.AddModelError("NewPassoword", ex.Message);
                            ViewBag.Error = ex.Message;
                        }
                        else
                        {
                            Log.Error("Something went wrong reset password :" + ex);
                            ViewBag.Error = "Something went wrong";
                        }
                    }
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.NewPassword != model.ConfirmPassword)
                {
                    ViewBag.Error = "New password not match.";
                }
                else
                {
                    try
                    {
                        var user = await _usermanager.GetUserAsync(User);
                        if (user == null)
                        {
                            return RedirectToAction("login", "account");
                        }
                        var result = await _usermanager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                        if (result.Succeeded)
                        {
                            Log.Information("Change password successfully by user " + user.Id);
                            await _signInManager.RefreshSignInAsync(user);
                            ViewBag.Success = "Success";
                        }
                        else
                        {
                            foreach (var item in result.Errors)
                            {
                                ViewBag.Error = item.Description;
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        Log.Error("Something went wrong change password :" + ex.Message);
                        ViewBag.Error = "Something went wrong.";
                    }

                }
            }
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Approval, AccessRightContract.Approval)]
        public IActionResult ApprovalUser()
        {
            return View(_account.GetApprovalUsers());
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.Approval, AccessRightContract.Approval)]
        public IActionResult ApprovalDetail(string key) 
        {
            var data = _account.FindApprovalUser(key.UnProtection());
            if (data != null)
            {
                return View(data);
            }
            return RedirectToAction("pagenotfound", "home");
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.Approval, AccessRightContract.Approval)]
        public async Task<IActionResult> ApprovalDetail(Account model)
        {
            var user = await _usermanager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                try
                {
                    await _emailSender.SendEmailAsync(model.Email, "Approved by administrator", "", "<b><p> Hi " + user.FullName + " </p></b> We've accepted your request.<br /> Thank you!");
                    try
                    {
                        user.CreateBy = User.FindFirstValue(ClaimTypes.NameIdentifier);
                        user.Approval = true;
                        var result= await _usermanager.UpdateAsync(user);
                        if (!result.Succeeded)
                        {
                            Log.Error("Get error when update user " + JsonConvert.SerializeObject(result.Errors.ToList()));
                        }
                    }
                    catch(Exception ex)
                    {
                        Log.Error("Something went wrong went when update createby " + ex);
                    }
                    Log.Information("User Is Approved " + "data " + JsonConvert.SerializeObject(user));

                    ViewBag.Success = "Success";
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            else
            {
                ViewBag.Error = "The email you provided could not be found.";
            }
            return View(user);
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ComfirmEmail(string token, string email)
        {
            var user = await _usermanager.FindByEmailAsync(email);
            if (user == null)
                return RedirectToAction("pagenotfound", "home");
            var result = await _usermanager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                Log.Information("User request has been confirm join system " + email);
                return RedirectToAction("confirmsuccess","home");
            }
            Log.Error("Something went wrong confirm email by user" + user.Id);
            return RedirectToAction("pagenotfound", "home");
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.List)]
        public  IActionResult ResetPasswordAdmin(string key)
        {
            if (key == null)
                return RedirectToAction("pagenotfound", "home");
            ViewBag.Key = key;
            return View();
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.List)]
        public async Task<IActionResult> ResetPasswordAdmin(ResetPasswordViewMedel model)
        {
            if (ModelState.IsValid)
            {
                if (model.NewPassoword != model.ConfirmNewPassword)
                {
                    ModelState.AddModelError("NewPassoword", "");
                    ViewBag.Error = "New password not match.";
                }
                else
                {
                    try
                    {
                        await _account.ResetPasswordAdmin(model);
                        Log.Information("Reset password successfully by user " + User.FindFirstValue(ClaimTypes.NameIdentifier));
                        return RedirectToAction("index", "account");
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "NotFound")
                        {
                            return RedirectToAction("pagenotfound", "home");
                        }
                        else if (ex.InnerException.Message == "Error")
                        {
                            ModelState.AddModelError("newpassoword", ex.Message);
                            ViewBag.Error = ex.Message;
                        }
                        else
                        {
                            Log.Error("Something went wrong while reset password :" + ex.Message);
                            ViewBag.Error = "Something went wrong";
                        }
                    }
                }
            }
            ViewBag.Key = model.Key;
            return View();
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.List)]
        public IActionResult ProvidingUser(string key)
        {
            if (key == null)
                return RedirectToAction("pagenotfound", "home");
            var user = _account.FindById(key.UnProtection());
            if(user==null)
                return RedirectToAction("pagenotfound", "home");
            var model = new ProvidUserViewModel
            {
                MainMenuId= user.MainMenuId,
                UserId=user.Id,
                Username=user.FullName,
                Roles = _account.GetArrayRoleById(key.UnProtection())
            };
           
            ViewData["MainMenu"] = new SelectList(_mainMenu.GetMainMenus(),"Id","Description");
            ViewData["Role"] = new SelectList(_role.GetRoles(User.FindFirst("CompanyID").Value), "Id", "Name");
            return View(model);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.List)]
        public async Task<IActionResult> ProvidingUser(ProvidUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _account.SaveProvidingUser(model);
                    return RedirectToAction("index", "account");

                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }

            ViewData["MainMenu"] = new SelectList(_mainMenu.GetMainMenus(), "Id", "Description");
            ViewData["Role"] = new SelectList(_role.GetRoles(User.FindFirst("CompanyID").Value), "Id", "Name");
            return View(model);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.List)]
        public IActionResult ProvidUserAccessRight(string key)
        {
            if (key == null)
                return RedirectToAction("pagenotfound", "home");
            var user = _account.FindById(key.UnProtection());
            if (user == null)
                return RedirectToAction("pagenotfound", "home");
            ProvidUserAccessRightViewModel model = new ProvidUserAccessRightViewModel
            {
                UserId = user.Id,
                Username = user.FullName,
                MenuItemId = null,
                AccessRight = null
            };
            ViewData["ListAccessRight"] = _account.GetUserClaim(key.UnProtection());
            ViewData["Menus"] = new SelectList(_lookup.GetLookupMenu(), "Id", "Description");
            ViewData["AccessRight"] = new SelectList(_lookup.GetOption("ACCESS.RIGHT"), "Id", "Description");
            return View(model);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.List)]
        public async Task<IActionResult> ProvidUserAccessRight(ProvidUserAccessRightViewModel model)
        {
            if (ModelState.IsValid)
            {
                var hasClaim = _context.UserClaims.FirstOrDefault(x => x.ClaimType == model.MenuItemId && x.UserId == model.UserId);
                if (hasClaim == null)
                {
                    try
                    {
                        await _account.SaveUserClaim(model);
                        return RedirectToAction("providuseraccessright", "account", new { key = model.UserId.Protection() });
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
            
            var user = _account.FindById(model.UserId);
            if (user == null)
                return RedirectToAction("pagenotfound", "home");

            ProvidUserAccessRightViewModel modelView = new ProvidUserAccessRightViewModel
            {
                UserId = user.Id,
                Username = user.FullName,
                MenuItemId =  model.MenuItemId,
                AccessRight = model.AccessRight
            };
            ViewData["ListAccessRight"] = _account.GetUserClaim(model.UserId);
            ViewData["Menus"] = new SelectList(_lookup.GetLookupMenu(), "Id", "Description");
            ViewData["AccessRight"] = new SelectList(_lookup.GetOption("ACCESS.RIGHT"), "Id", "Description");
            return View(modelView);
        }
        [HttpGet]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.Edit)]
        public  IActionResult EditUserClaim(string key)
        {
            if(key==null)
                return RedirectToAction("pagenotfound", "home");
            var userClaim = _account.GetUserClaimById(int.Parse(key.UnProtection()));
            if(userClaim==null)
                return RedirectToAction("pagenotfound", "home");
            userClaim.AccessRight = userClaim.ClaimValue.Split(',');
            ViewData["AccessRight"] = new SelectList(_lookup.GetOption("ACCESS.RIGHT"), "Id", "Description");
            return View(userClaim);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.Edit)]
        public IActionResult EditUserClaim(UserClaimViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userClaim = _context.UserClaims.FirstOrDefault(x => x.Id == model.Id);
                if (userClaim != null)
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
                            userClaim.ClaimValue = access;
                        }
                        _context.UserClaims.Update(userClaim);
                        _context.SaveChanges();

                        Log.Information("Update user access right successfully." + "By user " + User.FindFirstValue(ClaimTypes.NameIdentifier) + "data " + JsonConvert.SerializeObject(model));
                        return RedirectToAction("providuseraccessright", "account", new { key = model.UserId.Protection() });
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Something went wrong while update user access right." + ex + "data " + JsonConvert.SerializeObject(model));
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
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.Delete)]
        public IActionResult DeleteUserClaim(string key)
        {
            if (key == null)
                return RedirectToAction("pagenotfound", "home");
            var userClaim = _account.GetUserClaimById(int.Parse(key.UnProtection()));
            if (userClaim == null)
                return RedirectToAction("pagenotfound", "home");
            return View(userClaim);
        }
        [HttpPost]
        [UserClaimRequirement(MenuContract.UserAccount, AccessRightContract.Delete)]
        public IActionResult DeleteUserClaim(UserClaimViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userClaim = _context.UserClaims.FirstOrDefault(x => x.Id == model.Id);
                if (userClaim != null)
                {
                    try
                    {
                        _context.UserClaims.Remove(userClaim);
                        _context.SaveChanges();

                        Log.Information("Delete user access right successfully." + "By user " + User.FindFirstValue(ClaimTypes.NameIdentifier) + "data " + JsonConvert.SerializeObject(model));
                        return RedirectToAction("providuseraccessright", "account", new { key = model.UserId.Protection() });
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Something went wrong while delete user access right." + ex + "data " + JsonConvert.SerializeObject(model));
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
