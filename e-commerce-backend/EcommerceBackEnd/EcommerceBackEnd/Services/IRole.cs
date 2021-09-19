using Ecommerce.Core.Model.RoleManager;
using EcommerceBackEnd.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Services
{
    public interface IRole
    {
        IEnumerable<Role> GetRoles(string companyID);
        Task Create(Role model,string companyID,string currentUser);
        Task Edit(Role model, string companyID, string currentUser);
        void Delete(Role role);
        Role FindById(string key);
        IEnumerable<RoleClaimViewModel> GetRoleClaim(string roleId);
        RoleClaimViewModel GetRoleClaimById(int key);
        Task SaveRoleClaim(ProvidRoleAccessRightViewModel model, string userId);
    }
}
