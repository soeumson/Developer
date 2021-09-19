using Ecommerce.Core.AppContext;
using Ecommerce.Core.Model.RoleManager;
using EcommerceBackEnd.Extension;
using EcommerceBackEnd.Models;
using EcommerceBackEnd.Services;
using EcommerceBackEnd.ViewModels;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Reposiotrys
{
    public class RoleRepository:IRole
    {
        private readonly DataContext _context;
        private readonly RoleManager<Role> _roleManager;
        public RoleRepository(DataContext context, RoleManager<Role> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }
        public IEnumerable<Role> GetRoles(string companyID)
        {
            var roles = from r in _context.Roles
                        join x in _context.Users on r.CreateBy equals x.Id into xx
                        from c_b in xx.DefaultIfEmpty()
                        join y in _context.Users on r.UpdateBy equals y.Id into yy
                        from u_b in yy.DefaultIfEmpty()
                        join z in _context.CompanyProfile on r.CompanyID equals z.CompanyID into zz
                        from com in zz.DefaultIfEmpty()
                        where r.CompanyID==companyID
                        select new Role
                        {
                            Encryted = r.Id.Protection(),
                            Name = r.Name,
                            Id = r.Id,
                            CompanyID = com.CompanyName ?? r.CompanyID,
                            CreateBy = c_b.FullName ?? r.CreateBy,
                            CreateDate = r.CreateDate,
                            UpdateBy = u_b.FullName ?? r.UpdateBy,
                            UpdateDate = r.UpdateDate
                        };
            return roles;
        }
        public async Task Create(Role model,string companyID,string currentUser)
        {
            try
            {
                Role role = new Role
                {
                    Name = model.Name,
                    CompanyID = companyID,
                    CreateBy = currentUser,
                    CreateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt")),
                };
                _context.Roles.Add(role);
                await _context.SaveChangesAsync();
                Log.Information("Create role successfully. " + "Id "  +  role.Id);
            }
            catch(Exception ex)
            {
                Log.Error("Something went wrong while create role." + ex  +"data " + JsonConvert.SerializeObject(model));
                throw new Exception("Something went wrong.");
            }
            
        }
        public async Task Edit(Role model, string companyID, string currentUser)
        {
            try
            {
                var Role = await _roleManager.FindByIdAsync(model.Id);
                Role.Name = model.Name;
                Role.CompanyID = companyID;
                Role.UpdateDate = Convert.ToString(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt"));
                Role.UpdateBy = currentUser;

                _context.Roles.Update(Role);
                await _context.SaveChangesAsync();
                Log.Information("Update role successfully." + "Id "  + model.Id);
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong create role." + ex + "data " + JsonConvert.SerializeObject(model));
                throw new Exception("Something went wrong.");
            }
        }
        public Role FindById(string key) 
        {
            var roles = from r in _context.Roles
                        join x in _context.Users on r.CreateBy equals x.Id into xx
                        from c_b in xx.DefaultIfEmpty()
                        join y in _context.Users on r.UpdateBy equals y.Id into yy
                        from u_b in yy.DefaultIfEmpty()
                        join z in _context.CompanyProfile on r.CompanyID equals z.CompanyID into zz
                        from com in zz.DefaultIfEmpty()
                        where r.Id==key
                        select new Role
                        {
                            Encryted = r.Id.Protection(),
                            Name = r.Name,
                            Id = r.Id,
                            CompanyID = com.CompanyName ?? r.CompanyID,
                            CreateBy = c_b.FullName ?? r.CreateBy,
                            CreateDate = r.CreateDate,
                            UpdateBy = u_b.FullName ?? r.UpdateBy,
                            UpdateDate = r.UpdateDate
                        };
            return roles.Count() > 0 ? roles.First() : null;
        }
        public void Delete(Role role)
        {
            try
            {
                var data = _context.Roles.FirstOrDefault(x => x.Id.Equals(role.Id));
                if (data == null)
                {
                    Log.Warning("Role id not found." + role.Id);
                }
                else
                {
                    _context.Roles.Remove(data);
                    _context.SaveChanges();

                    Log.Information("Delete role successfully " + "data" + JsonConvert.SerializeObject(data));
                }
            }
            catch (Exception ex)
            {
                Log.Error("Something went wrong while delete role." + ex + "Id " + role.Id);
                throw new Exception("Something went wrong.");
            }
        }

        public IEnumerable<RoleClaimViewModel> GetRoleClaim(string roleId)
        {
            var data = from uc in _context.RoleClaims join
                       menu in _context.LookupMenus on uc.ClaimType equals menu.Id
                       where uc.RoleId == roleId
                       select new RoleClaimViewModel
                       {
                           Id = uc.Id,
                           RoleId = uc.RoleId,
                           ClaimType = menu.Description,
                           ClaimValue = uc.ClaimValue,
                           Encryted = uc.Id.ToString().Protection()
                       };
            return data;
        }
        public RoleClaimViewModel GetRoleClaimById(int key)
        {
            var data = from uc in _context.RoleClaims join
                       menu in _context.LookupMenus on uc.ClaimType equals menu.Id
                       where uc.Id == key
                       select new RoleClaimViewModel
                       {
                           Id = uc.Id,
                           RoleId = uc.RoleId,
                           ClaimType = menu.Description,
                           ClaimValue = uc.ClaimValue,
                           Encryted = uc.Id.ToString().Protection()
                       };
            return data.Count() >0 ? data.First() : null;
        }
        public async Task SaveRoleClaim(ProvidRoleAccessRightViewModel model,string userId)
        {
            try
            {
                IdentityRoleClaim<string> RoleClaim = new IdentityRoleClaim<string>();
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
                    RoleClaim.ClaimValue = access;
                }
                RoleClaim.RoleId = model.RoleId;
                RoleClaim.ClaimType = model.MenuItemId;

                _context.RoleClaims.Add(RoleClaim);
                await _context.SaveChangesAsync();
                Log.Information("Add role access right successfully." + "data " + JsonConvert.SerializeObject(model) + "By user " + userId);
            }
            catch(Exception ex)
            {
                Log.Error("Something went wrong while add role access right " + ex + "data " + JsonConvert.SerializeObject(model));
                throw new Exception("Something went wrong");
            }
        }
    }
}
