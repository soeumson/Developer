using Ecommerce.Core.Model.Account;
using EcommerceBackEnd.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBackEnd.Services
{
    public interface IAccount
    {
        IEnumerable<Account> GetAccounts();
        Task<List<IdentityError>> Create(Account account);
        void Update(Account account);
        AccountViewModel FindById(string key);
        Task<List<IdentityError>> RegisterUser(Account account);
        Task<string> LoginControl(LoginViewModel model);
        Task ResetPassword(ResetPasswordViewMedel model);
        Task ResetPasswordAdmin(ResetPasswordViewMedel model);
        Task ResetPasswordSendEmail(ResetPasswordViewMedel model);

        IEnumerable<Account> GetApprovalUsers();
        Account FindApprovalUser(string key);
        MenusViewModel.MainModel GetMenus(string mainId);
        string[] GetArrayRoleById(string userId);
        Task SaveProvidingUser(ProvidUserViewModel model);
        IEnumerable<UserClaimViewModel> GetUserClaim(string userId);
        UserClaimViewModel GetUserClaimById(int key);
        Task SaveUserClaim(ProvidUserAccessRightViewModel model);
    }
}
