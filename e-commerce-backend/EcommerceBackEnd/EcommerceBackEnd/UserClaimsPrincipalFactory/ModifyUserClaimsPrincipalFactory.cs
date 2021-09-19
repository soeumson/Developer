using Ecommerce.Core.Model.Account;
using EcommerceBackEnd.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceBackEnd.UserClaimsPrincipalFactory
{
    public class ModifyUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<Account>
    {
        private readonly UserManager<Account> _userManager;
        public ModifyUserClaimsPrincipalFactory(
            UserManager<Account> userManager,
            IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, optionsAccessor)
        {
            _userManager = userManager;
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(Account user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("CompanyID", user.CompanyID ?? ""));
            var account = await _userManager.FindByIdAsync(user.Id);
            if (account != null)
            {
                identity.AddClaim(new Claim("FullName", user.FullName ?? ""));
            }
            return identity;
        }
    }
}
