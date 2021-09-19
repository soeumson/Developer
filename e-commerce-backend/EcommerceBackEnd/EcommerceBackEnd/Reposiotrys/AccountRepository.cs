using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.Account;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.Models;
using EcommerceBackEnd.Services;
using EcommerceBackEnd.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Reposiotrys
{
    public class AccountRepository : IAccount
    {
        private readonly UserManager<Account> _usermanager;
        private readonly DataContext _context;
        private readonly SignInManager<Account> _singInManager;
        private string UserID;
        private string CompanyID;
        public AccountRepository(UserManager<Account> manager,DataContext context,
             IHttpContextAccessor httpContextAccessor,
             SignInManager<Account> signInManager)
        {
            _usermanager = manager;
            _singInManager = signInManager;
            _context = context;
            UserID = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            CompanyID = httpContextAccessor.HttpContext.User.Claims.Count() == 0 ? null : httpContextAccessor.HttpContext.User.FindFirst("CompanyID").Value;
        }
        public async Task<List<IdentityError>> Create(Account account)
        {
            try
            {
                account.Status = true;
                account.FullName = account.FirstName + " " + account.LastName;  
                account.CompanyID = CompanyID;
                account.CreateBy = UserID;
                account.CreateDate =Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                account.UserName = account.Email;
                var result = await _usermanager.CreateAsync(account, account.PasswordHash);
                if (result.Succeeded)
                {
                    Log.Information("Create user account sccessful." + "Id " + account.Id );
                }
                else
                {
                    Log.Error("Invalid model object :" + result.Errors);
                    return result.Errors.ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong while create user account " + ex  + "data " + JsonConvert.SerializeObject(account));
                throw new Exception("Something went wrong.");
            }
            return new List<IdentityError>();
        }
        public AccountViewModel FindById(string key)
        {
            var result = (from u in _context.Users
                         join x in _context.Users on u.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                         join y in _context.Users on u.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                         join z in _context.CompanyProfile on u.CompanyID equals z.CompanyID into zz from com in zz.DefaultIfEmpty()
                         where u.Id == key
                         select new AccountViewModel
                         {
                             Id=u.Id,
                             FirstName=u.FirstName,
                             LastName=u.LastName,
                             FullName=u.FullName,
                             StartDateProfile=u.StartDateProfile,
                             PhoneNumber=u.PhoneNumber,
                             Email=u.Email,
                             Image=u.Image,
                             CompanyID=com.CompanyName ?? u.CompanyID,
                             CreateBy=c_b.FullName ?? u.CreateBy,
                             CreateDate=u.CreateDate,
                             UpdateBy=u_b.FullName ?? u.UpdateBy,
                             UpdateDate=u.UpdateDate,
                             Encryted= u.Id.Protection(),
                             UserType=u.UserType,
                             UserName=u.UserName,
                             Status=u.Status
                         }).ToList();
            return result.Count() > 0 ? result.First() : null;
        }
        public IEnumerable<Account> GetAccounts()
        {
            var result = (from u in _context.Users
                          join x in _context.Users on u.CreateBy equals x.Id into xx from c_b in xx.DefaultIfEmpty()
                          join y in _context.Users on u.UpdateBy equals y.Id into yy from u_b in yy.DefaultIfEmpty()
                          join z in _context.CompanyProfile on u.CompanyID equals z.CompanyID into zz from com in zz.DefaultIfEmpty()
                          where u.CompanyID==CompanyID && u.UserType!= "ADMINUSER"
                          select new AccountViewModel
                          {
                              Id=u.Id,
                              FirstName = u.FirstName,
                              LastName = u.LastName,
                              FullName = u.FullName,
                              StartDateProfile = u.StartDateProfile,
                              PhoneNumber = u.PhoneNumber,
                              Email = u.Email,
                              Image = u.Image,
                              CompanyID = com.CompanyName ?? u.CompanyID,
                              CreateBy = c_b.FullName ?? u.CreateBy,
                              CreateDate = u.CreateDate,
                              UpdateBy = u_b.FullName ?? u.UpdateBy,
                              UpdateDate = u.UpdateDate,
                              Encryted = u.Id.Protection(),
                              UserType = u.UserType,
                              UserName = u.UserName,
                              Status = u.Status
                          }).ToList();
            return result;
        }
        public async Task<List<IdentityError>> RegisterUser(Account account)
        {
            try
            {
                account.FullName = account.FirstName + " " + account.LastName;
                account.CreateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                account.Status = true;
                account.Approval = false;
                account.StartDateProfile = DateTime.Today;
                account.UserName = account.Email;
                account.UserType = "ADMINUSER";
                var result = await _usermanager.CreateAsync(account, account.PasswordHash);
                if (result.Succeeded)
                {
                    Log.Information("Register user account sccessfully." + "Id " + account.Id);
                }
                else
                {
                    Log.Error("Something went wrong while register user." + result.Errors);
                    return result.Errors.ToList();
                }
            }
            catch(Exception ex)
            {
                Log.Error("Something went wrong while register user." + ex + "data "  + JsonConvert.SerializeObject(account));
                throw new Exception("Something went wrong.");
            }

            return new List<IdentityError>();
        }
        public void Update(Account account)
        {
            var User = _context.Users.FirstOrDefault(x => x.Id.Equals(account.Encryted.UnProtection()));
            if (User != null)
            {
                try
                {
                    User.FirstName = account.FirstName;
                    User.LastName = account.LastName;
                    User.FullName = account.FirstName + " " + account.LastName;
                    User.PhoneNumber = account.PhoneNumber;
                    User.StartDateProfile = account.StartDateProfile;
                    User.UpdateBy = UserID;
                    User.Image = account.Image;
                    User.Status = account.Status;
                    User.UpdateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    _context.Update(User);
                    _context.SaveChanges();
                }
                catch(Exception ex)
                {
                    Log.Error("Something went wrong while update user." + ex + "data " + JsonConvert.SerializeObject(User));
                    throw new Exception("Something went wrong.");
                }
            }
            else
            {
                Log.Error("User id not found ID :" + account.Encryted.UnProtection());
                throw new Exception("User id not found.");
            }
        }
        public async Task<string> LoginControl(LoginViewModel model)
        {
            var ConfirmUser = await _usermanager.FindByNameAsync(model.EmailAddress);
            if (ConfirmUser != null)
            {
                if (ConfirmUser.UserType == "ADMINUSER")
                {
                    if (ConfirmUser.EmailConfirmed)
                    {
                        if (ConfirmUser.Approval)
                        {
                            if (ConfirmUser.StartDateProfile <= DateTime.Today)
                            {
                                if (ConfirmUser.Status)
                                {
                                    var result = await _singInManager.PasswordSignInAsync(model.EmailAddress, model.Password, isPersistent: false, lockoutOnFailure: true);
                                    if (result.Succeeded)
                                    {

                                        Log.Information("Login successfully by email user" + model.EmailAddress);
                                        return "SC";
                                    }
                                    else if (result.IsLockedOut)
                                    {
                                        Log.Warning("User account locked out." + model.EmailAddress);
                                        return "LK";
                                    }
                                    return "GN";
                                }
                                return "SU";
                            }
                            return "SD";
                        }
                        return "AP";
                    }
                    return "EP";
                }
                else
                {
                    if (ConfirmUser.StartDateProfile <= DateTime.Today)
                    {
                        if (ConfirmUser.Status)
                        {
                            var result = await _singInManager.PasswordSignInAsync(model.EmailAddress, model.Password, isPersistent: false, lockoutOnFailure: true);
                            if (result.Succeeded)
                            {
                                if (ConfirmUser.ResetPassword)
                                {
                                    Log.Information("Login successfully by email user" + model.EmailAddress);
                                    return "SC";
                                }
                                return "RP";
                            }
                            else if (result.IsLockedOut)
                            {
                                Log.Warning("User account locked out." + model.EmailAddress);
                                return "LK";
                            }
                            return "GN";
                        }
                        return "SU";
                    }
                    return "SD";
                }
            }
            return "GN";
        }
        public async Task ResetPassword(ResetPasswordViewMedel model)
        {
            var AllErorr = "";
            var account = await _usermanager.FindByIdAsync(UserID);
            if (account != null)
            {

                var Token = await _usermanager.GeneratePasswordResetTokenAsync(account);
                var result = await _usermanager.ResetPasswordAsync(account, Token, model.NewPassoword);
                if (result.Succeeded)
                {
                    account.ResetPassword = true;
                    _context.Users.Update(account);
                    _context.SaveChanges();
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        AllErorr = AllErorr + "." + item.Description;
                    }
                    throw new Exception(AllErorr, innerException: new Exception("Error"));
                }
            }
            else
            {
                throw new Exception("NotFound");
            }
        }
        public async Task ResetPasswordAdmin(ResetPasswordViewMedel model)
        {
            var AllErorr = "";
            var account = await _usermanager.FindByIdAsync(model.Key.UnProtection());
            if (account != null)
            {

                var Token = await _usermanager.GeneratePasswordResetTokenAsync(account);
                var result = await _usermanager.ResetPasswordAsync(account, Token, model.NewPassoword);
                if (result.Succeeded)
                {
                    account.ResetPassword = false;
                    _context.Users.Update(account);
                    _context.SaveChanges();
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        AllErorr = AllErorr + "." + item.Description;
                    }
                    throw new Exception(AllErorr, innerException: new Exception("Error"));
                }
            }
            else
            {
                throw new Exception("NotFound");
            }
        }
        public async Task ResetPasswordSendEmail(ResetPasswordViewMedel model)
        {
            var AllErorr = "";
            var account = await _usermanager.FindByEmailAsync(model.Email);
            if (account != null)
            {
                var result = await _usermanager.ResetPasswordAsync(account, model.Token, model.NewPassoword);
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        AllErorr = AllErorr + "." + item.Description;
                    }
                    throw new Exception(AllErorr, innerException: new Exception("Error"));
                }
            }
            else
            {
                throw new Exception("NotFound");
            }
        }
        public IEnumerable<Account> GetApprovalUsers()
        {
            var result = (from u in _context.Users
                          join x in _context.Users on u.CreateBy equals x.Id into xx
                          from c_b in xx.DefaultIfEmpty()
                          join y in _context.Users on u.UpdateBy equals y.Id into yy
                          from u_b in yy.DefaultIfEmpty()
                          join z in _context.CompanyProfile on u.CompanyID equals z.CompanyID into zz
                          from com in zz.DefaultIfEmpty()
                          where  u.UserType == "ADMINUSER"
                          select new Account
                          {
                              FirstName = u.FirstName,
                              LastName = u.LastName,
                              FullName = u.FullName,
                              StartDateProfile = u.StartDateProfile,
                              PhoneNumber = u.PhoneNumber,
                              Email = u.Email,
                              Image = u.Image,
                              CompanyID = com.CompanyName ?? u.CompanyID,
                              CreateBy = c_b.FullName ?? u.CreateBy,
                              CreateDate = u.CreateDate,
                              UpdateBy = u_b.FullName ?? u.UpdateBy,
                              UpdateDate = u.UpdateDate,
                              Encryted = u.Id.Protection(),
                              UserType = u.UserType,
                              UserName = u.UserName,
                              Status = u.Status,
                              Approval=u.Approval
                          }).ToList();
            return result;
        }
        public Account FindApprovalUser(string key)
        {
            var result = (from u in _context.Users
                          join x in _context.Users on u.CreateBy equals x.Id into xx
                          from c_b in xx.DefaultIfEmpty()
                          join y in _context.Users on u.UpdateBy equals y.Id into yy
                          from u_b in yy.DefaultIfEmpty()
                          join z in _context.CompanyProfile on u.CompanyID equals z.CompanyID into zz
                          from com in zz.DefaultIfEmpty()
                          where u.Id == key
                          select new Account
                          {
                              FirstName = u.FirstName,
                              LastName = u.LastName,
                              FullName = u.FullName,
                              StartDateProfile = u.StartDateProfile,
                              PhoneNumber = u.PhoneNumber,
                              Email = u.Email,
                              Image = u.Image,
                              CompanyID = com.CompanyName ?? u.CompanyID,
                              CreateBy = c_b.FullName ?? u.CreateBy,
                              CreateDate = u.CreateDate,
                              UpdateBy = u_b.FullName ?? u.UpdateBy,
                              UpdateDate = u.UpdateDate,
                              Encryted = u.Id.Protection(),
                              UserType = u.UserType,
                              UserName = u.UserName,
                              Status = u.Status,
                              Approval = u.Approval
                          }).ToList();
            return result.Count() > 0 ? result.First() : null;
        }
        public MenusViewModel.MainModel GetMenus(string mainId)
        {
            var mains = new MenusViewModel.MainModel();
            try
            {
                var find = _context.MainMenu.FirstOrDefault(x => x.Id == mainId);
                if (find != null)
                {
                    mains.Id = find.Id;
                    mains.Description = find.Description;
                    var menus = new List<MenusViewModel.MenuModel>();
                    foreach (var m in find.MenuId.Split(','))
                    {
                        var find_menu = _context.Menu.FirstOrDefault(x => x.Id == m);
                        var menu = new MenusViewModel.MenuModel();
                        if (menu != null)
                        {
                            menu.Id = find_menu.Id;
                            menu.Description = find_menu.Description;
                            menu.KhmerDescription = find_menu.KhmerDescription;
                            menu.Icon = find_menu.Icon;
                        }
                        menus.Add(menu);
                        var items = new List<MenusViewModel.MenuItemModel>();
                        foreach (var i in find_menu.MenuItemId.Split(','))
                        {
                            var find_item = _context.MenuItem.FirstOrDefault(x => x.Id == i);
                            var item = new MenusViewModel.MenuItemModel();
                            if (find_item != null)
                            {
                                item.Id = find_item.Id;
                                item.Description = find_item.Description;
                                item.KhmerDescription = find_item.KhmerDescription;
                                item.Url = find_item.Url;
                            }
                            items.Add(item);
                        }
                        menu.MenuItemModel = items;
                    }
                    mains.MenuModel = menus;
                }
            }
            catch(Exception ex)
            {
                Log.Error("Something went wrong while get menu user." + ex) ;
            }
            return mains;

        }
        public string[] GetArrayRoleById(string userId)
        {
            var data = _context.UserRoles.Where(x => x.UserId == userId).Select(x => x.RoleId).ToArray();
            return data;
        }
        public async Task SaveProvidingUser(ProvidUserViewModel model)
        {
            try
            {
                var user = await _usermanager.FindByIdAsync(model.UserId);
                user.MainMenuId = model.MainMenuId;
                var result= await _usermanager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    var userRoles = _context.UserRoles.Where(x => x.UserId == model.UserId);
                    if(userRoles.Count() > 0)
                    {
                        _context.RemoveRange(userRoles);
                        _context.SaveChanges();
                    }
                    for (int i = 0; i < model.Roles.Length; i++)
                    {
                        var ur = new IdentityUserRole<string>
                        {
                            RoleId = model.Roles[i],
                            UserId = model.UserId
                        };
                        _context.UserRoles.Add(ur);
                        _context.SaveChanges();
                    }
                }
                else
                {
                    var allError = "";
                    foreach (var item in result.Errors)
                    {
                        if (allError == "")
                            allError = item.Description;
                        else
                            allError += "," + item.Description;
                    }
                    throw new Exception(allError);
                }
                Log.Information("Save providing user successfully." + "data " + JsonConvert.SerializeObject(model) + "By UserID " + UserID);
            }catch(Exception ex)
            {
                Log.Error("Something went wrong save providing user." + ex + "data "  + JsonConvert.SerializeObject(model));
                throw new Exception("Something went wrong.");
            }
        }

        public IEnumerable<UserClaimViewModel> GetUserClaim(string userId)
        {
            var data = from uc in _context.UserClaims join
                       menu in _context.LookupMenus on uc.ClaimType equals menu.Id
                       where uc.UserId == userId
                       select new UserClaimViewModel
                       {
                           Id = uc.Id,
                           UserId = uc.UserId,
                           ClaimType = menu.Description,
                           ClaimValue = uc.ClaimValue,
                           Encryted = uc.Id.ToString().Protection()
                       };
            return data;
        }
        public UserClaimViewModel GetUserClaimById(int key)
        {
            var data = from uc in _context.UserClaims join
                       menu in _context.LookupMenus on uc.ClaimType equals menu.Id
                       where uc.Id == key
                       select new UserClaimViewModel
                       {
                           Id = uc.Id,
                           UserId = uc.UserId,
                           ClaimType = menu.Description,
                           ClaimValue = uc.ClaimValue,
                           Encryted = uc.Id.ToString().Protection()
                       };
            return data.Count() >0 ? data.First() : null;
        }
        public async Task SaveUserClaim(ProvidUserAccessRightViewModel model)
        {
            try
            {
                IdentityUserClaim<string> UserClaim = new IdentityUserClaim<string>();
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
                    UserClaim.ClaimValue = access;
                }
                UserClaim.UserId = model.UserId;
                UserClaim.ClaimType = model.MenuItemId;

                _context.UserClaims.Add(UserClaim);
                await _context.SaveChangesAsync();
                Log.Information("Add user access right successfully." + "data " + JsonConvert.SerializeObject(model) + "By user " + UserID);
            }
            catch(Exception ex)
            {
                Log.Error("Something went wrong while add user access right " + ex + "data " + JsonConvert.SerializeObject(model));
                throw new Exception("Something went wrong");
            }
        }
    }
}
