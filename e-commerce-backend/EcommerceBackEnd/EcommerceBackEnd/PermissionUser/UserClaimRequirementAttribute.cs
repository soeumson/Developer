using Ecommerce.Core.Model.ContractClass;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceBackEnd.PermissionUser
{
    public class UserClaimRequirementAttribute : TypeFilterAttribute
    {

        public UserClaimRequirementAttribute(string claimType, string claimValue) : base(typeof(UserClaimRequirementFilter))
        {
            Arguments = new object[] { new Claim(claimType, claimValue) };
        }
    }

    public class UserClaimRequirementFilter : IAuthorizationFilter
    {
        readonly Claim _claim;

        public UserClaimRequirementFilter(Claim claim)
        {
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {

            if (!context.HttpContext.User.Claims.Any(c => c.Type == MenuContract.AllMenu))
            {
                var hasClaim = context.HttpContext.User.Claims.Any(c => c.Type == _claim.Type && c.Value.Contains(_claim.Value));
                if (!hasClaim)
                {
                    context.Result = new ForbidResult();
                }
            }
            else
            {
                var hasClaim = context.HttpContext.User.Claims.Any(c => c.Type == MenuContract.AllMenu && c.Value == AccessRightContract.All);
                if (!hasClaim)
                {
                    hasClaim = context.HttpContext.User.Claims.Any(c => c.Type == MenuContract.AllMenu && c.Value.Contains(_claim.Value));
                    if (!hasClaim)
                    {
                        context.Result = new ForbidResult();
                    }

                }
            }

        }
    }
}
